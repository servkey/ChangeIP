using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAddressLibrary.Base
{
    class Profile
    {
        private String name;

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
