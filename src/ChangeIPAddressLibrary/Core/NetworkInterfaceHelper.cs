using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
namespace ChangeIPAddressLibrary.Core
{
    public class NetworkInterfaceHelper
    {
        /*private void frmMain_Load(object sender, EventArgs e)
        {
            SetIP("192.168.2.2", "255.255.255.0", "192.168.2.1");
            //txtDatos.Text = "Setting ip's";
        }*/

        public static string GetActiveConnection()
        {
            string result = "";
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>())//.Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        try
                        {
                            string val = managementObject.GetPropertyValue("Caption").ToString();
                            string result0 = "**************************************************************";
                            result0 += "\nCaption: " + val;
                            val = managementObject.GetPropertyValue("ServiceName").ToString();
                            result0 += "\nService Name: " + val;

                         
                            
                            val = managementObject.GetPropertyValue("SettingID").ToString();
                            result0 += "\nSettingId: " + val;
                            val = managementObject.GetPropertyValue("Description").ToString();
                            result0 += "\nDescription: " + val;
                            string[] ips = ((string[])managementObject.GetPropertyValue("IPAddress"));
                            string ip = ips[0].ToString();
                            val = ip;
                            result0 += "\nIPAddress: " + val;

                            try
                            {
                                string[] gateway = ((string[])managementObject.GetPropertyValue("DefaultIPGateway"));
                                result0 += "\nIP Gateway: " + gateway[0];
                            }
                            catch { }

                            try
                            {
                                string[] dns = ((string[])managementObject.GetPropertyValue("DNSServerSearchOrder"));
                                result0 += "\nDNS Server: " + dns[0];
                            }
                            catch { }

                            val = managementObject.GetPropertyValue("MACAddress").ToString();
                            result0 += "\nMACAddress: " + val;
                            result0 += "\n";
                            result0 += "**************************************************************\n";
                            result += result0;
                        }
                        catch { }
                    }
                    return result;
                }
            }
        }

        public static void SetEnabledDHCP(string macAddress)
        {            
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {

                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                        if (managementObject.GetPropertyValue("MACAddress").ToString().Equals(macAddress))
                        {
                            managementObject.InvokeMethod("EnableDHCP", null);
                            managementObject.InvokeMethod("RenewDHCPLease", null);                            
                        }
                }
            }           
        }

        public static bool SetIP(string macAddress, string ipAddress, string subnetMask, string gateway)
        {
            bool result = false;
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {

                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"] && managementObject["MACAddress"].Equals(macAddress)))
                    {
                        using (var newIP = managementObject.GetMethodParameters("EnableStatic"))
                        { 
                            // Set new IP address and subnet if needed
                            if (managementObject.GetPropertyValue("MACAddress").ToString().Equals(macAddress))
                            {
                                if (!String.IsNullOrEmpty(ipAddress))
                                {
                                    newIP["IPAddress"] = new[] { ipAddress };
                                }

                                if (!String.IsNullOrEmpty(subnetMask))
                                {
                                    newIP["SubnetMask"] = new[] { subnetMask };
                                }

                                managementObject.InvokeMethod("EnableStatic", newIP, null);
                                // Set mew gateway if needed
                                if (!String.IsNullOrEmpty(gateway))
                                {
                                    using (var newGateway = managementObject.GetMethodParameters("SetGateways"))
                                    {
                                        newGateway["DefaultIPGateway"] = new[] { gateway };
                                        newGateway["GatewayCostMetric"] = new[] { 1 };
                                        managementObject.InvokeMethod("SetGateways", newGateway, null);
                                    }
                                }
                                result = true;
                            }                            
                        }
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Set's the DNS Server of the local machine
        /// </summary>
        /// <param name="nic">NIC address</param>
        /// <param name="dnsServers">Comma seperated list of DNS server addresses</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static bool SetDNSAutomatically(string macAddress)
        {
            bool result = false;
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(objMO => (bool)objMO["IPEnabled"] && objMO["MACAddress"].Equals(macAddress)))
                    {
                        using (var newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                        {
                            //newDNS["DNSServerSearchOrder"] = "0.0.0.0".Split(','); 
                            newDNS["DNSServerSearchOrder"] = null;
                            managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                            //  newDNS.InvokeMethod("SetDNSServerSearchOrder", null, null);

                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Set's the DNS Server of the local machine
        /// </summary>
        /// <param name="nic">NIC address</param>
        /// <param name="dnsServers">Comma seperated list of DNS server addresses</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public static bool SetDNS(string macAddress, string dnsServers)
        {
            bool result = false;
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(objMO => (bool)objMO["IPEnabled"] && objMO["MACAddress"].Equals(macAddress)))
                    {
                        using (var newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                        {
                            newDNS["DNSServerSearchOrder"] = dnsServers.Split(',');
                            managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Get All Network Interfaces.
        /// </summary>
        /// <returns></returns>
        public static List<Base.NetworkInterface> GetAllNetworkInterfaces()
        {
            List<Base.NetworkInterface> networks = new List<Base.NetworkInterface>();
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>())//.Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        try
                        {
                            Base.NetworkInterface network = new Base.NetworkInterface();
                            network.Caption = managementObject.GetPropertyValue("Caption").ToString();                            
                            network.ServiceName = managementObject.GetPropertyValue("ServiceName").ToString();
                            network.SettingID = managementObject.GetPropertyValue("SettingID").ToString();
                            network.Description = managementObject.GetPropertyValue("Description").ToString();
                            //network.IPAddress = managementObject.GetPropertyValue("IPAddress").ToString();
                            network.MACAddress = managementObject.GetPropertyValue("MACAddress").ToString();
                            networks.Add(network);
                        }
                        catch { }
                    }
                } 
            }
            return networks;
        }

        /// <summary>
        /// Get Network Interface by MACAddress.
        /// </summary>
        /// <returns></returns>
        public static Base.NetworkInterface GetByMACNetworkInterface(string mac)
        {
            Base.NetworkInterface network = null;
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>())//.Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        try
                        {
                            string macTmp = managementObject.GetPropertyValue("MACAddress").ToString().Trim();
                            if (macTmp.Equals(mac.Trim()))
                            {
                                Base.NetworkInterface tmp = new Base.NetworkInterface();
                                tmp.Caption = managementObject.GetPropertyValue("Caption").ToString();
                                tmp.ServiceName = managementObject.GetPropertyValue("ServiceName").ToString();
                                tmp.SettingID = managementObject.GetPropertyValue("SettingID").ToString();
                                tmp.Description = managementObject.GetPropertyValue("Description").ToString();
                                //network.IPAddress = managementObject.GetPropertyValue("IPAddress").ToString();
                                tmp.MACAddress = macTmp;
                                network = tmp;
                            }
                        }
                        catch {                            
                        }
                    }
                }
            }
            return network;
        }
    }
}
