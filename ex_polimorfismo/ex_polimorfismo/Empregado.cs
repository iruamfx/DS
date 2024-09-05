using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    class Empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;

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

        //Classe empregado é a super classe
        //Metodo virtual é um metodo que pode ser substituido por outro metodo
        //de mesmo nome
        public virtual Double vencimento(double valor)
        {
            valor = 0;
            return valor;
        }
    }
}
