using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            OddSum();
        }
        public static void OddSum()
        {
            int Input;
            int Sum = 0; //初始化
            Console.WriteLine("請輸入非負整數值，電腦幫您運算所有奇數之和");
            Input = Convert.ToInt32(Console.ReadLine());
            for(int i=1 ; i <= Input; i=i +2)
            {
                Sum = Sum + i;
            }
            Console.WriteLine("奇數之和 = {0}", Sum);
        }
    }
}
