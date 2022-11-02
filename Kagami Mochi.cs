using System;
 
namespace AtCoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]d = new int[n];
            
            int result = 0;
            for(int i = 0; i < n; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(d);
            
            for(int j=0; j<n; j++)
            {
                int count = 0;
                for (int k=j+1; k<n; k++)
                {
                    if(d[j]==d[k])
                    {
                        count++;
                    }
                }
                j += count;
                result++;
            }
            Console.WriteLine(result);
}
}
}