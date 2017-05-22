using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;

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
                        Value = adapter.GetPhysicalAddress().ToString(),
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
            string macAddress = listNic.SelectedValue.ToString();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.GetPhysicalAddress().ToString() == macAddress)
                {
                    IPInterfaceProperties ip = adapter.GetIPProperties();

                    if (adapter.GetPhysicalAddress() != null)
                        inputMACAddress.Text = adapter.GetPhysicalAddress().ToString();

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

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                if (ApplyChanges())
                {
                    MessageBox.Show("IP Settings Applied!", "Congradulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    DialogResult result = MessageBox.Show("There was an unkown error applying the changes.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Retry)
                    {
                        buttonApply_Click(sender, e);
                    }
                }

            } else
            {
                // Invalid inputs
            }
        }

        private bool CheckInputs()
        {

            List<string> errors = new List<string>();

            if (!checkboxDHCPIP.Checked)
            {
                // Required inputs
                if (System.String.IsNullOrWhiteSpace(inputIP.Text)) errors.Add("No IP Specified");
                if (System.String.IsNullOrWhiteSpace(inputNetmask.Text)) errors.Add("No Netmask Specified");

                // Verify data
                if (!System.String.IsNullOrWhiteSpace(inputIP.Text) && !IPChanger.CheckIPAddressV4(inputIP.Text))
                    errors.Add("Invalid IP Address");

                if (!System.String.IsNullOrWhiteSpace(inputNetmask.Text) && !IPChanger.CheckIPAddressV4(inputNetmask.Text))
                    errors.Add("Invalid Netmask");

                if (!System.String.IsNullOrWhiteSpace(inputGateway.Text) && !IPChanger.CheckIPAddressV4(inputGateway.Text))
                    errors.Add("Invalid Gateway");

                if (!System.String.IsNullOrWhiteSpace(inputDNS1.Text) && !IPChanger.CheckIPAddressV4(inputDNS1.Text))
                    errors.Add("Invalid DNS1");

                if (!System.String.IsNullOrWhiteSpace(inputDNS2.Text) && !IPChanger.CheckIPAddressV4(inputDNS2.Text))
                    errors.Add("Invalid DNS2");

                if (errors.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("There was an error with your IP settings:\n - " + String.Join("\n - ", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            } else
            {
                return true;
            }
            
        }

        private bool ApplyChanges()
        {


            


            return false;

        }

        
    }
}
