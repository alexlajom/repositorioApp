using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaMultiplicacion
    {
        [TestMethod]
        public void Multiplicacion_ValoresValidos()
        {
            //Datos de prueba
            const int m1 = 15;
            const int m2 = 3;
            const int esperado = 45;

            var actual = matematicas.multiplicacion(m1,m2);

            Assert.AreEqual(esperado, actual);
        }
    }
}
