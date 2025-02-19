using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaelumTactics.Tests
{
    [TestClass]
    public class BoardTests
    {
        private Board board;

        [TestInitialize]
        public void Setup()
        {
            board = new Board();
        }

        [TestMethod]
        public void AddPiece_ShouldPlacePieceOnBoard()
        {
            var piece = new MockPiece();

            board.AddPiece(piece, 3, 3);

            Assert.AreEqual(piece, board.Grid[3, 3]);
        }

        private class MockPiece : Piece
        {
            public MockPiece() : base(PieceColor.White) { }

            public override bool IsValidMove(int startX, int startY, int endX, int endY, Board board)
            {
                return true;
            }
        }
    }

    [TestClass]
    public class PawnTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var pawn = new Pawn(PieceColor.White);
            Assert.IsTrue(pawn.IsValidMove(3, 3, 3, 4, board));
        }
    }

    [TestClass]
    public class RookTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var rook = new Rook(PieceColor.White);
            Assert.IsTrue(rook.IsValidMove(3, 3, 3, 7, board));
        }
    }

    [TestClass]
    public class KnightTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var knight = new Knight(PieceColor.White);
            Assert.IsTrue(knight.IsValidMove(3, 3, 5, 4, board));
        }
    }

    [TestClass]
    public class BishopTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var bishop = new Bishop(PieceColor.White);
            Assert.IsTrue(bishop.IsValidMove(3, 3, 5, 5, board));
        }
    }

    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var queen = new Queen(PieceColor.White);
            Assert.IsTrue(queen.IsValidMove(3, 3, 3, 7, board));
        }
    }

    [TestClass]
    public class KingTests
    {
        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var king = new King(PieceColor.White);
            Assert.IsTrue(king.IsValidMove(3, 3, 4, 4, board));
        }
    }
}