using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ChangeIPAddressLibrary.Core
{
    public class ProfileHelper :IHelper<Base.Profile>
    {
        private SQLiteConnection conn;

        public ProfileHelper()
        {

        }

        public void Add(Base.Profile e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Base.Profile e)
        {
            throw new NotImplementedException();
        }

        public Base.Profile GetProfile(Base.Profile e)
        {
            throw new NotImplementedException();
        }

        public List<Base.Profile> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
