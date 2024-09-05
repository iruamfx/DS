using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;
        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }
        public double getTotalVenda()
        {
            return this.totalVenda;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }
        public double getTaxaComissao()
        {
            return this.taxaComissao;
        }
        public override double vencimento(double valor)
        {
            valor = 100;
            return valor;
        }
    }
}
