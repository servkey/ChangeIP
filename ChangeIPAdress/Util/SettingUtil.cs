using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAdress.Util
{
    class SettingUtil
    {
         public static string GetLanguage(){
            return Properties.Settings.Default.Language;
        }

         public static string GetConection()
         {
             return Properties.Settings.Default.ConnectionDB;
         }

         public static string GetLanguageEs()
         {
             return Properties.Settings.Default.LanguageSpanish;
         }

         public static string GetLanguageEn()
         {
             return Properties.Settings.Default.LanguageEnglish;
         }

         public static void SaveSettingEn()
         {
             Save(Properties.Settings.Default.LanguageEnglish);             
         }

         public static void SaveSettingEs()
         {
             Save(Properties.Settings.Default.LanguageSpanish);
            
         }

        private static void Save(string language){
            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();
        }
    }
}
