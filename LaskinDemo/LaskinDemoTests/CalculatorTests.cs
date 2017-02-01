using Microsoft.VisualStudio.TestTools.UnitTesting;
using LaskinDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskinDemo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ///AAA periaate
            ///A=Arrange, tietojen alustus
            ///A=Act, kutsutaan metodia
            ///A=Assert, varmistetaan, että tulos ok
            ///arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;
            //act
            int actual = calc.Add(a,b);
            //assert
            Assert.AreEqual(expected, actual);
            //ja toinen testi Add-metodilla
            a = 0;
            b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);


            //Assert.Fail(); //alkuperäinen koodi
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;
            //act
            int actual = calc.Multiply(a, b);
            //assert
            Assert.AreEqual(expected, actual);


            //Assert.Fail();
        }
    }
}