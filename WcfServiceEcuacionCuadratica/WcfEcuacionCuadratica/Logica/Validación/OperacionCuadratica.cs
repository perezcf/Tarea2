using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceEcuacionCuadratica.Logica.Validación
{
    public class OperacionCuadratica
    {

     public bool ParametrosCorrectos(double a, double b, double c)
        {
            bool resultado = true;
            if (a == 0)
            {
                resultado = false;
            }
            else if ((Math.Pow(b, 2) - (4 * a * c)) < 0)
            {
                resultado = false;

            }
            else
            {
                resultado = true;
            }

            return resultado;

        }


    }
}