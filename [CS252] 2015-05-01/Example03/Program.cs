using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();   
        }
        public static void Factorial()
        {
            int Input; //初始化            
            int Total;
            int i; // 暫存
            Console.WriteLine("請輸入非負整數，電腦幫您運算整數之階運算");
            Console.WriteLine("Ex: 您輸入5，則電腦運算結果為1*2*3*4*5 =120");
            Input = Convert.ToInt32(Console.ReadLine());
            Total = Input;
            i = Input-1;
            while (i != 0)
            {
                
                Total = Total * i;
                i--;
            }
            Console.WriteLine("階運算結果為:{0}", Total);
        }
    }
}
