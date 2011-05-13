﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using FAP.Domain.Net;
using FAP.Domain.Entities;
using System.Threading;
using NLog;

namespace FAP.Domain.Services
{
    /// <summary>
    /// A class designed to be called at regular intervals.  It checks to see if there are enough overlords running 
    /// on the LAN or too many and responds as appropriate by launching or killing the local overlord.
    /// </summary>
    public class OverlordManagerService
    {
        private ListenerService overlord;
        private IContainer container;
        private LANPeerFinderService peerFinder;
        private Model model;
        private object sync = new object();

        private bool serverLaunching = false;

        public OverlordManagerService(IContainer c)
        {
            container = c;
            model = c.Resolve<Model>();
        }

        public void Start()
        {
            lock (sync)
            {
                if (null == overlord)
                {
                    LogManager.GetLogger("faplog").Info("Launching local overlord.");
                    overlord = new ListenerService(container, true);
                    overlord.Start(40);
                }
            }
        }

        public bool IsOverlordActive
        {
            get { return overlord != null; }
        }

        public void Stop()
        {
            lock (sync)
            {
                if (null != overlord)
                {
                    overlord.Stop();
                    overlord = null;
                }
            }
        }


        public void StartAndStopIfNeeded()
        {
            lock (sync)
            {
                if (overlord != null)
                {
                    //TODO: Stop if needed
                    return;
                }
                //Dont allow multiple launchers
                if (serverLaunching)
                    return;
                if (IsNewServerNeeded())
                {
                    //Launch a local overlord
                    serverLaunching = true;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LaunchOverlordWithDelay));
                }
            }
        }

        private void LaunchOverlordWithDelay(object o)
        {
            try
            {
                Random r = new Random();
                int delay = 0;
                switch (model.OverlordPriority)
                {
                    //case dedicated
                    // 0-1.5 seconds
                    case OverlordPriority.High:
                        delay = r.Next(2000, 3000);
                        break;
                    case OverlordPriority.Normal:
                        delay = r.Next(3000, 5000);
                        break;
                    case OverlordPriority.Low:
                        delay = r.Next(5000, 8000);
                        break;
                }
                LogManager.GetLogger("faplog").Debug("Overlord start delay: {0}",delay);
                Thread.Sleep(delay);
                //If a server is still needed - launch
                if (IsNewServerNeeded())
                    Start();
            }
            finally
            {
                serverLaunching = false;
            }
        }


        private bool IsNewServerNeeded()
        {
            if (null == peerFinder)
                peerFinder = container.Resolve<LANPeerFinderService>();

            var localOverlords = peerFinder.Peers.ToList().Where(p => (DateTime.Now - p.LastAnnounce).TotalSeconds < 60).ToList();


            int overlords = localOverlords.Count;
            int serversWithFreeSlots = 0;
            int totalUsers = 0;
            int totalSlots = 0;

            foreach (var overlord in localOverlords)
            {
                totalUsers += overlord.CurrentUsers;
                totalSlots += overlord.MaxUsers;
                if (overlord.MaxUsers - overlord.CurrentUsers > 5)
                    serversWithFreeSlots++;
            }

            //Rule 1: Atleast one server
            if (serversWithFreeSlots == 0)
                return true;
            else
            {
                //Rule 2: Atleast 1 server per 100 people
                if (totalUsers > serversWithFreeSlots * 100)
                    return true;
                else
                {
                    if (0 != totalUsers && 0 != totalSlots)
                    {
                        //Rule 3: Atleast 5% free slots
                        if (((double)totalUsers / totalSlots) > 0.95)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
