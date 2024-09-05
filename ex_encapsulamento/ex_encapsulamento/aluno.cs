using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_encapsulamento
{
    class Aluno
    {
        private string nome;
        private string cpf;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }


        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCPF()
        {
            return this.cpf;
        }
    }
}
