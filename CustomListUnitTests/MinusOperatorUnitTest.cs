using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class MinusOperatorUnitTest
    {
        [TestMethod]
        public void MakeTwoLists_AddIntsToBothListsWithOneInCommon_CheckFinalList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> list4 = new CustomList<int>();
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;

            //Act
            list1.Add(int2);
            list1.Add(int3);
            list1.Add(int4);
            list2.Add(int1);
            list2.Add(int3);
            list2.Add(int5);
            list3 = list1 - list2;

            list4.Add(int2);
            list4.Add(int4);

            //Assert
            Assert.AreEqual(list4.ToString(), list3.ToString());
        }


        [TestMethod]
        public void MakeTwoLists_AddStringsToBothListsWithOneInCommon_CheckFinalList()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> list3 = new CustomList<string>();
            CustomList<string> list4 = new CustomList<string>();
            string position1 = "first";
            string position2 = "second";
            string position3 = "third";
            string position4 = "fourth";

            //Act
            list1.Add(position2);
            list1.Add(position1);
            list1.Add(position4);
            list1.Add(position3);
            list2.Add(position1);
            list2.Add(position3);
            list3 = list1 - list2;

            list4.Add(position2);
            list4.Add(position4);

            //Assert
            Assert.AreEqual(list4.ToString(), list3.ToString());
        }


        [TestMethod]
        public void MakeTwoLists_AddDoublesToBothListsWithOneInCommon_CheckFinalList()
        {
            //Arrange
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> list3 = new CustomList<double>();
            CustomList<double> list4 = new CustomList<double>();
            double double1 = 1.0;
            double double2 = 2.2;
            double double3 = 3.3;
            double double4 = 4.4;
            double double5 = 5.5;
            double double6 = 6.6;

            //Act
            list1.Add(double1);
            list1.Add(double2);
            list1.Add(double3);
            list1.Add(double4);
            list2.Add(double4);
            list2.Add(double5);
            list2.Add(double6);
            list3 = list1 - list2;

            list4.Add(double1);
            list4.Add(double2);
            list4.Add(double3);

            //Assert
            Assert.AreEqual(list4.ToString(), list3.ToString());
        }

        [TestMethod]
        public void MakeTwoLists_AddCharsToBothListsWithOneInCommon_CheckFinalList()
        {
            //Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> list3 = new CustomList<char>();
            CustomList<char> list4 = new CustomList<char>();
            char chara = 'a';
            char charb = 'b';
            char charc = 'c';
            char chard = 'd';

            //Act
            list1.Add(chara);
            list1.Add(charc);
            list1.Add(charc);
            list1.Add(charb);
            list2.Add(charc);
            list2.Add(chard);
            list3 = list1 - list2;

            list4.Add(chara);
            list4.Add(charc);
            list4.Add(charb);

            //Assert
            Assert.AreEqual(list4.ToString(), list3.ToString());
        }

        [TestMethod]
        public void MakeTwoLists_AddDecimalsToBothListsWithOneInCommon_CheckFinalList()
        {
            //Arrange
            CustomList<decimal> list1 = new CustomList<decimal>();
            CustomList<decimal> list2 = new CustomList<decimal>();
            CustomList<decimal> list3 = new CustomList<decimal>();
            CustomList<decimal> list4 = new CustomList<decimal>();
            decimal dec1 = new decimal(1.01);
            decimal dec2 = new decimal(2.02);
            decimal dec3 = new decimal(3.03);
            decimal dec4 = new decimal(4.04);

            //Act
            list1.Add(dec1);
            list1.Add(dec3);
            list2.Add(dec2);
            list2.Add(dec3);
            list3 = list1 - list2;

            list4.Add(dec1);

            //Assert
            Assert.AreEqual(list4.ToString(), list3.ToString());
        }
    }
}
