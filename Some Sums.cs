using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line=Console.ReadLine();
            string [] part = line.Split(' ');
            int n = int.Parse(part[0]);
            int a=int.Parse(part[1]);
            int b=int.Parse(part[2]);
            int sum = 0;
            int temp = 0;

            for(int i=1;i<=n;i++)
            {
                var num = new List <int> ();
                foreach(char ch in i.ToString())
                {
                    num.Add((int)Char.GetNumericValue(ch));
                }
                temp = num.Sum();
                if(temp>=a && temp<=b)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
   }
 }
}