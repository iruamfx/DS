using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
//biblioteca de visualização
using System.Data;

namespace zoo_crud
{
    class Animal : Connection
    {
        private string id;
        private string name;
        private string habitat;
        private string nutrition;
        private string weight;

        #region Getters and Setters
        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setHabitat(string habitat)
        {
            this.habitat = habitat;
        }
        public string getHabitat()
        {
            return this.habitat;
        }
        public void setNutrition(string nutrition)
        {
            this.nutrition = nutrition;
        }
        public string getNutrition()
        {
            return this.nutrition;
        }
        public void setWeight(string weight)
        {
            this.weight = weight;
        }
        public string getWeight()
        {
            return this.weight;
        }
        #endregion

        public void Insert()
        {
            string query = "insert into animal(name, habitat, nutrition, weight) values ('" + getName() + "','" + getHabitat() + "','" + getNutrition() + "','" + getWeight() + "');";
            //Abrir conexão
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        public void Delete()
        {
            string query = "delete from animal where id ='" + getId() + "';";
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
            string query = "select * from animal;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.closeConnection();  //Visualizar dados
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
