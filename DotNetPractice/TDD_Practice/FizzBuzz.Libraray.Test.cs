using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.TDD_Practice
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void WhenDefault_returnDefault([Values(1,2,4)]int input)
        {
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assertion
            Assert.AreEqual(input.ToString(), output);
        }
        
        [Test]
        public void WhenDiv3_returnFizz([Values(3,6,9,12)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void WhenDiv5_returnBuzz([Values(5,10)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);

        }

        [Test]
        public void WhenDiv15_returnFizzBuzz([Values(15,30,45)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
            
        }
        
    }
}
