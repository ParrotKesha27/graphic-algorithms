using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Algorithms
{
    class CurveBezier
    {
        private readonly LineBuilder dda = new LineBuilder();
        private Canvas CurveCanvas { get; set; }

        public Canvas RasterizeCurveBezier(List<DoublePoint> points)
        {
            CurveCanvas = new Canvas(); // Создаем холст, на котором будем рисовать точки
            DrawCurveBezier(points); // Рисуем кривую Безье
            return CurveCanvas; // Возвращаем холст
        }

        private void DrawCurveBezier(List<DoublePoint> points)
        {
            int n = points.Count;

            // Если все точки помещаются в прямоугольник, длины которого меньше 1, то заканчиваем
            if (MaxLengthMinBBox(points) < 1) { return; }

            // Если точки расположены на одной прямой
            if (IsPointOneLine(points))
            {
                Point startPoint = new Point(points.First());
                Point endPoint = new Point(points.Last());
                // Рисуем прямую методом Безье
                Canvas lineCanvas = dda.RasterizeLine(startPoint, endPoint, true);
                // Переносим точки на наш холст
                var collection = lineCanvas.Children.Cast<UIElement>().ToArray();
                lineCanvas.Children.Clear();
                foreach (UIElement element in collection)
                {
                    CurveCanvas.Children.Add(element);
                }
                return;
            }

            double t = 0.5;
            // Находим левые точки: P(0,0), P(0,1), ..., P(0, n)
            List<DoublePoint> leftPoints = new List<DoublePoint>(n) { points.First() };
            for (int i = 1; i < n; i++) { leftPoints.Add(GetPointByLevel(points, 0, i, t)); }

            // Находим правые точки: P(1, n-1), P(2, n-2), ..., P(n-1, 1)
            List<DoublePoint> rightPoints = new List<DoublePoint>(n) { leftPoints.Last() };
            for (int i = 1; i < n; i++) { rightPoints.Add(GetPointByLevel(points, i, n - i - 1, t)); }

            // Риусем текущую точку
            DrawPoint(new Point(leftPoints.Last()));

            // Применяем алгоритм для левой и правой части кривой
            DrawCurveBezier(leftPoints);
            DrawCurveBezier(rightPoints);
            return;
        }

        // Возвращает точку по уровню разбиения
        private DoublePoint GetPointByLevel(List<DoublePoint> points, int pointIndex, int breakingLevel, double t)
        {
            if (breakingLevel == 0) { return points[pointIndex]; }

            return (1 - t) * GetPointByLevel(points, pointIndex, breakingLevel - 1, t) + t * GetPointByLevel(points, pointIndex + 1, breakingLevel - 1, t);
        }

        // Определить, лежат ли точки на одной прямой
        private bool IsPointOneLine(List<DoublePoint> points)
        {
            for (int i = 1; i < points.Count - 1; i++)
            {
                if ((points[i].CoordX - points.First().CoordX) / (points.Last().CoordX - points.First().CoordX) != (points[i].CoordY - points.First().CoordY) / (points.Last().CoordY - points.First().CoordY))
                {
                    return false;
                }
            }

            return true;
        }

        // Максимальная сторона обрамляющего прямоугольника
        private double MaxLengthMinBBox(List<DoublePoint> points)
        {
            List<double> lengths = new List<double>();
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    lengths.Add(Math.Abs(points[i].CoordX - points[j].CoordX));
                    lengths.Add(Math.Abs(points[i].CoordY - points[j].CoordY));
                }
            }

            return lengths.Max();
        }

        // Рисование точки
        private void DrawPoint(Point point)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = 1,
                Height = 1,
                Fill = new SolidColorBrush(Colors.Red)
            };
            Canvas.SetTop(rectangle, point.CoordY);
            Canvas.SetLeft(rectangle, point.CoordX);
            CurveCanvas.Children.Add(rectangle);
        }
    }
}
