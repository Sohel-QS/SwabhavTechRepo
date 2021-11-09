using System;
using DotComGameApp.Model;

namespace DotComGameApp
{
    class SimpleDotGameTest
    {
        static void Main(string[] args)
        {
            int noOfGuesses = 0;
            bool isAlive = true;

            SimpleDotComGame testGame = new SimpleDotComGame();
            GameHelper helper = new GameHelper();
            Random ran = new Random();

            int randomNum = ran.Next(1, 4) * 3;

            int[] locations = { randomNum, randomNum + 1, randomNum + 2 };
            testGame.SetLocationCells(locations);

            while(isAlive == true)
            {
                string guess = helper.getUserInput("Enter a Number");
                string gameResult = testGame.CheckYourSelf(guess);

                noOfGuesses += 1;

                if(gameResult.Equals("kill"))
                {
                    isAlive = false;
                    Console.WriteLine("You took {0} guesses", noOfGuesses);
                }
            }
        }
    }
}
