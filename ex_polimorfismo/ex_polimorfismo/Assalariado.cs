using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    class Assalariado : Empregado
    {
        private double salario;

        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }

        public override double vencimento(double valor)
        {
            valor = 1000;
            return valor;
        }
    }
}
