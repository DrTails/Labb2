using System;
namespace Labb2
{
    public class Position
    {

        int x;
        int y;

        public int X
        {
            get { return x; }
            set { x = value < 0 ? 0 : value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value < 0 ? 0 : value; }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public bool Equals(Position p)
        {
            return p.X == X && p.Y == Y;
        }

        public Position Clone()
        {
            return new Position(X, Y);
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

        public static bool operator >(Position p1, Position p2)
        {
            return p1.Length() > p2.Length();
        }

        public static bool operator <(Position p1, Position p2)
        {
            return p1.Length() < p2.Length();
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static double operator %(Position p1, Position p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + (Math.Pow(p1.Y - p2.Y, 2)));
        }

    }
}
