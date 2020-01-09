using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "010101111", "000001001", "010011110", "010011011", "000111001", "010110011", "010110111", "010001001", "010111111", "010111011" };
            while (!Console.KeyAvailable)
            {
                int n1 = DateTime.Now.Hour;
                int n2 = DateTime.Now.Minute;
                int n3 = DateTime.Now.Second;
                string s1 = "";
                string s2 = "";
                string s3 = "";
                Class1 c = new Class1();
                s1 = s1 + (c.First(s[n1 / 10].Substring(0, 3)));
                s1 = s1 + (c.First(s[n1 % 10].Substring(0, 3)));
                s1 = s1 + " ";
                s1 = s1 + (c.First(s[n2 / 10].Substring(0, 3)));
                s1 = s1 + (c.First(s[n2 % 10].Substring(0, 3)));
                s1 = s1 + " ";
                s1 = s1 + (c.First(s[n3 / 10].Substring(0, 3)));
                s1 = s1 + (c.First(s[n3 % 10].Substring(0, 3)));
                s2 = s2 + (c.Middle(s[n1 / 10].Substring(3, 6)));
                s2 = s2 + (c.Middle(s[n1 % 10].Substring(3, 6)));
                s2 = s2 + ".";
                s2 = s2 + (c.Middle(s[n2 / 10].Substring(3, 6)));
                s2 = s2 + (c.Middle(s[n2 % 10].Substring(3, 6)));
                s2 = s2 + ".";
                s2 = s2 + (c.Middle(s[n3 / 10].Substring(3, 6)));
                s2 = s2 + (c.Middle(s[n3 % 10].Substring(3, 6)));
                s3 = s3 + (c.Last(s[n1 / 10].Substring(6)));
                s3 = s3 + (c.Last(s[n1 % 10].Substring(6)));
                s3 = s3 + ".";
                s3 = s3 + (c.Last(s[n2 / 10].Substring(6)));
                s3 = s3 + (c.Last(s[n2 % 10].Substring(6)));
                s3 = s3 + ".";
                s3 = s3 + (c.Last(s[n3 / 10].Substring(6)));
                s3 = s3 + (c.Last(s[n3 % 10].Substring(6)));
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            //Console.ReadKey();
        }
    }
}
