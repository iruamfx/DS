﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polimorfismo
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }

        public double getPrecoHora()
        {
            return this.precoHora;
        }

        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public double getHorasTrabalhadas()
        {
            return this.horasTrabalhadas;
        }

        public override Double vencimento (double valor)
        {
            valor = 10;
            return valor;
        }
    }
}
