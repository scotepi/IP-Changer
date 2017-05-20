using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace IP_Changer
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            UpdateNICList();

        }

        public void UpdateNICList()
        {


            var nicList = new List<NICs>();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                nicList.Add(
                    new NICs()
                    {
                        Name = adapter.Name+" - "+adapter.OperationalStatus,
                        Value = adapter.Id,
                    }
                );
            }


            listNic.Items.Clear();
            listNic.DataSource = nicList;
            listNic.DisplayMember = "Name";
            listNic.ValueMember = "Value";
        }

        public class NICs
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void PopulateForm(object sender, EventArgs e)
        {
            string nicId = listNic.SelectedValue.ToString();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Id.ToString() == nicId)
                {
                    IPInterfaceProperties ip = adapter.GetIPProperties();

                    if (ip.GatewayAddresses.Count > 0)
                        inputGateway.Text = ip.GatewayAddresses[0].Address.ToString();
                    else
                        inputGateway.Text = "";

                    if (ip.DnsAddresses.Count > 0)
                        inputDNS1.Text = ip.DnsAddresses[0].ToString();
                    else
                        inputDNS1.Text = "";

                    if (ip.DnsAddresses.Count > 1)
                        inputDNS2.Text = ip.DnsAddresses[1].ToString();
                    else
                        inputDNS2.Text = "";


                    foreach (UnicastIPAddressInformation ipUni in ip.UnicastAddresses)
                    {
                        if (ipUni.Address.AddressFamily.ToString() == "InterNetwork")
                        {

                            inputIP.Text = ipUni.Address.ToString();

                            try
                            {
                                inputNetmask.Text = ipUni.IPv4Mask.ToString();
                            } catch
                            {
                                inputNetmask.Text = "";
                            }
                                

                            break;
                        } else
                        {
                            inputIP.Text = "";
                            inputNetmask.Text = "";
                        }
                    }

                    try
                    {
                        IPv4InterfaceProperties ipv4 = ip.GetIPv4Properties();

                        if (ipv4.IsDhcpEnabled.ToString() == "True")
                            checkboxDHCPIP.Checked = true;
                        else
                            checkboxDHCPIP.Checked = false;
                    }
                    catch
                    {
                        checkboxDHCPIP.Checked = false;
                    }
                    
                }
            }
        }
    }
}
