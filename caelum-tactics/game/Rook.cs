using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Rook : Piece
    {
        public Rook(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            if (start.X != end.X && start.Y != end.Y)
                return false;
            return true;
        }
    }
}
