﻿#region Copyright Kayomani 2011.  Licensed under the GPLv3 (Or later version), Expand for details. Do not remove this notice.

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
using ProtoBuf;

namespace FAP.Domain.Entities.FileSystem
{
    [Serializable]
    [ProtoContract]
    [ProtoInclude(20, typeof (Directory))]
    public class File : IComparable
    {
        [ProtoMember(1)]
        public string Name { set; get; }

        [ProtoMember(2)]
        public long Size { set; get; }

        [ProtoMember(3)]
        public long LastModified { set; get; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj is File)
            {
                var f = obj as File;
                return f.Name.CompareTo(Name);
            }
            return -1;
        }

        #endregion
    }
}