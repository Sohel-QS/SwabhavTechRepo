using System;

namespace PassingValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            UpdateScoreToZero(score);
            Console.WriteLine("Value of Score {0}", score);
            int[] manyScores = {70,80,90,100};
            UpdateManyScoresToZero(manyScores);

            int index = 0;
            foreach(int scores in manyScores)
            {
                Console.WriteLine("{0} Element in manyScores:{1}", index, scores);
                index += 1;
            }
        }

        private static void UpdateManyScoresToZero(int[] manyScores)
        {
            for (int index = 0; index < manyScores.Length; index++)
            {
                manyScores[index] = 0;
            }
        }

        private static void UpdateScoreToZero(int pscore)
        {
            pscore = 0;
            Console.WriteLine("");
        }
    }
}
