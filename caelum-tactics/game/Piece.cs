using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public abstract class Piece
    {
        public PieceColor Color { get; private set; }
        public Position Position { get; set; }

        protected Piece(PieceColor color, Position position)
        {
            Color = color;
            Position = position;
        }

        public abstract bool IsValidMove(Position start, Position end, Board board);
    }
}
