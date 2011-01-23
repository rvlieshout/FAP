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
    public class Win32_Processor
    {

        private ushort _addressWidth;

        private ushort _architecture;

        private ushort _availability;

        private string _caption;

        private uint _configManagerErrorCode;

        private bool _configManagerUserConfig;

        private ushort _cpuStatus;

        private string _creationClassName;

        private uint _currentClockSpeed;

        private ushort _currentVoltage;

        private ushort _dataWidth;

        private string _description;

        private string _deviceID;

        private bool _errorCleared;

        private string _errorDescription;

        private uint _extClock;

        private ushort _family;

        private System.DateTime _installDate;

        private uint _l2CacheSize;

        private uint _l2CacheSpeed;

        private uint _l3CacheSize;

        private uint _l3CacheSpeed;

        private uint _lastErrorCode;

        private ushort _level;

        private ushort _loadPercentage;

        private string _manufacturer;

        private uint _maxClockSpeed;

        private string _name;

        private uint _numberOfCores;

        private uint _numberOfLogicalProcessors;

        private string _otherFamilyDescription;

        private string _pNPDeviceID;

        private ushort[] _powerManagementCapabilities;

        private bool _powerManagementSupported;

        private string _processorId;

        private ushort _processorType;

        private ushort _revision;

        private string _role;

        private string _socketDesignation;

        private string _status;

        private ushort _statusInfo;

        private string _stepping;

        private string _systemCreationClassName;

        private string _systemName;

        private string _uniqueId;

        private ushort _upgradeMethod;

        private string _version;

        private uint _voltageCaps;

        /// <summary>
        /// Represents the property AddressWidth
        /// </summary>
        public virtual ushort AddressWidth
        {
            get
            {
                return this._addressWidth;
            }
            set
            {
                this._addressWidth = value;
            }
        }

        /// <summary>
        /// Represents the property Architecture
        /// </summary>
        public virtual ushort Architecture
        {
            get
            {
                return this._architecture;
            }
            set
            {
                this._architecture = value;
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
        /// Represents the property CpuStatus
        /// </summary>
        public virtual ushort CpuStatus
        {
            get
            {
                return this._cpuStatus;
            }
            set
            {
                this._cpuStatus = value;
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
        /// Represents the property CurrentClockSpeed
        /// </summary>
        public virtual uint CurrentClockSpeed
        {
            get
            {
                return this._currentClockSpeed;
            }
            set
            {
                this._currentClockSpeed = value;
            }
        }

        /// <summary>
        /// Represents the property CurrentVoltage
        /// </summary>
        public virtual ushort CurrentVoltage
        {
            get
            {
                return this._currentVoltage;
            }
            set
            {
                this._currentVoltage = value;
            }
        }

        /// <summary>
        /// Represents the property DataWidth
        /// </summary>
        public virtual ushort DataWidth
        {
            get
            {
                return this._dataWidth;
            }
            set
            {
                this._dataWidth = value;
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
        /// Represents the property ExtClock
        /// </summary>
        public virtual uint ExtClock
        {
            get
            {
                return this._extClock;
            }
            set
            {
                this._extClock = value;
            }
        }

        /// <summary>
        /// Represents the property Family
        /// </summary>
        public virtual ushort Family
        {
            get
            {
                return this._family;
            }
            set
            {
                this._family = value;
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
        /// Represents the property L2CacheSize
        /// </summary>
        public virtual uint L2CacheSize
        {
            get
            {
                return this._l2CacheSize;
            }
            set
            {
                this._l2CacheSize = value;
            }
        }

        /// <summary>
        /// Represents the property L2CacheSpeed
        /// </summary>
        public virtual uint L2CacheSpeed
        {
            get
            {
                return this._l2CacheSpeed;
            }
            set
            {
                this._l2CacheSpeed = value;
            }
        }

        /// <summary>
        /// Represents the property L3CacheSize
        /// </summary>
        public virtual uint L3CacheSize
        {
            get
            {
                return this._l3CacheSize;
            }
            set
            {
                this._l3CacheSize = value;
            }
        }

        /// <summary>
        /// Represents the property L3CacheSpeed
        /// </summary>
        public virtual uint L3CacheSpeed
        {
            get
            {
                return this._l3CacheSpeed;
            }
            set
            {
                this._l3CacheSpeed = value;
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
        /// Represents the property Level
        /// </summary>
        public virtual ushort Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }

        /// <summary>
        /// Represents the property LoadPercentage
        /// </summary>
        public virtual ushort LoadPercentage
        {
            get
            {
                return this._loadPercentage;
            }
            set
            {
                this._loadPercentage = value;
            }
        }

        /// <summary>
        /// Represents the property Manufacturer
        /// </summary>
        public virtual string Manufacturer
        {
            get
            {
                return this._manufacturer;
            }
            set
            {
                this._manufacturer = value;
            }
        }

        /// <summary>
        /// Represents the property MaxClockSpeed
        /// </summary>
        public virtual uint MaxClockSpeed
        {
            get
            {
                return this._maxClockSpeed;
            }
            set
            {
                this._maxClockSpeed = value;
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
        /// Represents the property NumberOfCores
        /// </summary>
        public virtual uint NumberOfCores
        {
            get
            {
                return this._numberOfCores;
            }
            set
            {
                this._numberOfCores = value;
            }
        }

        /// <summary>
        /// Represents the property NumberOfLogicalProcessors
        /// </summary>
        public virtual uint NumberOfLogicalProcessors
        {
            get
            {
                return this._numberOfLogicalProcessors;
            }
            set
            {
                this._numberOfLogicalProcessors = value;
            }
        }

        /// <summary>
        /// Represents the property OtherFamilyDescription
        /// </summary>
        public virtual string OtherFamilyDescription
        {
            get
            {
                return this._otherFamilyDescription;
            }
            set
            {
                this._otherFamilyDescription = value;
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
        /// Represents the property ProcessorId
        /// </summary>
        public virtual string ProcessorId
        {
            get
            {
                return this._processorId;
            }
            set
            {
                this._processorId = value;
            }
        }

        /// <summary>
        /// Represents the property ProcessorType
        /// </summary>
        public virtual ushort ProcessorType
        {
            get
            {
                return this._processorType;
            }
            set
            {
                this._processorType = value;
            }
        }

        /// <summary>
        /// Represents the property Revision
        /// </summary>
        public virtual ushort Revision
        {
            get
            {
                return this._revision;
            }
            set
            {
                this._revision = value;
            }
        }

        /// <summary>
        /// Represents the property Role
        /// </summary>
        public virtual string Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
            }
        }

        /// <summary>
        /// Represents the property SocketDesignation
        /// </summary>
        public virtual string SocketDesignation
        {
            get
            {
                return this._socketDesignation;
            }
            set
            {
                this._socketDesignation = value;
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
        /// Represents the property Stepping
        /// </summary>
        public virtual string Stepping
        {
            get
            {
                return this._stepping;
            }
            set
            {
                this._stepping = value;
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
        /// Represents the property UniqueId
        /// </summary>
        public virtual string UniqueId
        {
            get
            {
                return this._uniqueId;
            }
            set
            {
                this._uniqueId = value;
            }
        }

        /// <summary>
        /// Represents the property UpgradeMethod
        /// </summary>
        public virtual ushort UpgradeMethod
        {
            get
            {
                return this._upgradeMethod;
            }
            set
            {
                this._upgradeMethod = value;
            }
        }

        /// <summary>
        /// Represents the property Version
        /// </summary>
        public virtual string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        /// <summary>
        /// Represents the property VoltageCaps
        /// </summary>
        public virtual uint VoltageCaps
        {
            get
            {
                return this._voltageCaps;
            }
            set
            {
                this._voltageCaps = value;
            }
        }
    }
}