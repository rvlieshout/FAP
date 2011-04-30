﻿#region Copyright Kayomani 2010.  Licensed under the GPLv3 (Or later version), Expand for details. Do not remove this notice.
/**
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or any 
    later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * */
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fap.Foundation;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NLog;

namespace FAP.Domain.Entities
{
    [Serializable]
    public class DownloadQueue
    {
        private SafeObservedCollection<DownloadRequest> queue = new SafeObservedCollection<DownloadRequest>();

        private readonly string saveLocation;
        private object sync = new object();

        public DownloadQueue()
        {
            saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FAP\Queue.cfg";
        }


        public SafeObservedCollection<DownloadRequest> List
        {
            get
            {
                return queue;
            }
        }

        public void Save()
        {
            lock (sync)
                File.WriteAllText(saveLocation, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public void Load()
        {
            lock (sync)
            {
                try
                {
                    DownloadQueue saved = JsonConvert.DeserializeObject<DownloadQueue>(File.ReadAllText(saveLocation));
                    queue.Clear();
                    queue.AddRange(saved.List.ToList());
                }
                catch (Exception e)
                {
                    LogManager.GetLogger("faplog").WarnException("Failed to read download queue", e);
                }
            }
        }
    }
}
