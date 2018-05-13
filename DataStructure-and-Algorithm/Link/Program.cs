using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link
{
    class Program
    {
        static void Main(string[] args)
        {
            CirculationLinkList lst = new CirculationLinkList();
            #region Test
            //lst.Add(1);
            //lst.Add(2);
            //lst.Add(3);
            //lst.Add(4);
            //lst.Add(5);
            //lst.Add(6);

            //Console.WriteLine(lst.ToString());

            //Console.WriteLine(lst.Current.ToString());


            //lst.RemoveCurrNode();
            //Console.WriteLine(lst.ToString());

            //lst.Move(2);
            //Console.WriteLine(lst.Current.ToString());
            //Console.WriteLine(lst.ToString());
            #endregion
            #region 约瑟夫
            string s = string.Empty;
            Console.WriteLine("请输出总数：");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("每次报到第几");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("开始报数");
            for (int i = 1; i <= count; i++)
            {
                lst.Add(i);
            }
            Console.WriteLine(lst.ToString());

            while (lst.Count > 15)
            {
                lst.Move(m - 1);
                s += lst.Current.ToString() + "   ";
                lst.RemoveCurrNode();
                Console.WriteLine(lst.Current + "开始报数");
            }
            Console.WriteLine("被扔入大海的人为：" + s );

            #endregion
            Console.ReadLine();
        }
    }
}
