using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevelIndentationApp
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,3];
            EnterValues(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < 3; row++)
                PrintColumns(matrix,row);
        }

        private static void PrintColumns(int[,] matrix, int row)
        {
            for (int column = 0; column < 3; column++)
                Console.Write("{0} ", matrix[row, column]);
            
            Console.Write("\n");
        }

        private static void EnterValues(int[,] matrix)
        {
            for (int row = 0; row < 3; row++)
                ColumnValues(matrix,row);
        }

        private static void ColumnValues(int[,] matrix, int row)
        {
            for (int column = 0; column < 3; column++)
                matrix[row, column] = ++count;
        }
    }
}
