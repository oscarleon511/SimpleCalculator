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
            Class1 test = new Class1();
            double number = 100;
            test.GetNumber1();
           
            //Act
            double num1test = test.num1;
            
            //Assert
            Assert.AreEqual(number, num1test);
        }
        [TestMethod]
        public void TestForSecondNumber()
        {
            //string for input2 is converted to double
            //Arrange
            Class1 test = new Class1();
            double numer = 20;
            //Act
            test.GetNumber2();
            double num2test= test.num2;
            //Assert
            Assert.AreEqual(numer, num2test);
        }
        [TestMethod]
        public void TestForSubstractSign()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            string sign = "-";
            //Act

            addition.Sign();
            string testsign = addition.oper;
            //Assert
            Assert.AreEqual(sign, testsign);
        }
        [TestMethod]
        public void TestForAdditiontSign()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            string sign = "+";
            //Act

            addition.Sign();
            string testsign = addition.oper;
            //Assert
            Assert.AreEqual(sign, testsign);
        }
        [TestMethod]
        public void TestForMultiplicationSign()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            string sign = "*";
            //Act
            addition.Sign();
            string testsign = addition.oper;
            //Assert
            Assert.AreEqual(sign, testsign);
        }
        [TestMethod]
        public void TestForDivisionSign()
        {
            //Identify sign 
            //Arrange
            Class1 addition = new Class1();
            string sign = "/";
            //Act
             addition.Sign();
             string testsign = addition.oper;
            //Assert
            Assert.AreEqual(sign, testsign);
        }
        //[TestMethod]
        //public void TestForCalculationsSubstract()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 addition = new Class1();
        //    double num1 = 20;
        //    double num2 = 4;
        //    string sign = "-";
        //    //Act

        //   addition.Calculations();
        //   string symbo = addition.oper;
        //   symbo = sign;
        //   double total = 

        //    //Assert
        //    Assert.AreEqual(16, total);
        //}
        //[TestMethod]
        //public void TestForCalculationsAddition()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 addition = new Class1();
        //    double num1 = 20;
        //    double num2 = 4;
        //    string sign = "+";
        //    //Act

        //    double total = addition.Calculations(num1, num2, sign);

        //    //Assert
        //    Assert.AreEqual(24, total);
        //}
        //[TestMethod]
        //public void TestForCalculationsMultiply()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 addition = new Class1();
        //    double num1 = 20;
        //    double num2 = 4;
        //    string sign = "*";
        //    //Act

        //    double total = addition.Calculations(num1, num2, sign);

        //    //Assert
        //    Assert.AreEqual(80, total);
        //}
        //[TestMethod]
        //public void TestForCalculationsDivision()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 addition = new Class1();
        //    double num1 = 20;
        //    double num2 = 4;
        //    string sign = "/";
        //    //Act

        //    double total = addition.Calculations(num1, num2, sign);

        //    //Assert
        //    Assert.AreEqual(5, total);
        //}
        //[TestMethod]
        //public void TestForCalculationsforDifferentSymbol()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 addition = new Class1();
        //    double num1 = 20;
        //    double num2 = 4;
        //    string sign = "%";
        //    //Act
        //    try
        //    {
        //        double total = addition.Calculations(num1, num2, sign);
        //    }
        //    catch (Exception ex)
        //    {
        //        //Assert
        //        Assert.IsNotNull(ex);
        //        Assert.AreEqual(ex.Message, "Please try again!!");
        //    }





        //}
    }
}
