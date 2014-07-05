using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAddressLibrary.Base
{
    /// <summary>
    /// Class for Netowork Interface
    /// </summary>
    public class NetworkInterface    
    {
        private String caption;
        private String serviceName;
        private String settingID;
        private String description;
        private String macAddress;
        private String ipAddress;

        public String Caption {
            set { caption = value; }
            get { return caption; }
        }

        public String ServiceName
        {
            set { serviceName = value; }
            get { return serviceName; }
        }

        public String SettingID
        {
            set { settingID = value; }
            get { return settingID; }
        }

        public String Description
        {
            set { description = value; }
            get { return description; }
        }

        public String MACAddress
        {
            set { macAddress = value; }
            get { return macAddress; }
        }

        public String IPAddress
        {
            set { ipAddress = value; }
            get { return ipAddress; }
        }
    }
}
