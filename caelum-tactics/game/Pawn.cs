using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            int direction = Color == PieceColor.White ? 1 : -1;
            return start.X == end.X && end.Y == start.Y + direction && board.GetPieceAt(end) == null;
        }
    }
}