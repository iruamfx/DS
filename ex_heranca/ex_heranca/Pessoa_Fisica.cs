using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_heranca
{
    // ":" é o sinal de herança
    class Pessoa_Fisica : Pessoa
    {
        private string rg;

        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getRg()
        {
            return this.rg;
        }
    }
}
