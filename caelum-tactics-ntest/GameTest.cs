namespace CaelumTactics.NTests
{
    [TestFixture]
    public class BoardTests
    {
        private Board board;

        [SetUp]
        public void Setup()
        {
            board = new Board();
        }

        [Test]
        public void AddPiece_ShouldPlacePieceOnBoard()
        {
            var piece = new MockPiece();

            board.AddPiece(piece, 3, 3);

            Assert.That(board.Grid[3, 3], Is.EqualTo(piece));
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

    [TestFixture]
    public class PawnTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var pawn = new Pawn(PieceColor.White);
            Assert.That(pawn.IsValidMove(3, 3, 3, 4, board));
        }
    }

    [TestFixture]
    public class RookTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var rook = new Rook(PieceColor.White);
            Assert.That(rook.IsValidMove(3, 3, 3, 7, board));
        }
    }

    [TestFixture]
    public class KnightTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var knight = new Knight(PieceColor.White);
            Assert.That(knight.IsValidMove(3, 3, 5, 4, board));
        }
    }

    [TestFixture]
    public class BishopTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var bishop = new Bishop(PieceColor.White);
            Assert.That(bishop.IsValidMove(3, 3, 5, 5, board));
        }
    }

    [TestFixture]
    public class QueenTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var queen = new Queen(PieceColor.White);
            Assert.That(queen.IsValidMove(3, 3, 3, 7, board));
        }
    }

    [TestFixture]
    public class KingTests
    {
        [Test]
        public void ValidMove_ShouldReturnTrue()
        {
            var board = new Board();
            var king = new King(PieceColor.White);
            Assert.That(king.IsValidMove(3, 3, 4, 4, board));
        }
    }
}
