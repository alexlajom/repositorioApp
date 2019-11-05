using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora; 
namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaDivision
    {
        [TestMethod]
        public void Division_valoresValidos()
        {
            // Datos de prueba
            const int dividenddo = 8;
            const int divisor = 2;
            const int esperado = 4;

            var actual = matematicas.division(dividenddo, divisor );

            Assert.AreEqual(esperado, actual);
        }
    }
}
