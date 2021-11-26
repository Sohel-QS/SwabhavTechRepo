using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Model
{
    public class Board
    {
        private Cell[] _cells = new Cell[9];

        public Cell[] Cells 
        { 
            get => _cells; 
        }

        public Board()
        {
            for(int index = 0; index<9; index++)
            {
                _cells[index] = new Cell();
            }
        }

        public bool IsBoardFull()
        {
            int flag = 0;
            foreach(Cell cell in _cells)
            {
                if (cell.IsMarked())
                {
                    flag += 1;
                }
            }
            return flag == _cells.Length;
        }

        public bool IsBoardEmpty()
        {
            int flag = 0;
            foreach (Cell cell in _cells)
            {
                if (!cell.IsMarked())
                {
                    flag += 1;
                }
            }
            return flag == _cells.Length;
        }

        public void MarkCellOfBoardAtSpecificLocation(int location, MarkType mark)
        {
            _cells[location - 1].Mark = mark;
        }

        public bool CheckSpecificLocationMarkedOrNot(int location)
        {
            return _cells[location - 1].IsMarked();
        }
    }
}
