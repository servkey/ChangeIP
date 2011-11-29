using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Windows.Forms;

namespace ChangeIPAdress.Util
{
    class TranslateUtil
    {
        private static ResourceManager resourceManager = new ResourceManager("ChangeIPAdress.Resources.ChangeIPWin", typeof(Win.FrmMain).Assembly);
         //Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
         
        
        public static void InitLanguage(){
            if (Properties.Settings.Default.Language.Equals("es-MX"))
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            else
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
           //  MessageBox.Show(LocRM.GetString("FrmMainTxt"));

        }

        private static string Get(string name)
        {
            return resourceManager.GetString(name);
        }
                
        
        public static string GetMsgAppliedProfile()
        {
            return Get("msgAppliedProfile");
        }

        public static string GetMsgConfirmDelete()
        {
            return Get("msgConfirmDelete");
        }

        public static string GetMsgSelectProfile()
        {
            return Get("msgSelectProfile");
        }
        

        public static string GetMsgErrorSetting()
        {
            return Get("msgErrorSetting");
        }

        public static string GetMsgSavedProfile()
        {
            return Get("msgSaved");
        }

        public static string GetMsgErrorProfile()
        {
            return Get("msgErrorSaving");
        }
        
        public static string GetMsgErrorNetworkInterface()
        {
            return Get("msgErrorNetworkInterface");
        }

         public static string GetMsgErrorDNSNetworkInterface()
        {
            return Get("msgErrorDNSNetworkInterface");
        }
        
        

        public static string GetProfileTxt()
        {
            return Get("txtProfileTxt");
        }

        public static string GetAutomaticallyTxt()
        {
            return Get("lblAutomaticallyTxt");
        }

        public static void Translate(params Control[] controls) 
        {

            foreach(Control c in controls)                
                c.Text = resourceManager.GetString(c.Name + "Txt");
            //element.Name  
        }

        public static void Translate(params ToolStripItem[] controls) 
        {

            foreach (ToolStripItem c in controls)                
                c.Text = resourceManager.GetString(c.Name + "Txt");
            //element.Name  
        }
        
    }
}
