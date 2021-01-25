using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class AddMethodUnitTest
    {
        [TestMethod]
        public void AddItemToCustomList_CheckCountIs1()
        {
            //Arrange
            CustomList list = new CustomList();
            string position = "first";
            int expected = 1;
            int actual;

            //Act
            list.Add(position);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckIndex0ForAddedItem()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "first";
            int actual;

            //Act
            list.Add(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemsToCustomList_CheckIndex2ForThirdAddedItem()
        {
            //Arrange
            CustomList list = new CustomList();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string expected = "third";
            int actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Add(position3);

            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddIntToCustomList_CheckIndex0ForIntPassedIn()
        {
            //Arrange
            CustomList list = new CustomList();
            int expected = 1;
            int actual;

            //Act
            list.Add(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddItemToCustomList_AccessIndex1_CheckForOutOfRangeError()
        {
            //Arrange
            CustomList list = new CustomList();
            string expected = "first";
            int actual;

            //Act
            list.Add(expected);
            actual = list[1];

            //Assert
        }
    }
}
