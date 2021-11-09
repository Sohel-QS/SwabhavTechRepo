using System;
using System.Collections;
using System.Collections.Generic;

namespace SinkDotComGame.Model
{
    class DotComBust
    {
        private GameHelper helper = new GameHelper();
        private List<DotCom> dotComList = new List<DotCom>();
        private int numOfGuess = 0;

        private void SetUpGame()
        {
            DotCom one = new DotCom();
            DotCom two = new DotCom();
            DotCom three = new DotCom();

            one.SetName("Pets.com");
            two.SetName("eToys.com");
            three.SetName("Go2.com");

            dotComList.Add(one);
            dotComList.Add(two);
            dotComList.Add(three);

            Console.WriteLine("Your goal is to sink three Dot Coms.\n{0}{1}{2}",
                one.GetName(), two.GetName(), three.GetName());
            Console.WriteLine("Try to Sink them all in fewest number of Guesses");

            foreach(DotCom dotCom in dotComList)
            {
                List<string> newLocation = helper.placeDotCom(3);
                dotCom.SetLocationCells(newLocation);
            }
        }

        private void StartPlaying()
        {
            while(dotComList.Count != 0)
            {
                string userGuess = UserInput("Enter a guess :");
                CheckUserGuess(userGuess);
            }
            FinishGame();
        }

        private void FinishGame()
        {
            Console.WriteLine("All Dot Coms are dead! Your stock is now worthless.");
            if (numOfGuess <= 18)
            {
                Console.WriteLine("It only took you {0} guesses.", numOfGuess);
                Console.WriteLine("You got out before your options Sank.");
            }
            else
            {
                Console.WriteLine("Took you long Enough {0} guesses.", numOfGuess);
                Console.WriteLine("Fish are dancing with your options");
            }
        }

        private void CheckUserGuess(string userGuess)
        {
            numOfGuess++;

            string result = "miss";

            foreach(DotCom dotCom in dotComList)
            {
                result = dotCom.CheckYourSelf(userGuess);
                if (result.Equals("hit"))
                    break;
                if (result.Equals("kill"))
                {
                    dotComList.Remove(dotCom);
                    break;
                }
            }

            Console.WriteLine(result);
        }

        public string UserInput(string str)
        {
            Console.Write("\n"+str);
            string guess = Console.ReadLine();
            try
            {
                if (guess.Length != 2)
                    throw new Exception("Entered Null or Invalid Guess Try Again :");
                try
                {
                    helper.IsInGuessList(guess);
                }
                catch(FormatException fe)
                {
                    UserInput(fe.Message + " Try Again :");
                }
            }
            catch(Exception ex)
            {
                UserInput(ex.Message);
            }
            return guess;
        }

        static void Main(string[] args)
        {
            DotComBust game = new DotComBust();
            game.SetUpGame();
            game.StartPlaying();
        }
    }
}
