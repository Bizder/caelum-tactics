﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Knight : Piece
    {
        public Knight(PieceColor color) : base(color) { }

        public override bool IsValidMove(int startX, int startY, int endX, int endY, Board board)
        {
            int dx = System.Math.Abs(startX - endX);
            int dy = System.Math.Abs(startY - endY);
            return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
        }
    }
}
