using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Bishop : Piece
    {
        public Bishop(PieceColor color) : base(color) { }

        public override bool IsValidMove(int startX, int startY, int endX, int endY, Board board)
        {
            return System.Math.Abs(startX - endX) == System.Math.Abs(startY - endY);
        }
    }
}
