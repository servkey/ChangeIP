using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChangeIPAdress.Util;
using ChangeIPAddressLibrary.Base;
using ChangeIPAddressLibrary.Core;

namespace ChangeIPAdress.Win
{
    public partial class FrmMain : Form
    {
        private List<ChangeIPAddressLibrary.Base.Profile> profiles;
        private ChangeIPAddressLibrary.Base.Profile profileSelected;
        public FrmMain()
        {
            InitializeComponent();
                
            //Esto cambiara
            if (SettingUtil.GetLanguage().Equals(SettingUtil.GetLanguageEs()))
                tsmLSpanish.Checked = true;
            else
                tsmLEnglish.Checked = true;

            LoadProfiles();
            SettingProfiles();
            LoadInterfaces();
        }
        private void ResetNew()
        {

            
        }

        private void LoadNew()
        {
            //
         
            ControlUtil.Clear(txtGateway, txtDNSServer, txtProfile, txtIPSubnet, txtIPAddress);
            rdbDNSAutomatically.Checked = true;
            rdbIpAutomatically.Checked = true;
            txtProfile.Text = TranslateUtil.GetProfileTxt();
            txtProfile.SelectionStart = 0;
            txtProfile.SelectionLength = txtProfile.Text.Length;
            txtProfile.Focus();
            ///
        }

        private void SettingNew()
        {
            tsbApply.Enabled = false;
            tsbDelete.Enabled = false;
            tsbNew.Enabled = false;
            tsbSave.Enabled = true;

            tsmApply.Enabled = false;
            tsmDelete.Enabled = false;
            tsmSave.Enabled = true;
            tsmNew.Enabled = false;
        }

        private void SettingProfiles()
        {
            tsbSave.Enabled = false;            
            tsbApply.Enabled = true;
            tsbDelete.Enabled = true;
            tsbNew.Enabled = true;

            tsmApply.Enabled = true;
            tsmDelete.Enabled = true;
            tsmSave.Enabled = false;
            tsmNew.Enabled = true;
        }

        private void LoadProfiles(){
            
            lblIPAddress.Text = TranslateUtil.GetSeparator();
            lblDNSServer.Text = TranslateUtil.GetSeparator();
            lblGateway.Text = TranslateUtil.GetSeparator();            

            ChangeIPAddressLibrary.Core.ProfileHelper dbProfiles = new ChangeIPAddressLibrary.Core.ProfileHelper();
            profiles = dbProfiles.GetAll();
            this.lstProfiles.DataSource = profiles;
            this.lstProfiles.DisplayMember = ChangeIPAddressLibrary.Base.Profile.FPROFILE;
            this.lstProfiles.ValueMember = ChangeIPAddressLibrary.Base.Profile.FIDPROFILE;
        }

        private void LoadInterfaces()
        {
            this.cmbInterfaces.DataSource = ChangeIPAddressLibrary.Core.NetworkInterfaceHelper.GetAllNetworkInterfaces();            
            this.cmbInterfaces.DisplayMember = ChangeIPAddressLibrary.Base.Profile.FDESCRIPTION;
            this.cmbInterfaces.ValueMember = ChangeIPAddressLibrary.Base.Profile.FMACADDRESS;
                
            try
            {
                lstProfiles.SelectedIndex = 0;
            }
            catch { }
        }

