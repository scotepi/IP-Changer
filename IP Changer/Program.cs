using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;

namespace IP_Changer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
        }
    }

    class IPChanger
    {
        private void Main(string macAddress)
        {
            this.nic = GetManagementObject(macAddress);
        }

        static ManagementObject GetManagementObject(string macAddress)
        {

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {

                if ((bool)objMO.GetPropertyValue("IPEnabled") &&
                    objMO.GetPropertyValue("MACAddress") != null &&
                    PlainMAC(objMO.GetPropertyValue("MACAddress").ToString()) == macAddress)
                {
                    return objMO;
                }
            }


            // Return null if nothing was found
            return null;
        }

        private bool SetIP(string ipAddress, string netmask)
        {

            if (nic != null)
            {
                try
                {
                    ManagementBaseObject newIP =
                        nic.GetMethodParameters("EnableStatic");

                    newIP["IPAddress"] = new string[] { ipAddress };
                    newIP["SubnetMask"] = new string[] { netmask };

                    ManagementBaseObject setIP = nic.InvokeMethod("EnableStatic", newIP, null);

                    return true;
                }
                catch 
                {
                    return false;
                }
            }

            return false;
        }

        private bool SetGateway(string gatewayAddress)
        {

            if (nic != null)
            {
                try
                {
                    ManagementBaseObject newGateway =
                        nic.GetMethodParameters("SetGateways");

                    newGateway["DefaultIPGateway"] = new string[] { gatewayAddress };
                    newGateway["GatewayCostMetric"] = new int[] { 1 };

                    ManagementBaseObject setGateway = nic.InvokeMethod("SetGateways", newGateway, null);

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        private bool SetDNS(string dns1, string dns2)
        {

            if (nic != null)
            {
                try
                {
                    ManagementBaseObject newDNS =
                        nic.GetMethodParameters("SetDNSServerSearchOrder");

                    // We only have 1 DNS
                    if (String.IsNullOrEmpty(dns2))
                    {
                        newDNS["DNSServerSearchOrder"] = new string[] { dns1 };
                    } else
                    {
                        newDNS["DNSServerSearchOrder"] = new string[] { dns1, dns2 };
                    }
                    
                    ManagementBaseObject setDNS = nic.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                    // SetDNSDomain

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }


        private bool SetDHCP()
        {

            if (nic != null)
            {
                try
                {
                    ManagementBaseObject setDHCP = nic.InvokeMethod("EnableDHCP", null, null);

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }




        public static string PlainMAC(string macAddress)
        {
            return macAddress.ToUpper().Replace(".", "").Replace(":", "").Replace("-", "");
        }

        public static bool CheckIPAddressV4(string ipString)
        {
            // Nothing was passed
            if (String.IsNullOrWhiteSpace(ipString))
                return false;

            // We have 4 octets
            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
                return false;

            // Check each octet
            foreach (String octetString in splitValues)
            {

                int octet;

                // Convert it to a int16 or return false
                try
                {
                    octet = Int16.Parse(octetString);
                }
                catch
                {
                    return false;
                }


                // Make sure the octet is between 0 and 255
                if (0 <= octet && octet <= 255)
                {
                    // Within Range
                }
                else
                {
                    return false;
                }
            }

            // We made it to the end!
            return true;
        }

        private ManagementObject nic;
    }
}
