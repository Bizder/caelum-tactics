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

        protected Piece(PieceColor color)
        {
            Color = color;
        }

        public abstract bool IsValidMove(int startX, int startY, int endX, int endY, Board board);
    }
}
