using System;

namespace PigGameApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            char startGame = ' ';
            int count = 1;
            Console.Write(">>>Let's Play Pig! [y/n] :");
            while(count != 0)
            {
                startGame = UserInput();
                if (startGame == 'y')
                {//stating game call method PigGame()
                    count = 0;
                    PigGame();
                }
                else if (startGame == 'n')
                {//ending game
                    count = 0;
                    Exit();
                }
                else
                {
                    Console.Write(">>>Invalid Input! Try Again :");
                    count += 1;
                }
            }
        }

        private static char UserInput()
        {
            int count = 1;
            char startGame = ' ';
            while (count != 0)
            {
                try
                {
                    startGame = char.ToLower(Convert.ToChar(Console.ReadLine()));
                    count = 0;
                }
                catch (System.FormatException)
                {
                    Console.Write("Format Exeption Enter Again :");
                    count += 1;
                    continue;
                }
            }
            return startGame;
        }

        private static void Exit()//Ends the Game
        {
            Console.WriteLine("     -------- End of Game! --------     ");
        }

        private static void PigGame()//initialize game
        {
            int turnNo = 0, totalScore = 0, turnScore = 0;
            Console.WriteLine("\n      -------- Pig Game! --------      ");
            
            while (totalScore < 20)
            {
                turnNo += 1;
                Console.WriteLine("\n-->Turn {0}", turnNo);//count the no of turns
                RollOrHold(ref totalScore, ref turnScore);//call for roll or hold method             
            }
            DisplayScores(turnNo, turnScore, totalScore);
        }

        private static void DisplayScores(int turnNo, int turnScore, int totalScore)//dispaly last scores
        {
            Console.WriteLine("Score for Turn: {0}", turnScore);
            Console.WriteLine("Total Score: {0}", totalScore);
            Console.WriteLine("\nYou finished in {0} turns!", turnNo);//prints total no of turns
            Console.WriteLine("\n      -------- Game Over! --------      \n");
            PlayAgain();//call for PlayAgain method to ask for play again
        }

        private static void PlayAgain()//paly again 
        {
            char playAgain;
            Console.Write(">>>Play Again! [y/n] :");
            playAgain = UserInput();//asking to user to play again or exit
            if (playAgain == 'y')//call method PigGame() for playing again 
                PigGame();
            else //ending game
                Exit();
        }
        private static void RollOrHold(ref int totalScore, ref int turnScore)
        {
            Random obj = new Random();
            char rollHold;
            int randomDie = 0, count = 1;
            while(totalScore < 20)
            {
                Console.Write("Roll or Hold? [r/h]:");//asking for roll or hold
                rollHold = UserInput();
                if (rollHold == 'r')
                {
                    randomDie = obj.Next(1, 7);//random no in range 1 to 6 
                    Console.WriteLine("Die: {0}", randomDie);
                    count = 0;
                }
                else if (rollHold == 'h')
                {//hold and print the scores
                    Console.WriteLine("Score for Turn: {0}", turnScore);
                    Console.WriteLine("Total Score: {0}\n", totalScore);
                    turnScore = 0;//making turn score zero
                    count = 0;
                    break;
                }
                else
                {
                    Console.WriteLine(">>>Invalid Input! Try Again :");
                    count += 1;
                    continue;
                }
                if (randomDie == 1)
                {//turn break here and 
                    Console.WriteLine("Turn Over. No Score!");
                    //making all score counts zero
                    turnScore = 0;
                    totalScore = 0;
                    break;
                }
                else
                {
                    turnScore += randomDie;//adding turn score
                    totalScore += randomDie;//adding total score
                }
            }
        }
    }
}
