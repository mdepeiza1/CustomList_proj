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
    }
}
