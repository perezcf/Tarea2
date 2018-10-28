using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceEcuacionCuadratica.Logica.Especificación
{
    public class OperacionCuadratica
    {



        /// <summary>
        /// Función que devuelve el valor o valores de una función cuadratica.
        /// </summary>
        /// <param name="laBase">la base de la operación</param>
        /// <param name="elExponente">el exponente de la operación</param>
        /// <returns>el valor de la base elevado a la potencia</returns>

        public double EcuacionCuadratica(double a, double b, double c)
        {
            var laAccion = new WcfServiceEcuacionCuadratica.Logica.Accion.OperacionCuadratica();
            double elResultado = laAccion.EcuacionCuadratica(a, b, c);
            return elResultado;

        }










    }
}