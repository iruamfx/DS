using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
//biblioteca de visualização
using System.Data;

namespace ex_crud
{
    class Car : Connection
    {
        private string id;
        private string model;
        private string plate;
        private string color;

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return this.model;
        }
        public void setPlate(string plate)
        {
            this.plate = plate;
        }
        public string getPlate()
        {
            return this.plate;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return this.color;
        }

        public void Insert()
        {
            string query = "insert into car(model, plate, color) values ('" + getModel() + "','" + getPlate() + "','" + getColor() + "');";
            //Abrir conexão
            if(this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        public void Delete()
        {
            string query = "delete from car where id='" + getId() + "';";
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        public DataTable Query()
        {
            this.openConnection();
            string query = "select * from car;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.closeConnection();  //Visualizar dados
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Update()
        {
            string query = "update car set model='" + getModel() + "', plate = '" + getPlate() + "', color = '" + getColor() + "' where id='" + getId() + "'";
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        public void Clean()
        {
            //string query = "truncate table car";
            //if (this.openConnection() == true)
            //{
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    cmd.ExecuteNonQuery();
            //    this.closeConnection();
            //}
        }
    }
}
