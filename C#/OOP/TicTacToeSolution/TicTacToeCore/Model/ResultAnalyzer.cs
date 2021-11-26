using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Model
{
    public class ResultAnalyzer
    {
        private Board _board = new Board();

        ResultType result = ResultType.NoResult;

        public Board Board 
        { 
            get => _board; 
            set => _board = value; 
        }

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public ResultType AnalyzeResult()
        {
            if(CheckRow() || CheckColumn() || CheckDiagonal())
            {
                result = ResultType.Win;
            }
            else if(_board.IsBoardFull())
            {
                result = ResultType.Draw;
            }
            return result;
        }

        public bool CheckDiagonal()
        {
            bool firstDiagonal = _board.Cells[0].Mark == _board.Cells[4].Mark && _board.Cells[4].Mark == _board.Cells[8].Mark;
            bool secondDiagonal = _board.Cells[2].Mark == _board.Cells[4].Mark && _board.Cells[4].Mark == _board.Cells[6].Mark;

            return firstDiagonal || secondDiagonal;
        }

        public bool CheckColumn()
        {
            bool firstColumn = _board.Cells[0].Mark == _board.Cells[3].Mark && _board.Cells[3].Mark == _board.Cells[6].Mark;
            bool secondColumn = _board.Cells[1].Mark == _board.Cells[4].Mark && _board.Cells[4].Mark == _board.Cells[7].Mark;
            bool thirdColumn = _board.Cells[2].Mark == _board.Cells[5].Mark && _board.Cells[5].Mark == _board.Cells[8].Mark;

            return firstColumn || secondColumn || thirdColumn;
        }

        public bool CheckRow()
        {
            bool firstRow = _board.Cells[0].Mark == _board.Cells[1].Mark && _board.Cells[1].Mark == _board.Cells[2].Mark;
            bool secondRow = _board.Cells[3].Mark == _board.Cells[4].Mark && _board.Cells[4].Mark == _board.Cells[5].Mark;
            bool thirdRow = _board.Cells[6].Mark == _board.Cells[7].Mark && _board.Cells[7].Mark == _board.Cells[8].Mark;

            return firstRow || secondRow || thirdRow;
        }
    }
}
