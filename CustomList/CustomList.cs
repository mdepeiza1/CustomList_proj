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
            if(count == items.Length)
            {
                T[] items2 = new T[items.Length * 2];

                for(int i = 0; i < items.Length; i++)
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
            int indexOfElement = items.Length;
            bool removeSuccess;
            T[] items2 = new T[0];
            for (int i = 0; i < items.Length; i++)
            {
                if(items[i].Equals(item)) // .equals may be an issue
                {
                    indexOfElement = i;
                    break;
                }
                else
                {
                    removeSuccess = false;
                }
            }

            if (indexOfElement == 0 && items.Length == 1)
            {
                items = items2;
                removeSuccess = true;
            }
            else if (indexOfElement == items.Length - 1 && items.Length > 1)
            {

            }

            for(int i = indexOfElement; i < item.Length-1; i++)
            {

            }
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> list3 = new CustomList<T>();

            for (int i = 0; i < b.Count; i++)
            {
                list3.Add(a[i]);
            }

            for (int i = 0; i < b.Count; i++)
            {
                list3.Add(b[i]);
            }

            return list3;
        }

        public override string ToString()
        {
            string finishedString;

            for(int i = 0; i < this.Count; i++)
            {
                finishedString + this[i];
            }

            return 
        }
    }
}
