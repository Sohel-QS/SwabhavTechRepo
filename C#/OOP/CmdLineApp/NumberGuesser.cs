using System;
class NumberGuesser
{
    public static int GenerateRandom()
    {
        Random r = new Random();
        int RandomNum = r.Next(1, 100);
        return RandomNum;
    }
    public static int NumGuess()
    {
        int radNum = GenerateRandom();
        int noofTries = 0, guessNumber = 0;
        Console.WriteLine(radNum);
        while(radNum != guessNumber)
        {
            noofTries += 1;
            Console.WriteLine("-------- Guess Number --------");
            guessNumber = Convert.ToInt32(Console.ReadLine());
            if (guessNumber < radNum)
                Console.WriteLine("Too Low");
            else if (guessNumber > radNum)
                Console.WriteLine("Too High");
            else
                continue;
        }
        return noofTries;
    }
    public static void StartGame()
    {
        int userChoice = 0, radNum = 0,triesResult = 0;
        while (userChoice != 3)
        {
            Console.WriteLine("-------- Enter Valid Choice --------\n1)New Guess\n2)Exit");
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice)
            {
                case 1:
                    triesResult = NumGuess();
                    Console.WriteLine("Got the Correct Number After {0} Tries", triesResult);
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Console.WriteLine("-------- Invalid Choice --------");
                    break;
            }
        }
    }
    public static void Exit()
    {
        Console.WriteLine("-------- Want To Exit [y/n] --------");
        string conf= Console.ReadLine();
        if (conf == "y")
            Console.WriteLine("-------- Bye --------");
        else
            StartGame();
    }
    public static void Main()
    {
        string choice;
        Console.WriteLine("-------- Number Guesser --------");
        Console.WriteLine("-------- Start Game [y/n] --------");
        choice = Console.ReadLine();
        if (choice == "y")
            StartGame();
        else
            Exit();
    }
}

