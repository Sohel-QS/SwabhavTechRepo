using System;

namespace NumberGuesserGame
{
    class NumberGuess
    {
        public static void Main(string[] args)
        {
            Console.Write(">>>Start the Game [y/n]:");
            YesOrNo(UserInput());
        }

        private static void YesOrNo(char inPut)
        {
            while(true)
            {
                if (inPut == 'y')
                    StartNumGuess();
                else if (inPut == 'n')
                {
                    Exit();
                    break;
                }
                else
                {
                    Console.Write(">>>Invalid Input Try Again :");
                    inPut = UserInput();
                }
            }
        }

        private static char UserInput()
        {
            char character = ' ';
            int count = 1;
            while(count != 0)
            {
                try
                {
                    character = char.ToLower(Convert.ToChar(Console.ReadLine()));
                    count = 0;
                    return character;
                }
                catch (System.FormatException)
                {
                    Console.Write(">>>Format Exception Enter Again :");
                    count = 1;
                    continue;
                }
            }
            return character;
        }

        public static void StartNumGuess()
        {
            int radNum = GenerateRandom();
            int noofTries = 0, guessNumber = 0;
            Console.WriteLine("---------- Number Guesser Game ----------");
            Console.WriteLine(radNum);
            while (radNum != guessNumber)
            {
                guessNumber = Guess();
                noofTries += 1;
                if (guessNumber < radNum)
                    Console.WriteLine("Too Low. Try Again!!!");
                else if (guessNumber > radNum)
                    Console.WriteLine("Too High. Try Again!!!");
                else
                    continue;
            }
            Console.WriteLine("Guessed the Number '{0}' in {1} Turns :", radNum, noofTries);
            Console.WriteLine(">>>Game Over!");
            PlayAgain();
        }

        private static int Guess()
        {
            int guessNumber = 0, flag = 1;
            Console.Write("Guess Number :");
            while(flag != 0)
            {
                try
                {
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                    flag = 0;
                }
                catch (System.FormatException)
                {

                    Console.Write(">>>Format Exception Try Again :");
                    continue;
                }
            }
            return guessNumber;
        }

        private static void PlayAgain()
        {
            Console.Write(">>>Play Again [y/n]:");
            YesOrNo(UserInput());
        }

        public static int GenerateRandom()
        {
            Random r = new Random();
            int randomNum = r.Next(1, 100);
            return randomNum;
        }
        public static void Exit()
        {
            Console.WriteLine("      -------- End of Game! --------     ");
        }
    }
}
