using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_crud
{
    class ServerConfig
    {
        public string server;
        public string database;
        public string user;
        public string password;

        public ServerConfig(string server, string database, string user, string password)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
        }
    }
}
