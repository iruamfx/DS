using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace project_struct
{
    class Authentication : Connection
    {
        private string user;
        private string pass;

        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return user;
        }
        public void setPass(string pass)
        {
            this.pass = pass;
        }
        public string getPass()
        {
            return pass;
        }

        public int authLogin()
        {
            if (user != null && pass != null)
            {
                this.openConnection();

                string mSql = "Select count(*) from users where username='" + user + "' and pass='" + pass + "';";

                MySqlCommand cmd = new MySqlCommand(mSql, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                Int32 res = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                this.closeConnection();
                return res;
            }else
            {
                return 0;
            }
        }
    }
}
