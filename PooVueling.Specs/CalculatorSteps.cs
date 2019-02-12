using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace PooVueling.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ICalculadora iCalculadora = new Calculadora();
        private int num1;
        private int num2;
        private int resultado;
        

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            num1 = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number2)
        {
            num2 = number2;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            resultado = iCalculadora.Suma(num1, num2);
        }
        
        [When(@"I press substraction")]
        public void WhenIPressSubstraction()
        {
            resultado = iCalculadora.Resta(num1, num2);
        }
        
        [When(@"I press multiplication")]
        public void WhenIPressMultiplication()
        {
            resultado = iCalculadora.Multiplicacion(num1, num2);
        }
        
        [When(@"I press division")]
        public void WhenIPressDivision()
        {
            resultado = iCalculadora.Division(num1, num2);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, resultado);
        }
        
    }
}
