using System;

namespace Algorithms
{
    class DoublePoint
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }

        public DoublePoint(string coordX, string coordY)
        {
            CoordX = double.Parse(coordX);
            CoordY = double.Parse(coordY);
        }

        public DoublePoint(double coordX, double coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }

        public DoublePoint(DoublePoint point)
        {
            CoordX = point.CoordX;
            CoordY = point.CoordY;
        }

        public static DoublePoint operator +(DoublePoint a, DoublePoint b)
        {
            return new DoublePoint(a.CoordX + b.CoordX, a.CoordY + b.CoordY);
        }

        public static DoublePoint operator *(double number, DoublePoint a)
        {
            return new DoublePoint(a.CoordX * number, a.CoordY * number);
        }

        public static bool operator ==(DoublePoint a, DoublePoint b)
        {
            return a.CoordX == b.CoordX && a.CoordY == b.CoordY;
        }

        public static bool operator !=(DoublePoint a, DoublePoint b)
        {
            return a.CoordX != b.CoordX && a.CoordY != b.CoordY;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            DoublePoint pointObj = obj as DoublePoint;
            if (pointObj is null) return false;
            return Equals(pointObj);
        }

        public bool Equals(DoublePoint other)
        {
            if (other is null) return false;
            return CoordX == other.CoordX && CoordY == other.CoordY;
        }

        public bool IsPositiveCoords()
        {
            return CoordX > 0 && CoordY > 0;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", CoordX, CoordY);
        }

        public override int GetHashCode()
        {
            var hashCode = 149133223;
            hashCode = hashCode * -1521134295 + CoordX.GetHashCode();
            hashCode = hashCode * -1521134295 + CoordY.GetHashCode();
            return hashCode;
        }
    }
}
