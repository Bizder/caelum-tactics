namespace CaelumTactics.Tests
{
    [TestClass]
    public class QueenTest
    {
        private Board board;
        private Queen queen;

        [TestInitialize]
        public void setup()
        {
            board = new Board();
            queen = new Queen(PieceColor.White, new Position(3, 3));
        }

        // TODO
    }
}