        private void ReloadLanguage()
        {
            Util.TranslateUtil.Translate(
                this,
                tabConsole,
                tabProfile,
                tabNew,
                lblTGateway,
                grpDNSServer,
                grpDetails,
                grpProfiles,
                rdbDNSAutomatically,
                rdbIpAutomatically,
                rdbSpecifyDNS,
                rdbSpecifyIp,
                grpIPAddress,
                grpProfiles,
                lblTNetworkInterface,
                lblTDNSServer, 
                lblTIPAddress,
                lblTProfile,
                lblTNetworkInterfaceCmb                
            );

            Util.TranslateUtil.Translate(
                tsbDelete,
                tsbNew,
                tsbExit,
                tsbApply,
                tsbSave,
                tsmSave,
                tsmAbout,
                tsmApply,
                tsmDelete,
                tsmExit,
                tsmAbout,
                tsmNew,
                tsmHelp,               
                tsmLEnglish,
                tsmLSpanish,
                tsmPreference,
                tsmProfile,
                tsmLanguage                
             );
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Util.TranslateUtil.InitLanguage();            
            txtConsole.Text = NetworkInterfaceHelper.GetActiveConnection();
            ReloadLanguage();        
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
                LoadNew();
                SettingNew();
            }
            else if (TabProfiles.SelectedTab == tabProfile)
            {
                SettingProfiles();
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
                profileSelected = profiles[Int32.Parse(lstProfiles.SelectedIndex.ToString())];
                lblIPAddress.Text = !profileSelected.IpAddress.Trim().Equals(String.Empty) ? profileSelected.IpAddress : TranslateUtil.GetAutomaticallyTxt();
                lblDNSServer.Text = !profileSelected.DnsServerSearchOrder.Trim().Equals(String.Empty) ? profileSelected.DnsServerSearchOrder : TranslateUtil.GetAutomaticallyTxt();
                lblGateway.Text = !profileSelected.DefaultIpGateway.Trim().Equals(String.Empty) ? profileSelected.DefaultIpGateway : TranslateUtil.GetAutomaticallyTxt();
                if (profileSelected.Description.Length > 25)
                    lblNetworkInterface.Text = profileSelected.Description.Substring(0, 23) + "...";
                else
                    lblNetworkInterface.Text = profileSelected.Description;
            }
            catch {
                //MessageBox.Show(TranslateUtil.GetMsgSelectProfile());
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabProfiles.SelectedIndex == 1)
                {
                    Profile p = new Profile();
                    ProfileHelper pHelper = new ProfileHelper();

                    NetworkInterface ni = NetworkInterfaceHelper.GetByMACNetworkInterface(cmbInterfaces.SelectedValue.ToString());

                    p.Caption = ni.Caption;                    
                    p.Description = ni.Description;
                    p.ProfileName = txtProfile.Text;
                    p.ServiceName = ni.ServiceName;
                    p.SettingId = ni.SettingID;                    
                    p.DhcpEnabled = this.rdbIpAutomatically.Checked;
                    p.MacAddress = ni.MACAddress;
                    if (!p.DhcpEnabled)                    
                    {
                        p.DefaultIpGateway = txtGateway.Text;
                        p.IpSubnet = txtIPSubnet.Text;                      
                        p.IpAddress = txtIPAddress.Text;
                    }
                    
                    if (!rdbDNSAutomatically.Checked)
                        p.DnsServerSearchOrder = txtDNSServer.Text;
                    
                
                    pHelper.Add(p);
                    LoadProfiles();
                    LoadNew();
                    MessageBox.Show(TranslateUtil.GetMsgSavedProfile(), this.Text,MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch {
                MessageBox.Show(TranslateUtil.GetMsgErrorProfile(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (TabProfiles.SelectedIndex == 0)
            {
                try{
                    if (lstProfiles.SelectedValue != null)
                    {
                        ProfileHelper profileHelper = new ProfileHelper();
                        Profile profile = new Profile
                        {
                            IdProfile = Int32.Parse(lstProfiles.SelectedValue.ToString())
                        };
                        DialogResult r = MessageBox.Show(String.Format(TranslateUtil.GetMsgConfirmDelete(), ((Profile)lstProfiles.SelectedItem).ProfileName), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (r == DialogResult.Yes) 
                        {
                            profileHelper.Delete(profile);
                            profileSelected = null;
                            LoadProfiles();
                        }
                    }
                    else
                        MessageBox.Show(TranslateUtil.GetMsgSelectProfile(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                }catch{}
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            TabProfiles.SelectedTab = tabNew;
        }

        private void tsbApply_Click(object sender, EventArgs e)
        {
            if (TabProfiles.SelectedTab == tabProfile)
            {
                try
                {
                    if (lstProfiles.SelectedValue != null)
                    {
                        bool error = false;
                        if (!profileSelected.DhcpEnabled)
                        {
                            if (!(NetworkInterfaceHelper.SetIP(profileSelected.MacAddress, profileSelected.IpAddress, profileSelected.IpSubnet, profileSelected.DefaultIpGateway)))
                            {
                                MessageBox.Show(TranslateUtil.GetMsgErrorNetworkInterface(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = true;
                            }
                        }
                        else
                        {
                            NetworkInterfaceHelper.SetEnabledDHCP(profileSelected.MacAddress);                            
                        }

                        if (!profileSelected.DnsServerSearchOrder.Trim().Equals(String.Empty))
                        {
                            if (!(NetworkInterfaceHelper.SetDNS(profileSelected.MacAddress, profileSelected.DnsServerSearchOrder)))
                            {
                                MessageBox.Show(TranslateUtil.GetMsgErrorDNSNetworkInterface(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = true;
                            }
                        }
                        else
                        {
                            NetworkInterfaceHelper.SetDNSAutomatically(profileSelected.MacAddress);
                        }

                        if (!error)
                        {
                            MessageBox.Show(String.Format(TranslateUtil.GetMsgAppliedProfile(), ((Profile)lstProfiles.SelectedItem).ProfileName), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtConsole.Text = NetworkInterfaceHelper.GetActiveConnection();
                        }

                    }else
                        MessageBox.Show(TranslateUtil.GetMsgSelectProfile(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
                catch{
                    MessageBox.Show(TranslateUtil.GetMsgErrorSetting(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
            
        }
    }
}
