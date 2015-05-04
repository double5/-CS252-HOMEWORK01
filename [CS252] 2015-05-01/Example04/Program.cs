using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
        }
        static int[] InputGuessNumber = new int[4];
        static bool Correct = false;        
        public static void GuessNumber()
        {
            int[] PCRandomNumer = new int[4];
            Random random = new Random();
            Console.WriteLine("猜數字遊戲，請輸入4組數字輸入");
            for(int i =0; i<=3 ; i++)
            {
                PCRandomNumer[i] = random.Next(0, 10); //4個數字隨機亂數
            }
            //test
            //Console.WriteLine("{0},{1},{2},{3}", PCRandomNumer[0], PCRandomNumer[1], PCRandomNumer[2], PCRandomNumer[3]);
            
            while(Correct == false)
            {
                bool InputFormat = false;  //判斷輸入格式是否有錯誤,initial false
                String [] Sign = new String[4];  //判斷猜對符號 A:猜對且位置對, B:猜對但位置錯, X:都沒猜到
                String Input; //接收Console.ReadLine()的字串
                
                for(int i=0; i<=3; i++) //Initial
                {
                    Sign[i] = "X";
                }
                //for(int i=0,j=1; i<=3; i++,j++)
                //{
                //    Console.WriteLine("請輸入第{0}個數字", j);
                //    InputGuessNumber[i] = int.Parse(Console.ReadLine());
                //}
                Console.WriteLine("請輸入4個0~9的數字, Ex:1,2,3,4");
                Input = Console.ReadLine();
                try
                {
                    InputGuessNumber[0] = int.Parse(Input.Substring(0, 1));
                    InputGuessNumber[1] = int.Parse(Input.Substring(2, 1));
                    InputGuessNumber[2] = int.Parse(Input.Substring(4, 1));
                    InputGuessNumber[3] = int.Parse(Input.Substring(6, 1));
                }
                catch
                {                    
                    Console.WriteLine("Exception: 輸入錯誤");
                    InputFormat = true;
                }
                if(InputFormat == false)
                { 
                    Console.WriteLine("{0},{1},{2},{3}", InputGuessNumber[0], InputGuessNumber[1], InputGuessNumber[2], InputGuessNumber[3]);
                    for (int i = 0; i <= 3;i++ )
                    {

                        for (int j = 0; j <= 3; j++)
                        {
                            if( InputGuessNumber[i] == PCRandomNumer[j] && Sign[i] !="A")
                            {                           
                                Sign[i] = "B";
                            }
                            if (i == j && InputGuessNumber[i] == PCRandomNumer[j])
                            {
                                Sign[i] = "A";                            
                            }
                        }
                    }
                    Console.WriteLine("{0},{1},{2},{3}",Sign[0],Sign[1],Sign[2],Sign[3] );
                    if (Sign[0] == "A" && Sign[1] == "A" && Sign[2] == "A" && Sign[3] == "A")
                        Correct = true;
                    else
                        Correct = false;

                    if (Correct == true)
                    {
                        Console.WriteLine("你猜對了，好棒喔");
                    }
                    else
                    {
                        Console.WriteLine("猜錯了，請再猜");                        
                    }
                }
                else
                {
                    Console.WriteLine("Exception: 請從新輸入");
                    InputFormat = false;
                }
            }
        }
    }
}
