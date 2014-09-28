using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzConsoleApp;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Test_Is_Fizz()
        {
            //Arrange
            int number = 9;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsFizz(number);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_Is_Not_Fizz()
        {
            //Arrange
            int number = 10;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsFizz(number);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Is_Buzz()
        {
            //Arrange
            int number = 10;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsBuzz(number);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_Is_Not_Buzz()
        {
            //Arrange
            int number = 9;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsBuzz(number);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Is_FizzBuzz()
        {
            //Arrange
            int number = 15;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsFizzBuzz(number);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_Is_Not_FizzBuzz()
        {
            //Arrange
            int number = 9;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            bool result = fizzBuzz.IsFizzBuzz(number);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_SixNumbers_FizzBuzz()
        {
            //Arrange
            int number1 = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;
            int number5 = 14;
            int number6 = 15;

            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            string result1 = fizzBuzz.Validate(number1);
            string result2 = fizzBuzz.Validate(number2);
            string result3 = fizzBuzz.Validate(number3);
            string result4 = fizzBuzz.Validate(number4);
            string result5 = fizzBuzz.Validate(number5);
            string result6 = fizzBuzz.Validate(number6);

            //Assert
            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("11", result2);
            Assert.AreEqual("Fizz", result3);
            Assert.AreEqual("13", result4);
            Assert.AreEqual("14", result5);
            Assert.AreEqual("FizzBuzz", result6);

        }
    }
}
