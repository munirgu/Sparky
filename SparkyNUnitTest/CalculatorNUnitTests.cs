using NUnit.Framework;
using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]

        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //arrange

            Calculator calc = new Calculator();

            //act

            int result = calc.AddNumbers(10, 20);

            //assert

            Assert.AreEqual(30, result);
        }


        [Test]
        public void IsOddNumber_InputInt_GetCorrectBoolean()
        {
            //arrange

            Calculator calc = new Calculator();

            //act

            bool result = calc.IsOddNumber(3);

            //assert

            Assert.AreEqual(true,result);
        }

    }
}
