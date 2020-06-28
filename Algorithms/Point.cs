using System;

namespace Algorithms
{
    class Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Point(string coordX, string coordY)
        {
            CoordX = int.Parse(coordX);
            CoordY = int.Parse(coordY);
        }

        public Point(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }

        public Point(Point point)
        {
            CoordX = point.CoordX;
            CoordY = point.CoordY;
        }

        public Point(DoublePoint point)
        {
            CoordX = Convert.ToInt32(Math.Round(point.CoordX));
            CoordY = Convert.ToInt32(Math.Round(point.CoordY));
        }

        public static bool operator == (Point a, Point b)
        {
            return a.CoordX == b.CoordX && a.CoordY == b.CoordY;
        }

        public static bool operator != (Point a, Point b)
        {
            return a.CoordX != b.CoordX && a.CoordY != b.CoordY;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Point pointObj = obj as Point;
            if (pointObj is null) return false;
            return Equals(pointObj);
        }

        public bool Equals(Point other)
        {
            if (other is null) return false;
            return CoordX == other.CoordX && CoordY == other.CoordY;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", CoordX, CoordY);
        }

        public bool IsPositiveCoords()
        {
            return CoordX > 0 && CoordY > 0;
        }

        public int ProjectingPointFirstOctant()
        {
            if (CoordX > 0 && CoordY > 0)
            {
                if (CoordX < CoordY) { SecondConversion(); return 2; }
                else { return 1; }
            }
            else if (CoordX < 0 && CoordY > 0)
            {
                if (Math.Abs(CoordX) < CoordY) { ThirdConversion(); return 3; }
                else { FourthConversion(); return 4; }
            }
            else if (CoordX < 0 && CoordY < 0)
            {
                if (CoordX < CoordY) { FifthConversion(); return 5; }
                else { SixthConversion();return 6; }
            }
            else
            {
                if (CoordX < Math.Abs(CoordY)) { SeventhConversion(); return 7; }
                else { EighthConversion(); return 8; }
            }
        }

        public void ProjectingPointFromFirstOctant(int octant)
        {
            switch (octant)
            {
                case 2: SecondConversion(); break;
                case 3: SeventhConversion(); break;
                case 4: FourthConversion(); break;
                case 5: FifthConversion(); break;
                case 6: SixthConversion(); break;
                case 7: ThirdConversion(); break;
                case 8: EighthConversion(); break;
            }
        }

        public void ProjectingPointFromFourthOctant(int octant)
        {
            switch (octant)
            {
                case 1: FourthConversion(); break;
                case 2: ThirdConversion(); break;
                case 3: SixthConversion(); break;
                case 5: EighthConversion(); break;
                case 6: SeventhConversion(); break;
                case 7: SecondConversion(); break;
                case 8: FifthConversion(); break;
            }
        }

        private void SecondConversion()
        {
            CoordX = CoordX + CoordY;
            CoordY = CoordX - CoordY;
            CoordX = CoordX - CoordY;
        }

        private void ThirdConversion()
        {
            int temp = CoordY;
            CoordY = -1 * CoordX;
            CoordX = temp;
        }

        private void FourthConversion()
        {
            CoordX = -1 * CoordX;
        }

        private void FifthConversion()
        {
            CoordX = -1 * CoordX;
            CoordY = -1 * CoordY;
        }

        private void SixthConversion()
        {
            int temp = CoordY;
            CoordY = -1 * CoordX;
            CoordX = -1 * temp;
        }

        private void SeventhConversion()
        {
            int temp = CoordY;
            CoordY = CoordX;
            CoordX = -1 * temp;
        }

        private void EighthConversion()
        {
            CoordY = -1 * CoordY;
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
