using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame();       
        }
        static int IGuess;

        public static void GuessGame()
        {
            int PCGuess;
            Random random = new Random();
            PCGuess = random.Next(1,4);

            Console.WriteLine("請輸入剪刀(1)、石頭(2)、布(3)");
            IGuess = Convert.ToInt32(Console.ReadLine());
            if(IGuess == PCGuess)
            {
                Console.WriteLine("我猜:{0}", IGuess);
                Console.WriteLine("電腦猜:{0}", PCGuess);
                Console.WriteLine("平手");
            }
            else if (((IGuess == 1) && (PCGuess == 3)) || ((IGuess == 2) && (PCGuess == 1)) || ((IGuess == 3) && (PCGuess == 2)))
            {
                Console.WriteLine("我猜:{0}", IGuess);
                Console.WriteLine("電腦猜:{0}", PCGuess);
                Console.WriteLine("我贏");
            }
            else if (((IGuess == 1) && (PCGuess == 2)) || ((IGuess == 2) && (PCGuess == 3)) || ((IGuess == 3) && (PCGuess == 1)))
            {
                Console.WriteLine("我猜:{0}", IGuess);
                Console.WriteLine("電腦猜:{0}", PCGuess);  
                Console.WriteLine("電腦贏");
            }
            else
            {
                Console.WriteLine("我猜:{0}", IGuess);
                Console.WriteLine("你亂出XDD");
            }

        }
    }
}
