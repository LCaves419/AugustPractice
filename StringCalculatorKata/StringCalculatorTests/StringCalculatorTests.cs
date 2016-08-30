using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {

        private StringCalculator cal;


        [SetUp]
        public void BeforeEachTest()
        {
            //Arrange
            cal = new StringCalculator();
        }

        
        [TestCase("", 0)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("4,6", 10)]
        [TestCase("4,/n2[1", 7)]
        [TestCase(":1{1+1-1", 4)]
        [TestCase("-1, 1"), 1]
        public void AddStringNumbers(string a, int expectedResult)
        {
            //Act
            int result = cal.Add(a);

            //Assert
            Assert.AreEqual(result, expectedResult);
            //Assert.That(
        }

    }
}
