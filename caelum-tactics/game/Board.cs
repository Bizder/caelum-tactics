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

        public void AddPiece(Piece piece, Position position)
        {
            if (IsValidPosition(position))
            {
                Grid[position.X, position.Y] = piece;
                piece.Position = position;
            }
        }

        public bool MovePiece(Position from, Position to)
        {
            Piece piece = Grid[from.X, from.Y];
            if (piece == null || !piece.IsValidMove(from, to, this))
                return false;

            Grid[to.X, to.Y] = piece;
            Grid[from.X, from.Y] = null;
            piece.Position = to;

            return true;
        }

        public Piece GetPieceAt(Position position) => Grid[position.X, position.Y];

        public bool IsValidPosition(Position position) => position.X >= 0 && position.X < Size && position.Y >= 0 && position.Y < Size;
    }
}
