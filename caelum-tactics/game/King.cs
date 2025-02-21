using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class King : Piece
    {
        public King(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            int dx = Math.Abs(start.X - end.X);
            int dy = Math.Abs(start.Y - end.Y);
            return dx <= 1 && dy <= 1;
        }
    }
}
