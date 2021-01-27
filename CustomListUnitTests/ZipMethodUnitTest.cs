using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class ZipMethodUnitTest
    {
        [TestMethod]
        public void MakeTwoLists_AddIntsToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();

            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;
            int int6 = 6;

            //Act
            list1.Add(int2);
            list1.Add(int4);
            list1.Add(int6);
            list2.Add(int3);
            list2.Add(int5);
            list1.Zip(list2);

            list3.Add(int2);
            list3.Add(int3);
            list3.Add(int4);
            list3.Add(int5);
            list3.Add(int6);

            //Assert
            Assert.AreEqual(list3.ToString(), list1.ToString());
        }


        [TestMethod]
        public void MakeTwoLists_AddStringsToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> list3 = new CustomList<string>();

            string position1 = "first";
            string position2 = "second";
            string position3 = "third";

            //Act
            list1.Add(position2);
            list2.Add(position1);
            list2.Add(position3);
            list1.Zip(list2);

            list3.Add(position2);
            list3.Add(position1);
            list3.Add(position3);

            //Assert
            Assert.AreEqual(list3.ToString(), list1.ToString());
        }


        [TestMethod]
        public void MakeTwoLists_AddDoublesToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> list3 = new CustomList<double>();

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
            list2.Add(double4);
            list2.Add(double5);
            list2.Add(double6);
            list1.Zip(list2);

            list3.Add(double1);
            list3.Add(double4);
            list3.Add(double2);
            list3.Add(double5);
            list3.Add(double3);
            list3.Add(double6);

            //Assert
            Assert.AreEqual(list3.ToString(), list1.ToString());
        }

        [TestMethod]
        public void MakeTwoLists_AddCharsToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> list3 = new CustomList<char>();

            char chara = 'a';
            char charb = 'b';
            char charc = 'c';
            char chard = 'd';

            //Act
            list1.Add(chara);
            list1.Add(charb);
            list2.Add(charc);
            list2.Add(chard);
            list2.Zip(list1);

            list3.Add(charc);
            list3.Add(chara);
            list3.Add(chard);
            list3.Add(charb);

            //Assert
            Assert.AreEqual(list3.ToString(), list2.ToString());
        }

        [TestMethod]
        public void MakeTwoLists_AddDecimalsToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<decimal> list1 = new CustomList<decimal>();
            CustomList<decimal> list2 = new CustomList<decimal>();
            CustomList<decimal> list3 = new CustomList<decimal>();

            decimal dec1 = new decimal(1.01);
            decimal dec2 = new decimal(2.02);
            decimal dec3 = new decimal(3.03);
            decimal dec4 = new decimal(4.04);

            //Act
            list1.Add(dec2);
            list1.Add(dec3);
            list2.Add(dec1);
            list2.Add(dec4);
            list1.Zip(list2);

            list1.Add(dec2);
            list1.Add(dec1);
            list2.Add(dec3);
            list2.Add(dec4);

            //Assert
            Assert.AreEqual(list3.ToString(), list1.ToString());
        }
        //zip diff sized lists, test each list being the smaller one
    }
}
