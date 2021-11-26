using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Model
{
    public class Game
    {
        private Player[] _players = new Player[2];
        private Board _board = new Board();
        private ResultAnalyzer _analyzer;
        private ResultType _status = ResultType.NoResult;
        private Player _currentPlayer;
        private int _index = 0;

        public Game(Player[] players, Board board, ResultAnalyzer analyzer)
        {
            if(players[0].Mark == players[1].Mark)
            {
                throw new Exception("Players Cannot Have Same Marks");
            }
            this._players = players;
            this._board = board;
            this._analyzer = analyzer;
            _currentPlayer = players[0];
        }

        public void Play(int location)
        {
            if(_index%2 == 0)
            {
                _board.MarkCellOfBoardAtSpecificLocation(location, _currentPlayer.Mark);
                _index = 1;
                this._currentPlayer = _players[_index];
            }
            else
            {
                _board.MarkCellOfBoardAtSpecificLocation(location, _currentPlayer.Mark);
                _index = 0;
                this._currentPlayer = _players[_index];
            }
            _status = _analyzer.AnalyzeResult();
        }
        public ResultType GetStatus()
        {
            return _status;
        }

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public Player GetPreviousPlayer()
        {
            if(_currentPlayer == _players[0])
            {
                return _players[1];
            }
            return _players[0];
        }
    }
}
