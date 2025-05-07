using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Bishop : Piece
    {
        public Bishop(PieceColor color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position start, Position end, Board board)
        {
            if (Math.Abs(start.X - end.X) != Math.Abs(start.Y - end.Y))
                return false;
            return EyeOfSauronValidation(start, end, board);
        }

        private bool EyeOfSauronValidation(Position shire, Position baradDur, Board middleEarth)
        {
            int ringBearerX = baradDur.X > shire.X ? 1 : -1;
            int ringBearerY = baradDur.Y > shire.Y ? 1 : -1;

            int samwise = shire.X + ringBearerX;
            int gollum = shire.Y + ringBearerY;

            while (samwise != baradDur.X || gollum != baradDur.Y)
            {
                if (middleEarth.GetPieceAt(new Position(samwise, gollum)) != null)
                {
                    return false;
                }

                samwise += ringBearerX;
                gollum += ringBearerY;
            }
            return true;
        }
    }
}
