namespace CaelumTactics.Tests
{
    [TestClass]
    public class KnightTest
    {
        private Board board;
        private Knight knight;

        [TestInitialize]
        public void setup()
        {
            board = new Board();   
            knight = new Knight(PieceColor.White, new Position(3, 3));
        }

        [TestMethod]
        public void ValidMove_ShouldReturnTrue()
        {
            Assert.IsTrue(knight.IsValidMove(new Position(3, 3), new Position(5, 4), board));
        }

        [TestMethod]
        public void InvalidMove_ShouldReturnFalse()
        {
            Assert.IsFalse(knight.IsValidMove(new Position(3, 3), new Position(4, 4), board));
        }
    }
}
