using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFirstNumber()
        {
            //string for input1 is converted to double
            //Arrange
            Class1 addition = new Class1();
            //Act
            string numer = "100";
           double numero1 = addition.GetNumber1(numer);
            //Assert
           Assert.AreEqual(100, numero1);
        }
        [TestMethod]
        public void TestForSecondNumber()
        {
            //string for input2 is converted to double
            //Arrange
            Class1 addition = new Class1();
            //Act
            string numer = "20";
            double numero1 = addition.GetNumber2(numer);
            //Assert
            Assert.AreEqual(20, numero1);
        }
        [TestMethod]
        public void TestForSign()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            //Act
            string sign = "-";
            string numero1 = addition.Sign(sign);
            //Assert
            Assert.AreEqual("-", numero1);
        }
        [TestMethod]
        public void TestForCalculations()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            //Act
            double num1 = 20;
            double num2 = 4;
            string sign = "-";
            double total = addition.Calculations(num1, num2, sign);

            //Assert
            Assert.AreEqual(16, total);
        }
    }
}
