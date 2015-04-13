using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s = "two";

            switch (s)
            {
                case "one": //if(s == "one")
                    Console.WriteLine("1");
                    break;
                case "two": //if(s == "two")
                    Console.WriteLine("2");
                    break;
                default: //else
                    break;
            }
            */

            string input = "";
            uint inputNum;

            while (uint.TryParse(input, out inputNum) == false)
            {
                Console.WriteLine("正の整数を入力してください。");
                input = Console.ReadLine();
            }

            switch (inputNum)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("入力されたのは1～3以外です。");
                    break;
            }

            Console.ReadLine();
        }
    }
}
