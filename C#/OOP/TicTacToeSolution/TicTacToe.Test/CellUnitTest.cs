using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore.Model;

namespace TicTacToe.Test
{
    [TestClass]
    public class CellUnitTest
    {

        private Cell _cell = new Cell();

        [TestMethod]
        public void Test_CellIsCreatedMarkHasToBeEmpty()
        {
            Assert.AreEqual(_cell.Mark, MarkType.Empty);
        }

        [TestMethod]
        public void Test_IsCellIsAlreadyMarked()
        {
            Assert.IsFalse(_cell.IsMarked());
        }

        [TestMethod]
        public void Test_ShouldBeAbleToMarkXorO()
        {
            _cell.Mark = MarkType.X;
            Assert.IsTrue(_cell.IsMarked());
        }
        [TestMethod]
        public void Test_ShouldXThrowExceptionIfMarkedTwice()
        {
            try
            {
                _cell.Mark = MarkType.X;
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Cell is Already Marked");
            }
        }
    }

    [TestClass]
    public class BoardUnitTest
    {
        private Board _board = new Board();
        [TestMethod]
        public void Test_CheckIfBoardIsFull()
        {
            Assert.IsFalse(_board.IsBoardFull());
        }

        [TestMethod]
        public void Test_CheckIfBoardIsEmpty()
        {
            Assert.IsTrue(_board.IsBoardEmpty());
        }

        [TestMethod]
        public void Test_MarkBoardAtSpecificLocation_WithX_or_O()
        {
            _board.MarkCellOfBoardAtSpecificLocation(3,MarkType.X);
            Assert.IsTrue(_board.CheckSpecificLocationMarkedOrNot(3));

            _board.MarkCellOfBoardAtSpecificLocation(5, MarkType.O);
            Assert.IsTrue(_board.CheckSpecificLocationMarkedOrNot(5));
        }

        [TestMethod]
        public void Test_ExceptionWhenBoardCellMarkedTwice()
        {
            try
            {
                _board.MarkCellOfBoardAtSpecificLocation(3, MarkType.X);
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Cell is Already Marked");
            }
        }
    }

    [TestClass]
    public class ResultAnalyzerUnitTest
    {
        private ResultAnalyzer _result;
        private Board _board = new Board();
        [TestMethod]
        public void Test_CheckRowResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(3, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(1, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(2, MarkType.X);

            _result = new ResultAnalyzer(_board);

            Assert.IsTrue(_result.CheckRow());
        }

        [TestMethod]
        public void Test_CheckColumnResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(9, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(6, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(3, MarkType.X);

            _result = new ResultAnalyzer(_board);

            Assert.IsTrue(_result.CheckColumn());
        }

        [TestMethod]
        public void Test_CheckDiagonalResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(1, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(5, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(9, MarkType.X);

            _result = new ResultAnalyzer(_board);

            Assert.IsTrue(_result.CheckDiagonal());
        }

        [TestMethod]
        public void Test_CheckWinResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(1, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(5, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(9, MarkType.X);

            _result = new ResultAnalyzer(_board);

            Assert.AreEqual(_result.AnalyzeResult(), ResultType.Win);
        }
        [TestMethod]
        public void Test_CheckDrawResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(1, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(2, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(3, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(4, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(5, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(6, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(7, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(8, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(9, MarkType.X);

            _result = new ResultAnalyzer(_board);

            Assert.AreEqual(_result.AnalyzeResult(), ResultType.Draw);
        }
        [TestMethod]
        public void Test_CheckNoResult()
        {
            _board.MarkCellOfBoardAtSpecificLocation(1, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(2, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(3, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(4, MarkType.O);
            _board.MarkCellOfBoardAtSpecificLocation(5, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(6, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(7, MarkType.X);
            _board.MarkCellOfBoardAtSpecificLocation(8, MarkType.O);

            _result = new ResultAnalyzer(_board);

            Assert.AreEqual(_result.AnalyzeResult(), ResultType.NoResult);
        }
    }
    [TestClass]
    public class GameUnitTest
    {
        private Game _game;
        private ResultAnalyzer _analyzer;
        private Board _board = new Board();
        Player[] _players = new Player[2];
        [TestMethod]
        public void Test_NoResultStatus()
        {
            _players[0] = new Player("Sohel", MarkType.X);
            _players[1] = new Player("Chinmay", MarkType.O);

            _analyzer = new ResultAnalyzer(_board);

            _game = new Game(_players, _board, _analyzer);

            Assert.AreEqual(ResultType.NoResult, _game.GetStatus());

        }
        [TestMethod]
        public void Test_DrawResultStatus()
        {
            _players[0] = new Player("Sohel", MarkType.X);
            _players[1] = new Player("Chinmay", MarkType.O);

            _analyzer = new ResultAnalyzer(_board);

            _game = new Game(_players, _board, _analyzer);

            _game.Play(2);
            _game.Play(1);
            _game.Play(5);
            _game.Play(3);
            _game.Play(6);
            _game.Play(4);
            _game.Play(7);
            _game.Play(8);
            _game.Play(9);


            Assert.AreEqual(ResultType.Draw, _game.GetStatus());

        }
        [TestMethod]
        public void Test_ArePlayersSwapping()
        {
            _players[0] = new Player("Sohel", MarkType.X);
            _players[1] = new Player("Chinmay", MarkType.O);

            _analyzer = new ResultAnalyzer(_board);

            _game = new Game(_players, _board, _analyzer);

            Assert.AreEqual("Sohel", _game.GetCurrentPlayer().Name);

            _game.Play(8);

            Assert.AreEqual("Chinmay", _game.GetCurrentPlayer().Name);

        }

        [TestMethod]
        public void Test_CheckIfCellIsMarked()
        {
            _players[0] = new Player("Sohel", MarkType.X);
            _players[1] = new Player("Chinmay", MarkType.O);

            _analyzer = new ResultAnalyzer(_board);

            _game = new Game(_players, _board, _analyzer);

            _game.Play(5);

            Assert.IsTrue(_board.CheckSpecificLocationMarkedOrNot(5));
        }

        [TestMethod]
        public void Test_CheckWinStatus()
        {
            _players[0] = new Player("Sohel", MarkType.X);
            _players[1] = new Player("Chinmay", MarkType.O);

            _analyzer = new ResultAnalyzer(_board);

            _game = new Game(_players, _board, _analyzer);

            _game.Play(5);
            _game.Play(3); 
            _game.Play(1);
            _game.Play(6);
            _game.Play(7);
            _game.Play(9);

            Assert.AreEqual(ResultType.Win, _game.GetStatus());
        }
    }
}
