using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class RemoveMethodUnitTest
    {
        [TestMethod]
        public void AddItemToList_RemoveItemFromList_ReturnsTrue()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            bool expected = true;
            bool actual;

            //Act
            list.Add(position1);
            actual = list.Remove(position1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItemFromList_ReturnsFalse()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            bool expected = false;
            bool actual;

            //Act
            actual = list.Remove("first");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToList_RemoveItemFromList_CheckCountIs0()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            int expected = 0;
            int actual;

            //Act
            list.Add(position1);
            list.Remove(position1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // might need to remove this one
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddTwoItemsToList_Remove1ItemFromList_Index1isError()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Remove(position2);
            actual = list[1];

            //Assert
        }

        [TestMethod]
        public void AddTwoOfTheSameItemToList_RemoveItemFromList_ReturnsTrue()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            bool expected = true;
            bool actual;

            //Act
            list.Add(position1);
            list.Add(position1);
            actual = list.Remove(position1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOneStringAnotherStringThenSameAsFirstStringToList_RemoveItemFromList_CheckIndex1IsEqualToFirstString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string expected = "first";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Add(position1);
            list.Remove(position1);

            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoItemsToList_RemoveFirstItemFromList_Index0EqualsSecondItemAdded()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string expected = "second";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Remove(position1);

            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }



        //Remove something not in list, test that count does not decrement

        [TestMethod]
        public void AddTwoItemsToList_RemoveItemNotInList_CheckCountStays2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            int expected = 2;
            int actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Remove("third");

            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
