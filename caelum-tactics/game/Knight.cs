using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Knight : Piece
    {
        public Knight(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            int dx = Math.Abs(start.X - end.X);
            int dy = Math.Abs(start.Y - end.Y);
            return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
        }
    }
}
