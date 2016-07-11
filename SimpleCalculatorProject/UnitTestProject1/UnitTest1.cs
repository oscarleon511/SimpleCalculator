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
            string number1 = "2";
            //Act
            test.GetNumber1(number1);
            double convertednumber = test.savednum1;
           
            //Assert
            Assert.AreEqual(2, convertednumber);
        }
        [TestMethod]
        public void TestForSecondNumber()
        {
            //string for input2 is converted to double
            //Arrange
            Class1 test = new Class1();
            string number2 = "20";
            //Act
            test.GetNumber2(number2);
            double convertednumber = test.savednum2;
            //Assert
            Assert.AreEqual(20, convertednumber);
           
        }
        [TestMethod]
        public void TestForSubstractSign()
        {
            //Identify sign negative sign
            //Arrange
            Class1 test = new Class1();
            string expected = "-";
            //Act

           test.Sign(expected);
           string actual = test.savedoper;
            
            //Assert
           Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForAdditiontSign()
        {
            //Identify positive sign
            //Arrange
            Class1 test = new Class1();
            string expected = "+";
            //Act
            test.Sign(expected);
            string actual = test.savedoper;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForMultiplicationSign()
        {
            //Identify multiplication sign
            //Arrange
            Class1 test = new Class1();
            string expected = "*";
            //Act
            test.Sign(expected);
            string actual = test.savedoper;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForDivisionSign()
        {
            //Identify division sign 
            //Arrange
            Class1 test = new Class1();
            string expected = "/";
            //Act
            test.Sign(expected);
            string actual = test.savedoper;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForCalculations_Substract()
        {
            //Test for substraction
            //Arrange
            Class1 test = new Class1();
            test.savednum1 = 20;
            test.savednum2 = 4;
            test.savedoper = "-";
            double expected = 16;
            //Act
            test.Calculations();
             //Assert
           Assert.AreEqual(expected, test.Calculations());
        }
        [TestMethod]
        public void TestForCalculations_Addition()
        {
            //Test for addition
            //Arrange
            Class1 test = new Class1();
            test.savednum1 = 20;
            test.savednum2 = 4;
            test.savedoper = "+";
            double expected = 24;
            //Act
            test.Calculations();
            //Assert
            Assert.AreEqual(expected, test.Calculations());
        }
        [TestMethod]
        public void TestForCalculations_Multiply()
        {
            //Test for miltiplication
            //Arrange
            Class1 test = new Class1();
            test.savednum1 = 20;
            test.savednum2 = 4;
            test.savedoper = "*";
            double expected = 80;
            //Act
            test.Calculations();

            //Assert
            Assert.AreEqual(expected, test.Calculations());
        }
        [TestMethod]
        public void TestForCalculations_Division()
        {
            //Test for substraction
            //Arrange
            Class1 test = new Class1();
            test.savednum1 = 20;
            test.savednum2 = 5;
            test.savedoper = "/";
            double expected = 4;
            //Act
            test.Calculations();
            //Assert
            Assert.AreEqual(expected, test.Calculations());
        }
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
