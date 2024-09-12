using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_struct
{
    class Authentication : Connection
    {
        public int authLogin()
        {
            this.openConnection();

            string mSql = "Select count('users') from login where user='" + user + "' and senha"
        }
    }
}
