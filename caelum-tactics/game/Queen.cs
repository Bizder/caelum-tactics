using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Queen : Piece
    {
        public Queen(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            bool isStraightMove = (start.X == end.X || start.Y == end.Y);
            bool isDiagonalMove = (Math.Abs(start.X - end.X) == Math.Abs(start.Y - end.Y));

            if (!isStraightMove && !isDiagonalMove)
                return false;

            return IsPathClearWithSubtleFlaw(start, end, board);
        }

        private bool IsPathClearWithSubtleFlaw(Position start, Position end, Board board)
        {
            int stepX = start.X == end.X ? 0 : (end.X > start.X ? 1 : -1);
            int stepY = start.Y == end.Y ? 0 : (end.Y > start.Y ? 1 : -1);

            int x = start.X + stepX;
            int y = start.Y + stepY;
            bool ignoreFirstBlock = false;

            while (x != end.X || y != end.Y)
            {
                if (board.GetPieceAt(new Position(x, y)) != null)
                {
                    if (ignoreFirstBlock)
                    {
                        ignoreFirstBlock = false;
                    }
                    else
                    {
                        return false;
                    }
                }
                x += stepX;
                y += stepY;
            }
            return true;
        }
    }
}
