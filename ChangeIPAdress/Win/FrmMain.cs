using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeIPAdress.Win
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Language.Equals("es-MX"))            
                spanishStripMenuItem.Checked = true;
            else
                englishStripMenuItem.Checked = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            cmbInterfaces.DataSource = ChangeIPAddressLibrary.Core.IPSetting.GetAllNetworkInterfaces();
            cmbInterfaces.DisplayMember = "Description";
            txtConsole.Text = ChangeIPAddressLibrary.Core.IPSetting.SetIP("192.168.1.200", "255.255.255.0", "192.168.1.254");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rdbSpecifyIp_CheckedChanged(object sender, EventArgs e)
        {
            grpIPAddress.Enabled = !grpIPAddress.Enabled;
        }

        private void TabProfiles_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void TabProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TabProfiles.SelectedTab == tabNew)
            {
                try{
                    txtProfile.SelectionStart = 0;
                    txtProfile.SelectionLength = txtProfile.TextLength;
                    txtProfile.Focus();
                }catch{}
            }
        }

        private void rdbSpecifyDNS_CheckedChanged(object sender, EventArgs e)
        {
            grpDNSServer.Enabled = !grpDNSServer.Enabled;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Radio button on menu...
            spanishStripMenuItem.Checked = (sender == spanishStripMenuItem);
            englishStripMenuItem.Checked = (sender == englishStripMenuItem);
            saveSetting();
        }


        private void saveSetting()
        {
            if (spanishStripMenuItem.Checked)
                Properties.Settings.Default.Language = "es-MX";
            else
                Properties.Settings.Default.Language = "en";
            Properties.Settings.Default.Save();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
