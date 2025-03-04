namespace CaelumTactics.Tests
{
    [TestClass]
    public class BishopTest
    {
        private Board board;
        private Bishop bishop;

        [TestInitialize]
        public void setup()
        {
            board = new Board();
            bishop = new Bishop(PieceColor.White, new Position(3, 3));
        }

        [TestMethod]
        public void ValidHorizontalMove_ShouldReturnTrue()
        {
            Assert.IsTrue(bishop.IsValidMove(new Position(3, 3), new Position(5, 5), board));
        }

        [TestMethod]
        public void ValidVerticalMove_ShouldReturnTrue()
        {
            Assert.IsTrue(bishop.IsValidMove(new Position(3, 3), new Position(1, 5), board));
        }

        [TestMethod]
        public void InvalidMove_ShouldReturnFalse()
        {
            Assert.IsFalse(bishop.IsValidMove(new Position(3, 3), new Position(3, 7), board));
        }
    }
}
