using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class SortMethodUnitTest
    {
        [TestMethod]
        public void AddIntsToAListUnsorted_TestThatListGetsSorted()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;
            int int6 = 6;

            list1.Add(int2);
            list1.Add(int4);
            list1.Add(int6);
            list1.Add(int1);
            list1.Add(int3);
            list1.Add(int5);

            list1.Sort();

            list2.Add(int1);
            list2.Add(int2);
            list2.Add(int3);
            list2.Add(int4);
            list2.Add(int5);
            list2.Add(int6);

            Assert.AreEqual(list2.ToString(), list1.ToString());
        }

        [TestMethod]
        public void AddStringsToAListUnsorted_TestThatListGetsSorted()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();

            string position1 = "alligator";
            string position2 = "beaver";
            string position3 = "camel";

            list1.Add(position3);
            list1.Add(position1);
            list1.Add(position2);

            list1.Sort();

            list2.Add(position1);
            list2.Add(position2);
            list2.Add(position3);

            Assert.AreEqual(list2.ToString(), list1.ToString());
        }

        [TestMethod]
        public void AddDoublesToAListUnsorted_TestThatListGetsSorted()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();

            double double3 = 3.3;
            double double5 = 5.5;
            double double6 = 6.6;

            list1.Add(double5);
            list1.Add(double3);
            list1.Add(double6);

            list1.Sort();

            list2.Add(double3);
            list2.Add(double5);
            list2.Add(double6);

            Assert.AreEqual(list2.ToString(), list1.ToString());
        }

        [TestMethod]
        public void AddCharsToAListUnsorted_TestThatListGetsSorted()
        {
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();

            char chara = 'a';
            char chard = 'd';
            char charg = 'g';

            list1.Add(chard);
            list1.Add(chara);
            list1.Add(charg);

            list1.Sort();

            list2.Add(chara);
            list2.Add(chard);
            list2.Add(charg);

            Assert.AreEqual(list2.ToString(), list1.ToString());
        }

        [TestMethod]
        public void AddDecimalsToAListUnsorted_TestThatListGetsSorted()
        {
            CustomList<decimal> list1 = new CustomList<decimal>();
            CustomList<decimal> list2 = new CustomList<decimal>();

            decimal dec1 = new decimal(1.01);
            decimal dec2 = new decimal(2.02);
            decimal dec3 = new decimal(3.03);
            decimal dec4 = new decimal(4.04);

            list1.Add(dec1);
            list1.Add(dec2);
            list1.Add(dec4);
            list1.Add(dec3);

            list1.Sort();

            list2.Add(dec1);
            list2.Add(dec2);
            list2.Add(dec3);
            list2.Add(dec4);

            Assert.AreEqual(list2.ToString(), list1.ToString());
        }
    }
}
 