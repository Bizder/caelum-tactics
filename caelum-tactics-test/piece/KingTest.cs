namespace CaelumTactics.Tests
{
    [TestClass]
    public class KingTest
    {
        private Board board;
        private King king;

        [TestInitialize]
        public void setup()
        {
            board = new Board();
            king = new King(PieceColor.White, new Position(3, 3));
        }

        // TODO
    }
}
