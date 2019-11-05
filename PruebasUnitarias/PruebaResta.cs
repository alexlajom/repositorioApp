using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaResta
    {
        [TestMethod]
        public void Resta_Valoresvalidos()
        {
            //Datos de prueba
            const int restando1 = 100;
            const int restando2 = 50;
            const int esperado = 50;

            var actual = matematicas.resta(restando1, restando2);

            Assert.AreEqual(esperado, actual);
        }
    }
}
