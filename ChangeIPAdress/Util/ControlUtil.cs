using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeIPAdress.Util
{
    class ControlUtil
    {
        public static void Clear(params TextBox[] controls) {
            foreach (TextBox txt in controls)
                txt.Clear();
        }
        
    }
}
