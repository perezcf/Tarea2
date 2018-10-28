using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceEcuacionCuadratica.Logica.Accion
{
    public class OperacionCuadratica
    {

        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double EcuacionCuadratica(double a, double b, double c)
        {
            double elResultado1 = 0.0;
            double elResultado2 = 0.0;
            //validación de parametros correctos
            var laValidacion = new Logica.Validación.OperacionCuadratica();
            if (laValidacion.ParametrosCorrectos(a, b, c))
            {
                elResultado1 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                elResultado2 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            }
            else
            {
                MiListaDeErrores.Add("Revisar que el parametro 'a' no sea igual a cero");
                MiListaDeErrores.Add("Revisar que el discriminante sea mayor o igual que cero");
            }

            return elResultado1 + elResultado2;

        }


    }
}