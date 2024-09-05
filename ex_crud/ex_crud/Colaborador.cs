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
    class Colaborador : Connection
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public void Insert()
        {
            string query = "insert into colaborador(nome_colaborador, sobrenome_colaborador, cpf_colaborador) values ('" + getNome() + "','" + getSobrenome() + "','" + getCpf() + "');";
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
            string query = "delete from colaborador where codigo_colaborador='" + getCodigo() + "';";
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
            string query = "select * from colaborador;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.closeConnection();  //Visualizar dados
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Update()
        {
            string query = "update colaborador set nome_colaborador='" + getNome() + "', sobrenome_colaborador = '" + getSobrenome() + "', cpf_colaborador = '" + getCpf() + "' where codigo_colaborador='" + getCodigo() + "'";
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }
    }
}
