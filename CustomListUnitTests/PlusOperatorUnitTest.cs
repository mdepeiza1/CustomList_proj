using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class PlusOperatorUnitTest //may need to test different data type lists being added CustomList<double> + CustomList<int>
    {
        [TestMethod]
        public void MakeTwoLists_AddIntsToBothLists_CheckFinalList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;

            //Act
            list1.Add(int2);
            list1.Add(int4);
            list2.Add(int1);
            list2.Add(int3);
            list2.Add(int5);
            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(int2, list3[0]);
            Assert.AreEqual(int4, list3[1]);
            Assert.AreEqual(int1, list3[2]);
            Assert.AreEqual(int3, list3[3]);
            Assert.AreEqual(int5, list3[4]);
        } //Make one assert per test. Also make 4th list compare list4.ToString to list3.ToString


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
            string position4 = "fourth";

            //Act
            list1.Add(position2);
            list1.Add(position4);
            list2.Add(position3);
            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(position2, list3[0]);
            Assert.AreEqual(position4, list3[1]);
            Assert.AreEqual(position3, list3[2]);
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
            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(double1, list3[0]);
            Assert.AreEqual(double2, list3[1]);
            Assert.AreEqual(double3, list3[2]);
            Assert.AreEqual(double4, list3[3]);
            Assert.AreEqual(double5, list3[4]);
            Assert.AreEqual(double6, list3[5]);
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
            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(chara, list3[0]);
            Assert.AreEqual(charb, list3[1]);
            Assert.AreEqual(charc, list3[2]);
            Assert.AreEqual(chard, list3[3]);
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
            list3 = list1 + list2;

            //Assert
            Assert.AreEqual(dec2, list3[0]);
            Assert.AreEqual(dec3, list3[1]);
            Assert.AreEqual(dec1, list3[2]);
            Assert.AreEqual(dec4, list3[3]);
        }
        //Test varied size lists added together (also maybe an empty list)
    }
}
