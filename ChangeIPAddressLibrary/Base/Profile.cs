using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAddressLibrary.Base
{
    public class Profile
    {
        private String name;
        private bool dhcpEnabled;
        private String ip;

        public String Name {
            set
            {
                name = value;
            }
            get {
                return name;
            }

        }

    }

}
