namespace CaelumTactics
{
    public struct Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Position pos)
                return X == pos.X && Y == pos.Y;
            return false;
        }

        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();
        public override string ToString() => $"({X}, {Y})";
    }
}
