using System;

namespace DotComGameApp.Model
{
    public class SimpleDotComGame
    {
        int[] locationCells;
        int noOfHits = 0;

        public void SetLocationCells(int[] locs)
        {
            locationCells = locs;
        }

        public string CheckYourSelf(string stringGuess)
        {
            int userGuess = Convert.ToInt32(stringGuess);
            string result = "miss";
            int index = Array.IndexOf(locationCells, userGuess);

            foreach(int cell in locationCells)
            {
                if (userGuess == cell)
                {
                    result = "hit";
                    Console.WriteLine(locationCells.Length);
                    locationCells[index] = -1;
                    noOfHits += 1;
                }

                if(noOfHits == locationCells.Length)
                {
                    result = "kill";
                    break;
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
