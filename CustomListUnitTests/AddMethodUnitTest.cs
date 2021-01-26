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
            CustomList<string> list = new CustomList<string>();
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
            CustomList<string> list = new CustomList<string>();
            string expected = "first";
            string actual;

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
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string expected = "third";
            string actual;

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
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            list.Add(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //A) capacity doubles after 5th item added
        //B) 5th item gets added successfully to index 4
        //C) at least one original thing is still where we expect

        [TestMethod]
        public void AddFiveItemsToCustomList_CheckIfCapacityDoubles()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string position4 = "fourth";
            string position5 = "fifth";
            int expected = 8;
            int actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Add(position3);
            list.Add(position4);
            list.Add(position5);

            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFiveItemsToCustomList_FifthItemIsAtIndex4()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string position4 = "fourth";
            string position5 = "fifth";
            string expected = "fifth";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Add(position3);
            list.Add(position4);
            list.Add(position5);

            actual = list[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFiveItemsToCustomList_AfterDoublingOfCapacityThirdItemIsStillAtIndex2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string position4 = "fourth";
            string position5 = "fifth";
            string expected = "third";
            string actual;

            //Act
            list.Add(position1);
            list.Add(position2);
            list.Add(position3);
            list.Add(position4);
            list.Add(position5);

            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }




    }
}
