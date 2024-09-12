using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Biblioteca de conexão do MySql
using MySql.Data;
using MySql.Data.MySqlClient;

namespace project_struct
{
    class Connection
    {
        //Atributos
        public MySqlConnection connection;
        public string server;
        public string database;
        public string user;
        public string password;
        //Construtor
        public Connection()
        {
            server = "127.0.0.1";
            // IP Localhost
            database = "ds_crud";
            //Database que iremos criar futuramente
            user = "root";
            password = "";
            //Usuario e senha padrões  são root e senha nula para conexões remota. É necessario substituir por usuario e senha fornecidas
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            //MySqlConnection - utilizar a connectionString para conectar ao banco de dados
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possivel conectar!");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuario e senha invalidos!");
                        break;
                }
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
