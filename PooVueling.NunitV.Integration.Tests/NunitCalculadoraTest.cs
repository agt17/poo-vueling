using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVueling;
using NUnit.Framework;

namespace PooVueling.NunitV.Integration.Tests
{

    [TestFixture]
    public class NunitCalculadoraTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestCase(4, 2, 6)]
        [TestCase(1, 2, 3)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }

        [TestCase(4, 2, 2)]
        [TestCase(0, 2, -2)]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [TestCase(4, 2, 8)]
        [TestCase(0, 2, 0)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 3)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        //[TestCase(9, 0, 0), ExpectedException = typeof(DivideByZeroException)]
        public void DivisionDivideByZeroExceptionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }
    }
}
