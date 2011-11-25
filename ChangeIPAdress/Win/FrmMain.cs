using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChangeIPAdress.Util;

namespace ChangeIPAdress.Win
{
    public partial class FrmMain : Form
    {
        private List<ChangeIPAddressLibrary.Base.Profile> profiles;
        public FrmMain()
        {
            InitializeComponent();

          
            
            //Esto cambiara
            if (SettingUtil.GetLanguage().Equals(SettingUtil.GetLanguageEs()))
                tsmLSpanish.Checked = true;
            else
                tsmLEnglish.Checked = true;

            LoadProfiles();
        }

        private void LoadProfiles(){
            ChangeIPAddressLibrary.Core.ProfileHelper dbProfiles = new ChangeIPAddressLibrary.Core.ProfileHelper();
            profiles = dbProfiles.GetAll();
            this.lstProfiles.DataSource = profiles;
            this.lstProfiles.DisplayMember = ChangeIPAddressLibrary.Base.Profile.FPROFILE;
            this.lstProfiles.ValueMember = ChangeIPAddressLibrary.Base.Profile.FIDPROFILE;
            cmbInterfaces.DataSource = ChangeIPAddressLibrary.Core.IPSetting.GetAllNetworkInterfaces();
            try
            {
                lstProfiles.SelectedIndex = 0;
            }
            catch { }
        }

        private void ReloadLanguage()
        {
            Util.TranslateUtil.Translate(lblTDNSServer, lblTIPAddress, lblTProfile, lblTNetworkInterfaceCmb);    
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Cargar configuración para lenguaje
            Util.TranslateUtil.InitLanguage();
            ReloadLanguage();

            cmbInterfaces.DisplayMember = ChangeIPAddressLibrary.Base.Profile.FDESCRIPTION;
            txtConsole.Text = ChangeIPAddressLibrary.Core.IPSetting.SetIP("192.168.1.200", "255.255.255.0", "192.168.1.254");
        }
        
        private void SaveSetting()
        {
            if (tsmLSpanish.Checked)
                SettingUtil.SaveSettingEs();
            
            else
                SettingUtil.SaveSettingEn();
        }

       

       
        private void tsmEnglish_Click(object sender, EventArgs e)
        {
            //Test Radio button on menu...
            tsmLSpanish.Checked = (sender == tsmLSpanish);
            tsmLEnglish.Checked = (sender == tsmLEnglish);
            SaveSetting();
            TranslateUtil.InitLanguage();
            ReloadLanguage();
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
              
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TabProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabProfiles.SelectedTab == tabNew)
            {
                txtProfile.SelectionStart = 0;                
                txtProfile.SelectionLength = txtProfile.Text.Length;
                txtProfile.Focus();

            }
        }

        private void rdbSpecifyIp_CheckedChanged(object sender, EventArgs e)
        {
            grpIPAddress.Enabled = rdbSpecifyIp.Checked;
        }

        private void rdbSpecifyDNS_CheckedChanged(object sender, EventArgs e)
        {
            grpDNSServer.Enabled = rdbSpecifyDNS.Checked;
        }

        private void lstProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeIPAddressLibrary.Base.Profile p = profiles[Int32.Parse(lstProfiles.SelectedIndex.ToString())];
                lblIPAddress.Text = p.IpAddress;
                lblDNSServer.Text = p.DnsServerSearchOrder;
                lblGateway.Text = p.DefaultIpGateway;
                if (p.Description.Length > 25)
                    lblNetworkInterface.Text = p.Description.Substring(0, 23) + "...";
                else
                    lblNetworkInterface.Text = p.Description;
            }
            catch {
                MessageBox.Show("Error testing...!");
            }
        }

        

    }
}
