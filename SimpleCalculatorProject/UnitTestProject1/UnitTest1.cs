using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TescalculationsAdding()
        {
            //string for input1 is converted to double
            //Arrange
            Class1 test = new Class1();
            double num1 = 3;
            string oper = "+";
            double num2 = 100;
            double expected = 103;
           double actual = test.Calculations(num1, oper, num2);
           Assert.AreEqual(expected, actual);
            
           
           
        }
        //[TestMethod]
        //public void TestForSecondNumber()
        //{
        //    //string for input2 is converted to double
        //    //Arrange
        //    Class1 test = new Class1();
        //    string number2 = "20";
        //    //Act
        //    test.GetNumber2(number2);
        //    double convertednumber = test.savednum2;
        //    //Assert
        //    Assert.AreEqual(20, convertednumber);
           
        //}
        //[TestMethod]
        //public void TestForSubstractSign()
        //{
        //    //Identify sign negative sign
        //    //Arrange
        //    Class1 test = new Class1();
        //    string expected = "-";
        //    //Act

        //   test.Sign(expected);
        //   string actual = test.savedoper;
            
        //    //Assert
        //   Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestForAdditiontSign()
        //{
        //    //Identify positive sign
        //    //Arrange
        //    Class1 test = new Class1();
        //    string expected = "+";
        //    //Act
        //    test.Sign(expected);
        //    string actual = test.savedoper;
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestForMultiplicationSign()
        //{
        //    //Identify multiplication sign
        //    //Arrange
        //    Class1 test = new Class1();
        //    string expected = "*";
        //    //Act
        //    test.Sign(expected);
        //    string actual = test.savedoper;
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestForDivisionSign()
        //{
        //    //Identify division sign 
        //    //Arrange
        //    Class1 test = new Class1();
        //    string expected = "/";
        //    //Act
        //    test.Sign(expected);
        //    string actual = test.savedoper;
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestForCalculations_Substract()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 test = new Class1();
        //    test.savednum1 = 20;
        //    test.savednum2 = 4;
        //    test.savedoper = "-";
        //    double expected = 16;
        //    //Act
        //    test.Calculations();
        //     //Assert
        //   Assert.AreEqual(expected, test.Calculations());
        //}
        //[TestMethod]
        //public void TestForCalculations_Addition()
        //{
        //    //Test for addition
        //    //Arrange
        //    Class1 test = new Class1();
        //    test.savednum1 = 20;
        //    test.savednum2 = 4;
        //    test.savedoper = "+";
        //    double expected = 24;
        //    //Act
        //    test.Calculations();
        //    //Assert
        //    Assert.AreEqual(expected, test.Calculations());
        //}
        //[TestMethod]
        //public void TestForCalculations_Multiply()
        //{
        //    //Test for miltiplication
        //    //Arrange
        //    Class1 test = new Class1();
        //    test.savednum1 = 20;
        //    test.savednum2 = 4;
        //    test.savedoper = "*";
        //    double expected = 80;
        //    //Act
        //    test.Calculations();

        //    //Assert
        //    Assert.AreEqual(expected, test.Calculations());
        //}
        //[TestMethod]
        //public void TestForCalculations_Division()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 test = new Class1();
        //    test.savednum1 = 20;
        //    test.savednum2 = 5;
        //    test.savedoper = "/";
        //    double expected = 4;
        //    //Act
        //    test.Calculations();
        //    //Assert
        //    Assert.AreEqual(expected, test.Calculations());
        //}
        //[TestMethod]
        //public void TestForCalculationsformorethan3numbers()
        //{
        //    //Test for substraction
        //    //Arrange
        //    Class1 test = new Class1();
        //    double num1 = 20;
        //    string sign1 = "+"
        //    double num2 = 4;
        //    string sign2 = "-";
        //    double num3 = 10;
        //    string sign3 = "=";
        //    double expected = 14;
           
        // Act 
        //    double actual = test.MultipleCalculations(list 1, list2);
        // Assert
        //   Assert.AreEqual(expected, actual);





        //}
    }
}
