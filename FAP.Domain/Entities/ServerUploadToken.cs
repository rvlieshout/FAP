﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FAP.Domain.Entities
{
    /// <summary>
    /// A token representing an upload slot.  When the position is 0 then the upload can be sent.
    /// </summary>
    public class ServerUploadToken : IDisposable
    {
        private int globalQueuePosition = 0;
        private string remoteEndPoint;
        private AutoResetEvent sync = new AutoResetEvent(true);

        public int GlobalQueuePosition
        {
            get
            {
                lock (sync)
                    return globalQueuePosition;
            }
            set
            {
                lock (sync)
                    globalQueuePosition = value;
                sync.Set();
            }
        }

        public string RemoteEndPoint
        {
            set
            {
                lock (sync)
                    remoteEndPoint = value;
            }
            get
            {
                lock (sync)
                    return remoteEndPoint;
            }
        }

        public void Wait()
        {
            sync.WaitOne();
        }

        public void WaitTimeout()
        {
            sync.WaitOne(5000);
        }

        public void Dispose()
        {
            sync.Close();
        }
    }
}