using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class OperacionesMatematicas
    { 
        public double CalcularFactorial(int numero)
        {
            int resultado = 1;
            if (numero < 0)
                return double.NaN;

            if(numero == 0) 
                    return 1; 

            if (numero == 1)
                return 1;

            for(int i = 1; i<= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
