using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class UserConstants
    {
        public static List<Login_Model> Users = new()
            {
                    new Login_Model(){ Username="naeem",Password="naeem_admin"}
            };
    }
}
