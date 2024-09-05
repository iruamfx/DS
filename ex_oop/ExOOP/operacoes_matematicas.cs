using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP
{
    class operacoes_matematicas
    {
        //Attributes

        /* Definição do metodo:
            Todo metodo deve ter uma visibilidade (public ou private) os metodos sempre serão publicos.
            float e o tipo do metodo de acordo com a ação do metodo.
            somaXY é o nome do metodo para sua indetificação quando invocado
            pelos formularios (um ou mais formulario)
            float x e float y são tipo "variaveis", ou, parametros.
            Obs: paraemtros são informaçoes necessarias para o metodo funcionar.
            O que esta no return é o retorno do metodo, assim como uma formula matematica.

            
        */
        //Methods - Mathematical Formulae
        
        public float sumXY(float x, float y)
        {
            return x + y;
        }
        public float subtractXY(float x, float y)
        {
            return x - y;
        }
        public float divideXY(float x, float y)
        {
            return x / y;
        }
        public float multiplyXY(float x, float y)
        {
            return x * y;
        }
    }
}
