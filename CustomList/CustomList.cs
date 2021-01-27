﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        // Step One: Member Variables, Properties, Constructor
        private int count;
        private T[] items;



        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; } //may need to change this to a different method
        }

        public CustomList()
        {
            items = new T[4];
        }
           
        // Step Two: Indexer
        public T this[int i]
        {
            set { items[i] = value;  }
            get { return items[i]; } // initalizes to array of size 4
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        // Step Three: Add Method
        public void Add(T item)
        {
            if(count == this.Capacity)
            {
                T[] items2 = new T[this.Capacity * 2];

                for(int i = 0; i < this.Capacity; i++)
                {
                    items2[i] = items[i];
                }
                items = items2; //this line may cause problems

                items[count] = item;
                count++;
            }
            else
            {
                items[count] = item;
                count++;
            }
        }

        public bool Remove(T item)
        {
            int indexOfElement = this.Capacity;
            bool removeSuccess;
            T[] items2;
            for (int i = 0; i < this.count; i++)
            {
                if(items[i].Equals(item)) // .equals may be an issue
                {
                    indexOfElement = i;
                    break;
                }
            }

            if(indexOfElement == this.Capacity)
            {
                removeSuccess = false;
                return removeSuccess;
            }
            else if (indexOfElement == 0 && this.count == 1)
            {
                items2 = new T[4];
                items = items2;
                count--;
                removeSuccess = true;
                return removeSuccess;
            }
            else if (indexOfElement == this.Capacity - 1 && this.Capacity > 1)
            {
                items2 = new T[this.Count];
                for (int i = 0; i < this.Capacity - 1; i++)
                {
                    items2[i] = items[i];
                }
                items = items2;
                count--;
                removeSuccess = true;
                return removeSuccess;
            }
            else
            {
                items2 = new T[this.Capacity - 1];
                int j = 0;
                for (int i = 0; i < this.Capacity; i++)
                {
                    if (indexOfElement == i)
                    {
                        continue;
                    }
                    else
                    {
                        items2[j] = items[i];
                        j++;
                    }
                }
                items = items2;
                count--;
                removeSuccess = true;
                return removeSuccess;
            }

        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> list3 = new CustomList<T>();

            for (int i = 0; i < a.Count; i++)
            {
                list3.Add(a[i]);
            }

            for (int i = 0; i < b.Count; i++)
            {
                list3.Add(b[i]);
            }

            return list3;
        }

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b) // needs remove to be implemented for this to work
        {
            CustomList<T> list3 = new CustomList<T>();

            for (int i = 0; i < a.Count; i++)
            {
                list3.Add(a[i]);
            }

            for (int i = 0; i < b.Count; i++)
            {
                list3.Remove(b[i]);
            }

            return list3;
        }

        public override string ToString() //need to code this out
        {
            string finishedString = "";

            for(int i = 0; i < this.Count; i++)
            {
                //String.Concat(finishedString, this[i]); // may need to change this method
                finishedString = finishedString + this[i];
            }

            return finishedString;
        }

        public CustomList<T> Zip(CustomList<T> b) // void Zip(CustomList<T> b) //  // might need to return a list
        { //listToZipIn
            CustomList<T> list3 = new CustomList<T>();
            if(this.Count <= b.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    list3.Add(this[i]);
                    list3.Add(b[i]);
                }

                for (int i = this.Count; i < b.Count; i++)
                {
                    list3.Add(b[i]);
                }
                return list3;
            }
            else
            {
                for (int i = 0; i < b.Count; i++)
                {
                    list3.Add(this[i]);
                    list3.Add(b[i]);
                }

                for (int i = b.Count; i < this.Count; i++)
                {
                    list3.Add(this[i]);
                }
                return list3;
            }
        }
    }
}
