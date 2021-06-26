using System;

namespace DivisoresURI1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int total = n % i;
                if (total == 0)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
