using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaSuma
    {
        [TestMethod]
        public void Suma_valoresValidos()
        {
            //Datos de prueba
            const int sumando1 = 4;
            const int sumando2 = 5;
            const int esperado = 9;

            var actual = matematicas.suma(sumando1, sumando2);

            Assert.AreEqual(esperado, actual);
        }
    }
}
