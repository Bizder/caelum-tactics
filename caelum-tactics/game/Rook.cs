using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Rook : Piece
    {
        public Rook(PieceColor color) : base(color) { }

        public override bool IsValidMove(int startX, int startY, int endX, int endY, Board board)
        {
            return (startX == endX || startY == endY);
        }
    }
}
