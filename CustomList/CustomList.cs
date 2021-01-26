using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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
            get { return items[i]; }
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
            for (int i = 0; i < this.Capacity; i++)
            {
                if(items[i].Equals(item)) // .equals may be an issue
                {
                    indexOfElement = i;
                    break;
                }
                else
                {
                    removeSuccess = false;
                    return removeSuccess;
                }
            }

            if (indexOfElement == 0 && this.Capacity == 1)
            {
                items2 = new T[0];
                items = items2;
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
                removeSuccess = true;
                return removeSuccess;
            }
            else
            {
                items2 = new T[this.Capacity - 1];
                int j = 0;
                for (int i = 0; i < this.Capacity; i++)
                {
                    if (indexOfElement != i)
                    {
                        items2[j] = items[i];
                        j++;
                    }
                    i++;
                }
                items = items2;
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
                String.Concat(finishedString, this[i]); // may need to change this method
            }

            return finishedString;
        }

        public CustomList<T>  Zip(CustomList<T> b) // needs to be implemented
        {
            return;
        }
    }
}
