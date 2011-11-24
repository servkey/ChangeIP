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
        public FrmMain()
        {
            InitializeComponent();

            ChangeIPAddressLibrary.Core.DBLiteConnection db = new ChangeIPAddressLibrary.Core.DBLiteConnection(SettingUtil.GetConection());
            db.ExecuteQuery("SELECT * FROM TblProfiles");
            //Esto cambiara
            if (SettingUtil.GetLanguage().Equals(SettingUtil.GetLanguageEs()))
                tsmLSpanish.Checked = true;
            else
                tsmLEnglish.Checked = true;
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
            cmbInterfaces.DataSource = ChangeIPAddressLibrary.Core.IPSetting.GetAllNetworkInterfaces();
            cmbInterfaces.DisplayMember = "Description";
            txtConsole.Text = ChangeIPAddressLibrary.Core.IPSetting.SetIP("192.168.1.200", "255.255.255.0", "192.168.1.254");
        }
        
        private void SaveSetting()
        {
            if (tsmLSpanish.Checked)
                SettingUtil.SaveSettingEs();
            
            else
                SettingUtil.SaveSettingEn();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

    }
}
