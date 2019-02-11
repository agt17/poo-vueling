using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [DataRow(4, 3, 7)]
        [DataRow(0, 3, 3)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }

        [DataRow(4, 3, 1)]
        [DataRow(1, 3, -2)]
        [TestMethod()]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(4, 3, 12)]
        [DataRow(4, 0, 0)]
        [TestMethod()]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(0, 3, 0)]
        [DataRow(9, 3, 3)]
        [DataRow(9, 0, 0)] // what to do
        [TestMethod()]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }
    }
}