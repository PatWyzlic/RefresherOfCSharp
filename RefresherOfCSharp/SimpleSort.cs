using System;
namespace RefresherOfCSharp
{
    public class SimpleSort
    {
        public SimpleSort()
        {
            int[] videoGameScores = { 100, 64, 82, 53, 9 };
            Array.Sort(videoGameScores);
            Array.Reverse(videoGameScores);


            for (int i = 0; i < videoGameScores.Length; i++)
            {
                //Video Games scores highest to lowest
                Console.WriteLine(videoGameScores[i]);
            }
        }

    }
}
