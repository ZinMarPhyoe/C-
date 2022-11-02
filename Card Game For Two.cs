using System;
using System.Linq;

namespace AtCoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line=Console.ReadLine();
            int [] part=line.Split(' ').Select(int.Parse).ToArray();
            int result =0;
            int alice = 0;
            int bob = 0;
            Array.Sort(part);
            Array.Reverse(part);

           for (int i = 0; i<n; i++)
            {
                if(i%2==0)
                {
                    alice+=part[i];
                }
                else
                {
                    bob+=part[i];
                }
            }
            result = Math.Abs(alice - bob);
           Console.WriteLine(result);
}
}
}
            