#region Copyright Kayomani 2010.  Licensed under the GPLv3 (Or later version), Expand for details. Do not remove this notice.
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
// <auto-generated>
// This code was generated by a tool.
// LinqToWmi.ClassGenerator Version: 1.0.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if  the code is regenerated.
// </auto-generated>
namespace Fap.Foundation.WMI_Prototypes
{
    using System;
    using System.Linq;
    using LinqToWmi.Core.WMI;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("LinqToWmi.ClassGenerator", "1.0.0.0")]
    public class Win32_LogicalDisk
    {

        private ushort _access;

        private ushort _availability;

        private ulong _blockSize;

        private string _caption;

        private bool _compressed;

        private uint _configManagerErrorCode;

        private bool _configManagerUserConfig;

        private string _creationClassName;

        private string _description;

        private string _deviceID;

        private uint _driveType;

        private bool _errorCleared;

        private string _errorDescription;

        private string _errorMethodology;

        private string _fileSystem;

        private ulong _freeSpace;

        private System.DateTime _installDate;

        private uint _lastErrorCode;

        private uint _maximumComponentLength;

        private uint _mediaType;

        private string _name;

        private ulong _numberOfBlocks;

        private string _pNPDeviceID;

        private ushort[] _powerManagementCapabilities;

        private bool _powerManagementSupported;

        private string _providerName;

        private string _purpose;

        private bool _quotasDisabled;

        private bool _quotasIncomplete;

        private bool _quotasRebuilding;

        private ulong _size;

        private string _status;

        private ushort _statusInfo;

        private bool _supportsDiskQuotas;

        private bool _supportsFileBasedCompression;

        private string _systemCreationClassName;

        private string _systemName;

        private bool _volumeDirty;

        private string _volumeName;

        private string _volumeSerialNumber;

        /// <summary>
        /// Represents the property Access
        /// </summary>
        public virtual ushort Access
        {
            get
            {
                return this._access;
            }
            set
            {
                this._access = value;
            }
        }

        /// <summary>
        /// Represents the property Availability
        /// </summary>
        public virtual ushort Availability
        {
            get
            {
                return this._availability;
            }
            set
            {
                this._availability = value;
            }
        }

        /// <summary>
        /// Represents the property BlockSize
        /// </summary>
        public virtual ulong BlockSize
        {
            get
            {
                return this._blockSize;
            }
            set
            {
                this._blockSize = value;
            }
        }

        /// <summary>
        /// Represents the property Caption
        /// </summary>
        public virtual string Caption
        {
            get
            {
                return this._caption;
            }
            set
            {
                this._caption = value;
            }
        }

        /// <summary>
        /// Represents the property Compressed
        /// </summary>
        public virtual bool Compressed
        {
            get
            {
                return this._compressed;
            }
            set
            {
                this._compressed = value;
            }
        }

        /// <summary>
        /// Represents the property ConfigManagerErrorCode
        /// </summary>
        public virtual uint ConfigManagerErrorCode
        {
            get
            {
                return this._configManagerErrorCode;
            }
            set
            {
                this._configManagerErrorCode = value;
            }
        }

        /// <summary>
        /// Represents the property ConfigManagerUserConfig
        /// </summary>
        public virtual bool ConfigManagerUserConfig
        {
            get
            {
                return this._configManagerUserConfig;
            }
            set
            {
                this._configManagerUserConfig = value;
            }
        }

        /// <summary>
        /// Represents the property CreationClassName
        /// </summary>
        public virtual string CreationClassName
        {
            get
            {
                return this._creationClassName;
            }
            set
            {
                this._creationClassName = value;
            }
        }

        /// <summary>
        /// Represents the property Description
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        /// <summary>
        /// Represents the property DeviceID
        /// </summary>
        public virtual string DeviceID
        {
            get
            {
                return this._deviceID;
            }
            set
            {
                this._deviceID = value;
            }
        }

        /// <summary>
        /// Represents the property DriveType
        /// </summary>
        public virtual uint DriveType
        {
            get
            {
                return this._driveType;
            }
            set
            {
                this._driveType = value;
            }
        }

        /// <summary>
        /// Represents the property ErrorCleared
        /// </summary>
        public virtual bool ErrorCleared
        {
            get
            {
                return this._errorCleared;
            }
            set
            {
                this._errorCleared = value;
            }
        }

        /// <summary>
        /// Represents the property ErrorDescription
        /// </summary>
        public virtual string ErrorDescription
        {
            get
            {
                return this._errorDescription;
            }
            set
            {
                this._errorDescription = value;
            }
        }

        /// <summary>
        /// Represents the property ErrorMethodology
        /// </summary>
        public virtual string ErrorMethodology
        {
            get
            {
                return this._errorMethodology;
            }
            set
            {
                this._errorMethodology = value;
            }
        }

        /// <summary>
        /// Represents the property FileSystem
        /// </summary>
        public virtual string FileSystem
        {
            get
            {
                return this._fileSystem;
            }
            set
            {
                this._fileSystem = value;
            }
        }

        /// <summary>
        /// Represents the property FreeSpace
        /// </summary>
        public virtual ulong FreeSpace
        {
            get
            {
                return this._freeSpace;
            }
            set
            {
                this._freeSpace = value;
            }
        }

        /// <summary>
        /// Represents the property InstallDate
        /// </summary>
        public virtual System.DateTime InstallDate
        {
            get
            {
                return this._installDate;
            }
            set
            {
                this._installDate = value;
            }
        }

        /// <summary>
        /// Represents the property LastErrorCode
        /// </summary>
        public virtual uint LastErrorCode
        {
            get
            {
                return this._lastErrorCode;
            }
            set
            {
                this._lastErrorCode = value;
            }
        }

        /// <summary>
        /// Represents the property MaximumComponentLength
        /// </summary>
        public virtual uint MaximumComponentLength
        {
            get
            {
                return this._maximumComponentLength;
            }
            set
            {
                this._maximumComponentLength = value;
            }
        }

        /// <summary>
        /// Represents the property MediaType
        /// </summary>
        public virtual uint MediaType
        {
            get
            {
                return this._mediaType;
            }
            set
            {
                this._mediaType = value;
            }
        }

        /// <summary>
        /// Represents the property Name
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// Represents the property NumberOfBlocks
        /// </summary>
        public virtual ulong NumberOfBlocks
        {
            get
            {
                return this._numberOfBlocks;
            }
            set
            {
                this._numberOfBlocks = value;
            }
        }

        /// <summary>
        /// Represents the property PNPDeviceID
        /// </summary>
        public virtual string PNPDeviceID
        {
            get
            {
                return this._pNPDeviceID;
            }
            set
            {
                this._pNPDeviceID = value;
            }
        }

        /// <summary>
        /// Represents the property PowerManagementCapabilities
        /// </summary>
        public virtual ushort[] PowerManagementCapabilities
        {
            get
            {
                return this._powerManagementCapabilities;
            }
            set
            {
                this._powerManagementCapabilities = value;
            }
        }

        /// <summary>
        /// Represents the property PowerManagementSupported
        /// </summary>
        public virtual bool PowerManagementSupported
        {
            get
            {
                return this._powerManagementSupported;
            }
            set
            {
                this._powerManagementSupported = value;
            }
        }

        /// <summary>
        /// Represents the property ProviderName
        /// </summary>
        public virtual string ProviderName
        {
            get
            {
                return this._providerName;
            }
            set
            {
                this._providerName = value;
            }
        }

        /// <summary>
        /// Represents the property Purpose
        /// </summary>
        public virtual string Purpose
        {
            get
            {
                return this._purpose;
            }
            set
            {
                this._purpose = value;
            }
        }

        /// <summary>
        /// Represents the property QuotasDisabled
        /// </summary>
        public virtual bool QuotasDisabled
        {
            get
            {
                return this._quotasDisabled;
            }
            set
            {
                this._quotasDisabled = value;
            }
        }

        /// <summary>
        /// Represents the property QuotasIncomplete
        /// </summary>
        public virtual bool QuotasIncomplete
        {
            get
            {
                return this._quotasIncomplete;
            }
            set
            {
                this._quotasIncomplete = value;
            }
        }

        /// <summary>
        /// Represents the property QuotasRebuilding
        /// </summary>
        public virtual bool QuotasRebuilding
        {
            get
            {
                return this._quotasRebuilding;
            }
            set
            {
                this._quotasRebuilding = value;
            }
        }

        /// <summary>
        /// Represents the property Size
        /// </summary>
        public virtual ulong Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }

        /// <summary>
        /// Represents the property Status
        /// </summary>
        public virtual string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        /// <summary>
        /// Represents the property StatusInfo
        /// </summary>
        public virtual ushort StatusInfo
        {
            get
            {
                return this._statusInfo;
            }
            set
            {
                this._statusInfo = value;
            }
        }

        /// <summary>
        /// Represents the property SupportsDiskQuotas
        /// </summary>
        public virtual bool SupportsDiskQuotas
        {
            get
            {
                return this._supportsDiskQuotas;
            }
            set
            {
                this._supportsDiskQuotas = value;
            }
        }

        /// <summary>
        /// Represents the property SupportsFileBasedCompression
        /// </summary>
        public virtual bool SupportsFileBasedCompression
        {
            get
            {
                return this._supportsFileBasedCompression;
            }
            set
            {
                this._supportsFileBasedCompression = value;
            }
        }

        /// <summary>
        /// Represents the property SystemCreationClassName
        /// </summary>
        public virtual string SystemCreationClassName
        {
            get
            {
                return this._systemCreationClassName;
            }
            set
            {
                this._systemCreationClassName = value;
            }
        }

        /// <summary>
        /// Represents the property SystemName
        /// </summary>
        public virtual string SystemName
        {
            get
            {
                return this._systemName;
            }
            set
            {
                this._systemName = value;
            }
        }

        /// <summary>
        /// Represents the property VolumeDirty
        /// </summary>
        public virtual bool VolumeDirty
        {
            get
            {
                return this._volumeDirty;
            }
            set
            {
                this._volumeDirty = value;
            }
        }

        /// <summary>
        /// Represents the property VolumeName
        /// </summary>
        public virtual string VolumeName
        {
            get
            {
                return this._volumeName;
            }
            set
            {
                this._volumeName = value;
            }
        }

        /// <summary>
        /// Represents the property VolumeSerialNumber
        /// </summary>
        public virtual string VolumeSerialNumber
        {
            get
            {
                return this._volumeSerialNumber;
            }
            set
            {
                this._volumeSerialNumber = value;
            }
        }
    }
}
