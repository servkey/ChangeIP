using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ChangeIPAddressLibrary.Core
{
    public class ProfileHelper :IHelper<Base.Profile>
    {
        private DBLiteConnection conn;

        public ProfileHelper()
        {
            conn = new DBLiteConnection();
        }

        public void Add(Base.Profile e)
        {            
              
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
            List<Base.Profile> profiles = new List<Base.Profile>();
            try
            {
                ChangeIPAddressLibrary.Core.DBLiteConnection db = new ChangeIPAddressLibrary.Core.DBLiteConnection();
                SQLiteDataReader reader = db.ExecuteQuery(Base.Profile.QPROFILES);
                while (reader.Read())
                {
                    Base.Profile profile = new Base.Profile
                    {
                        IdProfile = Convert.ToInt32(reader[0]),
                        ProfileName = Convert.ToString(reader[1]),
                        DhcpEnabled = Convert.ToBoolean(reader[2]),
                        IpAddress = Convert.ToString(reader[3]),
                        IpSubnet = Convert.ToString(reader[4]),
                        DefaultIpGateway = Convert.ToString(reader[5] == null? "": reader[5]),
                        DnsServerSearchOrder = Convert.ToString(reader[6] == null ? "" : reader[6]),  
                        MacAddress = Convert.ToString(reader[7]),
                        SettingId = Convert.ToString(reader[8] == null ? "" : reader[8]), 
                        Caption = Convert.ToString(reader[9] == null ? "" : reader[9]), 
                        ServiceName = Convert.ToString(reader[10] == null ? "" : reader[10]),
                        Description = Convert.ToString(reader[11] == null ? "" : reader[11]), 
                    };
                    profiles.Add(profile);                    
                }

            }
            catch (Exception e)
            {
            }
            return profiles;
        }
    }
}

