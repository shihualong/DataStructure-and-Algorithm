using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_and_Algorithm
{
    class MyArrayList
    {
        private const int defaultCapacity = 4;
        private int count;
        private static readonly object[] emptyCapacity = new object[0];
        private object[] items;

        public MyArrayList()
        {
            items = emptyCapacity;
        }
        public MyArrayList(int c)
        {
            items = new object[c];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                    throw new ArgumentOutOfRangeException("index", "OutOfRange");
                return items[index];
            }
            set
            {
                if (index < 0 || index >= this.count)
                    throw new ArgumentOutOfRangeException("index", "OutOfRange");
                items[index] = value;
            }
        }
        public int Capacity
        {
            get
            {
                return items.Length;
            }
            set
            {
                if (value < this.count)
                {
                    Console.WriteLine("Capacity:{0} -- Count :{1}", value, count);
                    throw new ArgumentOutOfRangeException("Capacity", "OutOfRange");
                }
                if (value != this.items.Length)
                {
                    if (value > 0)
                    {
                        object[] destinationArray = new object[value];
                        if (this.count > 0)
                        {
                            Array.Copy(items, 0, destinationArray, 0, count);
                        }
                        items = destinationArray;
                    }
                    else
                    {
                        items = new object[defaultCapacity];
                    }
                }

            }
        }

        public int Add(object v)
        {
            if (this.count == this.items.Length)
            {
                EnsureCapacity(count + 1);
            }
            this.items[count] = v;
            int tempCount = count;
            count = tempCount + 1;
            return tempCount;


        }
        private void EnsureCapacity(int v)
        {
            if (this.items.Length < v)
            {
                int num = (this.items.Length == 0) ? defaultCapacity : (this.items.Length * 2);

                this.Capacity = num;
            }
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= this.count)
                throw new ArgumentOutOfRangeException("index", "OutOfRange");

            count--;
            if (index < count)
            {
                Array.Copy(items, index + 1, items, index, this.count - index);
            }
            this.items[index] = null;
        }
        public void Insert(int index,object v)
        {
            if (index < 0 || index > this.count)
                throw new ArgumentOutOfRangeException("index", "OutOfRange");
            if (this.count == items.Length)
                EnsureCapacity(count + 1);
            if (index < count)
            {
                Array.Copy(items, index, items, index + 1, count - index);
            }
            this.items[index] = v;
        }

        public void TrimToCount()
        {
            this.Capacity = count;
        }
        public object Local(int index)
        {
            try
            {
                if (index < 0 || index >= this.count)
                    throw new ArgumentOutOfRangeException("index", "outofRange");
                return items[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("Count:{0},Capacity:{1},LastIndex:{2}",count,Capacity,count - 1);
                return null;
            }
          
        }
    }
}
