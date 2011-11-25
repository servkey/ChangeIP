using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAddressLibrary.Base
{
    public class Profile
    {
        private int idProfile;
        private string profile;
        private bool dhcpEnabled;
        private string ipAddress;
        private string ipSubnet;
        private string defaultIpGateway;
        private string dnsServerSearchOrder;
        private string macAddress;
        private string settingId;
        private string caption;
        private string serviceName;
        private string description;
        
        public const string FIDPROFILE = "IdProfile";
        public const string FPROFILE = "ProfileName";
        public const string FDHCPENABLED = "DHCPEnabled";
        public const string FIPADDRESS = "IPAddress";
        public const string FIPSUBNET = "IPSubnet";
        public const string FDEFAULTIPGATEWAY = "DefaultIpGateway";
        public const string FDNSSERVERSEARCHORDER = "DNSServerSearchOrder";
        public const string FMACADDRESS = "MACAddress";
        public const string FSETTINGID = "SettingId";
        public const string FCAPTION = "Caption";
        public const string FSERVICENAME = "ServiceName";
        public const string FDESCRIPTION = "Description";

        public const string QPROFILES = "SELECT * FROM TblProfiles";
                
        public int IdProfile
        {
            get { return idProfile; }
            set { idProfile = value; }
        }

        public String ProfileName
        {
            set { profile = value; }
            get { return profile; }
        }

        public String DnsServerSearchOrder
        {
            get { return dnsServerSearchOrder; }
            set { dnsServerSearchOrder = value; }
        }

        public String MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }


        public String SettingId
        {
            get { return settingId; }
            set { settingId = value; }
        }

        public String Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public String ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public String DefaultIpGateway
        {
            get { return defaultIpGateway; }
            set { defaultIpGateway = value; }
        }

        public String IpSubnet
        {
            get { return ipSubnet; }
            set { ipSubnet = value; }
        }

        public String IpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        public bool DhcpEnabled
        {
            get { return dhcpEnabled; }
            set { dhcpEnabled = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
