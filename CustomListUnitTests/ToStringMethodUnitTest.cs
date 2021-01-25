using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class ToStringMethodUnitTest
    {
        [TestMethod]
        public void AddThreeIntsToACustomList_CheckToStringIsAsExpected()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "123";
            string actual;
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;

            //Act
            list.Add(int1);
            list.Add(int2);
            list.Add(int3);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThreeCharsToACustomList_CheckToStringIsAsExpected()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "abc";
            string actual;
            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';

            //Act
            list.Add(char1);
            list.Add(char2);
            list.Add(char3);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoStringsToACustomList_CheckToStringIsAsExpected()
        {
            //Arrange
            CustomList list = new CustomList();
            string position1 = "first";
            string position2 = "second";
            string expected = "firstsecond";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThreeDoublesToACustomList_CheckToStringIsAsExpected()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "2.13.24.4";
            string actual;
            double double1 = 2.1;
            double double2 = 3.2;
            double double3 = 4.4;

            //Act
            list.Add(double1);
            list.Add(double2);
            list.Add(double3);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThreeCharsToACustomList_RemoveCharTwo_CheckToStringIsAsExpected()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "ac";
            string actual;
            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';

            //Act
            list.Add(char1);
            list.Add(char2);
            list.Add(char3);
            list.Remove(char2);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
