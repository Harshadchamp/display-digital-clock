using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scale = int.Parse(Console.ReadLine());
            var scale = 2;
            while (true)
            {
                var input = DateTime.Now.ToString();
                input = input.Substring(9);
                input = input.Substring(0, 8);
                //var input = DateTime.Now.Hour.ToString();
                PrintLine(input, "", "14", "", 2);
                PrintLine(input, "1237", "", "56", scale);
                PrintLine(input, "1237", "170", "56", 2);
                PrintLine(input, "134579", "", "2", scale);
                PrintLine(input, "134579", "147", "2", 2);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ReadKey();
        }

        static void PrintLine(string input, string leftMatch, string middleMatch, string rightMatch, int scale)
        {
            for (int i = 1; i < scale; i++)
            {
                foreach (var c in input)
                {
                    PrintDigitLine(c, leftMatch, '|', 1);
                    PrintDigitLine(c, middleMatch, '_', scale);
                    PrintDigitLine(c, rightMatch, '|', 1);
                }
                Console.Write("\n");
            }
        }

        private static void PrintDigitLine(char digit, string match, char charToPrint, int n)
        {
            for (int i = 0; i < n; i++) Console.Write(match.Contains(digit) || match == "" ? ' ' : charToPrint);
        }
        
    }
   
}
