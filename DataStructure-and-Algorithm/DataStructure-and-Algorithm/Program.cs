using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_and_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            MyArrayList arr = new MyArrayList();
            Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);
            arr.Add(1);
            Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);
            for (int i = 0; i < 6; i++)
            {
                arr.Add(i);
            }
            Console.WriteLine("arr当前的容量为：" + arr.Capacity + "  长度为：" + arr.Count);
            Console.WriteLine(arr.Local(6));
            #endregion
        }
    }
}
