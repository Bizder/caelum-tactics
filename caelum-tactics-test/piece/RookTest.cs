namespace CaelumTactics.Tests
{
    [TestClass]
    public class RookTest
    {
        private Board board;
        private Rook rook;

        [TestInitialize]
        public void setup()
        {
            board = new Board();
            rook = new Rook(PieceColor.White, new Position(3, 3));
        }

        [TestMethod]
        public void ValidHorizontalMove_ShouldReturnTrue()
        {
            Assert.IsTrue(rook.IsValidMove(new Position(3, 3), new Position(3, 7), board));
        }

        [TestMethod]
        public void ValidVerticalMove_ShouldReturnTrue()
        {
            Assert.IsTrue(rook.IsValidMove(new Position(3, 3), new Position(7, 3), board));
        }

        [TestMethod]
        public void InvalidMove_ShouldReturnFalse()
        {
            Assert.IsFalse(rook.IsValidMove(new Position(3, 3), new Position(4, 4), board));
        }
    }
}
