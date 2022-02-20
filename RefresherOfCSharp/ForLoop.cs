using System;

namespace RefresherOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i >= 0; i--)
            {
                for(int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
