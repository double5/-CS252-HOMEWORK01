using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static int Input;
        static void Main(string[] args)
        {
            Guess();
        }
        public static void Guess()
        {
            bool GuessTrue =false;
            
            do
            {
                Console.WriteLine("請輸入0~100");
                try
                {
                    Input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Exception: 輸入不正確，請輸入數值");
                }
                if (Input >= 0 && Input <= 100)
                {
                    Console.WriteLine("輸入正確");
                    GuessTrue = true;
                }
                else
                {
                    GuessTrue = false;                    
                }
            }
            while (GuessTrue == false);

        }
    }
}
