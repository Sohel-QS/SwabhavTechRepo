using System;
using System.Collections;
using System.Collections.Generic;

namespace SinkDotComGame.Model
{
    class GameHelper
    {
        private string alphabet = "abcdefg";
        private int gridLength = 7;
        private static int gridSize = 49;
        private int[] grid = new int[49];
        private int comCount = 0;

        public bool IsInGuessList(string guess)
        {
            string firstChar = (guess[0].ToString()).ToLower();
            int secondInt = Convert.ToInt32(guess[1]);
            if (guess.Contains(firstChar) && secondInt < 7)
                return true;
            return false;
        }

        public List<string> placeDotCom(int comSize)
        {
            List<string> alphaCells = new List<string>();
            Random random = new Random();

            string temp = null;
            int[] coords = new int[comSize];
            int attempts = 0;
            bool success = false;
            int location = 0;
            int x = 0;
            int row = 0;
            int column = 0;
            int incr = 1;

            comCount++;
            if((comCount % 2)==1)
            {
                incr = gridLength;
            }

            while (!success & attempts++ < 200)
            {
                location = random.Next(0,7) * gridLength;
                success = true;

                while (success && x < comSize)
                {
                    if (grid[location] == 0)
                    {
                        coords[x++] = location;
                        location += incr;
                        if (location >= gridSize)
                        {
                            success = false;
                            continue;
                        }
                        if (x > 0 && (location % gridLength == 0))
                        {
                            success = false;
                            continue;
                        }
                    }

                    else
                        success = false;
                }
            }
            x = 0;

            while (x < comSize)
            {
                grid[coords[x]] = 1;
                row = coords[x] / gridLength;
                column = coords[x] % gridLength;
                temp = alphabet[column].ToString();

                alphaCells.Add(String.Concat(temp, row.ToString()));
                Console.WriteLine(String.Concat(temp, row.ToString()));
                x++;
            }
            return alphaCells;
        }
    }
}
