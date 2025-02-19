using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumTactics
{
    public class Board
    {
        public const int Size = 8;
        public Piece[,] Grid { get; private set; }

        public Board()
        {
            Grid = new Piece[Size, Size];
        }

        public void AddPiece(Piece piece, int x, int y)
        {
            if (x >= 0 && x < Size && y >= 0 && y < Size)
            {
                Grid[x, y] = piece;
            }
        }
    }
}
