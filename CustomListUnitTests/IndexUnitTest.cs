using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]

    public class IndexUnitTest
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckForOutOfBoundsException()
        {
            //Arrange
            //may need to revise this by adding objects, then checking if out of bounds
            CustomList<string> list = new CustomList<string>();
            string actual;

            //Act
            

            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => actual = list[0]); //make sure this line is correct
        }

        [TestMethod]
        public void CheckForIntAccessibility()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 34;
            int int1 = 34;
            int actual;

            //Act
            list.Add(int1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForCharAccessibility()
        {
            //Arrange
            CustomList<char> list = new CustomList<char>();
            char char1 = 'a';
            char char2 = 'b';
            char expected = 'b';
            char actual;

            //Act
            list.Add(char1);
            list.Add(char2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForStringAccessibility()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "first";
            string position1 = "first";
            string actual;

            //Act
            list.Add(position1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForDoubleAccessibility()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double expected = 4.0;
            double double1 = 4.0;
            double actual;

            //Act
            list.Add(double1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
