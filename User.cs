using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace WindowsFormsApplication1
{
    public enum sUserType
    {
        Editor=0,
        Sound_Engineer=1,
        Sound_Master=2

    }
    public class User
    {
        public string sName { set; get; }
        public string sSurName { set; get;  }
        public string sEmail { set; get;  }
        public string sPassword { set; get; }
        public bool isAdmin { set; get;  }

        public string sUsertype { set; get;  }

        public bool isSuccPurchase { set; get; }

        public bool iLokValid { set; get; }

        public User(string name, string sur, string email, string pass, bool admin, string utype, bool suc, bool ilock)
        {
            sName = name;
            sSurName = sur;
            sEmail = email;
            isAdmin = admin;
            sUsertype = utype;
            isSuccPurchase = suc;
            iLokValid = ilock;
        }
    }
}
