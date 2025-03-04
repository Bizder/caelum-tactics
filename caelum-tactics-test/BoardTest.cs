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
            var piece = new MockPiece(PieceColor.White, new Position(3, 3));
            var position = new Position(3, 3);

            board.AddPiece(piece, position);

            Assert.AreEqual(piece, board.GetPieceAt(position));
        }

        [TestMethod]
        public void MovePiece_ValidMove_ShouldMovePiece()
        {
            var piece = new MockPiece(PieceColor.White, new Position(4, 4));
            var start = new Position(4, 4);
            var end = new Position(6, 6);

            board.AddPiece(piece, start);
            board.MovePiece(start, end);

            Assert.AreEqual(piece, board.GetPieceAt(end));
            Assert.IsNull(board.GetPieceAt(start));
        }

        [TestMethod]
        public void AddPiece_InvalidField_ShouldRaiseException()
        {
            // TODO
            Assert.Inconclusive();
        }

        [TestMethod]
        public void MovePiece_InvalidMove_ShouldRaiseException()
        {
            // TODO
            Assert.Inconclusive();
        }

        private class MockPiece : Piece
        {
            public MockPiece(PieceColor color, Position position) : base(color, position) { }

            public override bool IsValidMove(Position start, Position end, Board board)
            {
                return true;
            }
        }
    }
}
