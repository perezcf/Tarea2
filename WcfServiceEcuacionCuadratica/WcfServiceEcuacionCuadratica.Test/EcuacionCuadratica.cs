using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfServiceEcuacionCuadratica.Test
{
    [TestClass]
    public class EcuacionCuadratica
    {
        [TestMethod]
        public void ParametroAPositivoDiscriminantePositivo()
        {

            //// preparación del escenario
            var a = 1.0;
            var b = -2.0;
            var c = -24.0;
            var miValorEsperado = 6 + -4;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new WcfServiceEcuacionCuadratica.Service1();
            miValorReal = elServicio.EcuacionCuadratica(a, b, c);

            //verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);



        }
    }
}
