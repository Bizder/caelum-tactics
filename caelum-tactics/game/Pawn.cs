using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor color) : base(color) { }

        public override bool IsValidMove(int startX, int startY, int endX, int endY, Board board)
        {
            int direction = Color == PieceColor.White ? 1 : -1;
            return (startX == endX && endY == startY + direction);
        }
    }
}