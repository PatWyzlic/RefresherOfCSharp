using System;
namespace RefresherOfCSharp
{
    public class ForLoops
    {
        public ForLoops()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
