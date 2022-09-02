using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Sockets;
 // TODO / AIM
// Grab the IP addresses of the current pc with the option to enter a different one manually. - DONE
// Set port to use - DONE
// Randomise a few digits of MAC address to prevent duplicates on the network - DONE

namespace KDNet_Payload_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] Template = { 0xCA, 0x4A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x00, 0x01, 
            0x00, 0x00, 0x00, 0x00, 
            0x00, 0x22, 0x48, 0x62, 0xC7, 0xE0, // MAC address only used for debugger connection. Used when requesting an extra IP from the router
            0xC3, 0x51, // Port to use for kdnet connection
            0xC0, 0xA8, 0x01, 0x6F }; // IP address of the pc running windbg (KDNet)

        public string[] Port_strs = { "Select Port:", "50001", "5543"};

        private void SetupPortList()
        {
            try
            {
                for (int i = 0; i < Port_strs.Length; i++)
                    combo_port.Items.Add(Port_strs[i]);

                combo_port.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RandomiseMAC()
        {
            try
            {
                Random rnd = new Random();
                byte[] randbytes = new byte[3];
                rnd.NextBytes(randbytes);
                for (int i = 0; i < randbytes.Length; i++)
                    Template[27 + i] = randbytes[i];

                string MAC_Str = String.Format("{0:x2}-{1:x2}-{2:x2}-{3:x2}-{4:x2}-{5:x2}",
                    Template[24], Template[25], Template[26], Template[27], Template[28], Template[29]);

                lbl_macaddr.Text = "Console Dbg MAC: " + MAC_Str;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetLocalIPAddress()
        {
            try
            {
                combo_ipaddr.Items.Clear();
                combo_ipaddr.Items.Add("Select IP address:");
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        combo_ipaddr.Items.Add(ip.ToString());

                combo_ipaddr.SelectedIndex = 0;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowHelpInfoBox(int type)
        {
            string TitleText, InfoText;
            switch (type)
            {
                case 0: // IP
                    TitleText = "IP Address Info";
                    InfoText = "This is the IP address of the pc running windbg/kdnet that the debug console will connect to.";
                    break;
                case 1: // Port
                    TitleText = "Port Info";
                    InfoText = "This is the port number windbg/kdnet has been set to listen on for incoming connection. This should match the port number set in the bat file used to open kdnet.";
                    break;
                case 2: // MAC
                    TitleText = "MAC Address Info";
                    InfoText = "This is the MAC address that will be used to request a a 3rd IP to use for kernel debugging. This is seperate from the other 2 IP addresses used for XBDM connections & game/app titles.\n\nThis is randomly generated to ensure there's no duplicate conflicting addresses on the same network.";
                    break;
                case 3: // Create binary file
                    TitleText = "Create Binary Info";
                    InfoText = "This creates the final binary file to be written directly into a nand image at offset 0x80. This enables kernel debugging and points the console to the IP & port specified.\n\nWARNING: The data entered is in no way validated. It is on the user to ensure only valid IP and port strings are entered.";
                    break;
                case 4: // Create bat file
                    TitleText = "Create Bat File Info";
                    InfoText = "This creates a bat file that will setup and open windbg/kdnet on the specified listening port.";
                    break;
                case 5: // Port too low
                    TitleText = "Error - Port Too Low";
                    InfoText = "The port entered is either invalid or too low.\n\nPlease enter a port in the range 1024 - 65335.";
                    break;
                default: // Unknown
                    TitleText = "Error";
                    InfoText = "Something appears to have gone wrong!";
                    break;
            }

            MessageBox.Show(InfoText, TitleText, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Set_Template_Bytes()
        {
            string ipAddress;
            if (chkbox_manual_ip.Checked)
                ipAddress = tbox_ipaddr.Text;
            else
                ipAddress = combo_ipaddr.Text;
            IPAddress address = IPAddress.Parse(ipAddress);
            byte[] ipbytes = address.GetAddressBytes();
            for (int i = 0; i < ipbytes.Length; i++)
            {
                Template[32 + i] = ipbytes[i];
            }

            // Set port bytes
            int port_int;
            if (chkbox_custom_port.Checked)
                port_int = (int)numud_port.Value;
            else if (combo_port.SelectedIndex == 0)
                port_int = 0;
            else
                port_int = Convert.ToInt32(combo_port.Text);

            if (port_int < 1024)
            {

                ShowHelpInfoBox(5);
                return;
            }
            byte[] buffer = BitConverter.GetBytes(port_int); // result is little endian so switch the bytes around
            Template[30] = buffer[1];
            Template[31] = buffer[0];
        }

        private void CreateBinFile()
        {
            lbl_status.Text = "Status: processing...";
            try
            {
                Set_Template_Bytes();
                if (!Directory.Exists("PatchFile"))
                    Directory.CreateDirectory("PatchFile");

                File.WriteAllBytes("PatchFile/KDNetInfo.bin", Template);
                lbl_status.Text = "Status: Success!";
            }
            catch (Exception exc)
            {
                lbl_status.Text = "Status: Failed!";
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void CreateBatFile()
        {
            lbl_status.Text = "Status: processing...";
            try
            {
                if (!chkbox_custom_port.Checked && (combo_port.SelectedIndex <= 0))
                {
                    lbl_status.Text = "Status: Failed!";
                    MessageBox.Show("Please enter a valid port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Skip if port isn't valid
                }
                string Portstr = chkbox_custom_port.Checked ? numud_port.Value.ToString() : combo_port.Text;
                string BatText = String.Format("rem @ECHO OFF\n\nIF EXIST \"C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\windbg.exe\" (\nstart \"kdebug\" \"C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\windbg.exe\" -k net:port={0}\n)\n\nIF EXIST \"C:\\Program Files\\Microsoft Xbox 360 SDK\\bin\\win32\\windbg.exe\" (\nstart \"kdebug\" C:\\Program Files\\Microsoft Xbox 360 SDK\\bin\\win32\\windbg.exe -k net:port={0}\n)", Portstr);

                string FileName = String.Format("Start-KDNet-{0}.bat", Portstr);
                File.WriteAllTextAsync(FileName, BatText);
                lbl_status.Text = "Status: Success!";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_status.Text = "Status: Failed!";
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            GetLocalIPAddress();
            SetupPortList();
            RandomiseMAC();
        }

        private void IP_EditOptions_TextChanged(object sender, EventArgs e)
        {
            lbl_status.Text = "Status:";
            if (chkbox_manual_ip.Checked)
                lbl_IP.Text = "Debug PC IP: " + tbox_ipaddr.Text;
            else
                lbl_IP.Text = (combo_ipaddr.SelectedIndex <= 0) ? "Debug PC IP: Not set" : "Debug PC IP: " + combo_ipaddr.Text;
        }

        private void Port_EditOptions_TextChanged(object sender, EventArgs e)
        {
            lbl_status.Text = "Status:";
            if (chkbox_custom_port.Checked)
                lbl_port.Text = "Port: " + numud_port.Value.ToString();
            else
                lbl_port.Text = (combo_port.SelectedIndex <= 0)  ? "Port: Not set" : "Port: " + combo_port.Text;
        }

        private void btn_grab_ips_Click(object sender, EventArgs e)
        {
            GetLocalIPAddress();
        }

        private void cbox_manual_ip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_manual_ip.Checked)
                lbl_IP.Text = "Debug PC IP: " + tbox_ipaddr.Text;
            else
                lbl_IP.Text = (combo_ipaddr.SelectedIndex <= 0) ? "Debug PC IP: Not set" : "Debug PC IP: " + combo_ipaddr.Text;

            btn_grab_ips.Enabled = !btn_grab_ips.Enabled;
            combo_ipaddr.Enabled = !combo_ipaddr.Enabled;
            tbox_ipaddr.Enabled = !tbox_ipaddr.Enabled;
        }

        private void chkbox_custom_port_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_custom_port.Checked)
                lbl_port.Text = "Port: " + numud_port.Value.ToString();
            else
                lbl_port.Text = (combo_port.SelectedIndex <= 0) ? "Port: Not set" : "Port: " + combo_port.Text;
            
            numud_port.Enabled = !numud_port.Enabled;
            combo_port.Enabled = !combo_port.Enabled;
        }

        private void btn_regenmac_Click(object sender, EventArgs e)
        {
            RandomiseMAC();
        }

        private void btn_help_ip_Click(object sender, EventArgs e)
        {
            ShowHelpInfoBox(0);
        }

        private void btn_help_port_Click(object sender, EventArgs e)
        {
            ShowHelpInfoBox(1);
        }

        private void btn_help_mac_Click(object sender, EventArgs e)
        {
            ShowHelpInfoBox(2);
        }

        private void btn_help_create_bin_Click(object sender, EventArgs e)
        {
            ShowHelpInfoBox(3);
        }

        private void btn_help_create_bat_Click(object sender, EventArgs e)
        {
            ShowHelpInfoBox(4);
        }

        private void btn_create_binary_Click(object sender, EventArgs e)
        {
            CreateBinFile();
        }

        private void btn_create_bat_Click(object sender, EventArgs e)
        {
            CreateBatFile();
        }
    }
}
