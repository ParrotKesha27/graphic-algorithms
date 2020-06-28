using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Algorithms
{
    class LineBuilder
    {
        private Canvas LineCanvas { get; set; }
        private int PointDeltaX { get; set; }
        private int PointDetlaY { get; set; }
        private int PointOctant { get; set; }

        public void RasterizeLine(Point startPoint, Point endPoint, bool bresenham, Canvas canvas)
        {
            RasterizeLine(startPoint, endPoint, bresenham);
            UIElementCollection collection = LineCanvas.Children;
            LineCanvas.Children.Clear();
            foreach (UIElement element in collection)
            {
                canvas.Children.Add(element);
            }
        }

        public Canvas RasterizeLine(Point startPoint, Point endPoint, bool bresenham)
        {
            LineCanvas = new Canvas(); // Создаем холст, на котором будем рисовать точки

            PointDeltaX = startPoint.CoordX; // Смещение по Х относительно нового начала координат
            PointDetlaY = startPoint.CoordY; // Смещение по Y относительного нового начала координат
            // Новая конечная точка, относительно нового начала координат
            Point newEndPoint = new Point(endPoint.CoordX - PointDeltaX, -(endPoint.CoordY - PointDetlaY));
            // Переводим конечную точку в первый октант и запоминаем в каком октанте она была
            PointOctant = newEndPoint.ProjectingPointFirstOctant();

            // Если выбран алгоритм Брезенхема, то рисуем по нему
            if (bresenham) { BresenhamAlgorithm(newEndPoint); }
            // Иначе используем ЦДА
            else { DigitalDifferentialAnalyzer(newEndPoint); }

            // Возвращаем холст с точками
            return LineCanvas;
        }

        // ЦДА
        private void DigitalDifferentialAnalyzer(Point endPoint)
        {
            // Начальная точка находится в начале координат
            Point point = new Point(0, 0);
            // Считаем e и delta_e
            double x = endPoint.CoordX, y = endPoint.CoordY;
            double e = y / x;
            double delta = e;

            // Пока не дойдем до конечной точки
            while (point.CoordX < endPoint.CoordX)
            {
                DrawPoint(point); // Рисуем точку

                if (e > 0.5)
                {
                    // Диагональный сдвиг
                    point.CoordX++; point.CoordY++;
                    e += delta - 1;
                }
                else
                {
                    // Горизонтальный сдвиг
                    point.CoordX++;
                    e += delta;
                }
            }
        }

        // Алгоритм Брезенхема
        private void BresenhamAlgorithm(Point endPoint)
        {
            // Начальная точка
            Point point = new Point(0, 0);
            // Считаем e, delta_s и delta_d
            int e = 2 * endPoint.CoordY - endPoint.CoordX;
            int delta_s = 2 * endPoint.CoordY;
            int delta_d = 2 * endPoint.CoordY - 2 * endPoint.CoordX;

            // Пока не дойдем до конечной точки
            while (point.CoordX < endPoint.CoordX)
            {
                DrawPoint(point); // Рисуем точку

                if (e > 0)
                {
                    // Диагональное смещение
                    point.CoordX++; point.CoordY++;
                    e += delta_d;
                }
                else
                {
                    // Горизонтальное смещение
                    point.CoordX++;
                    e += delta_s;
                }
            }
        }

        private void DrawPoint(Point point)
        {
            // Копируем точку, чтобы не испортить исходную
            Point drawingPoint = new Point(point);
            // Возвращаем точку в нужный октант
            drawingPoint.ProjectingPointFromFirstOctant(PointOctant);
            // Сдвигаем относительно новой системы координат
            drawingPoint.CoordX += PointDeltaX;
            drawingPoint.CoordY = -(drawingPoint.CoordY - PointDetlaY);

            // Рисуем точку как прямоугольник размера 1х1
            Rectangle rectangle = new Rectangle
            {
                Width = 1,
                Height = 1,
                Fill = new SolidColorBrush(Colors.Red)
            };
            Canvas.SetTop(rectangle, drawingPoint.CoordY);
            Canvas.SetLeft(rectangle, drawingPoint.CoordX);
            LineCanvas.Children.Add(rectangle);
        }
    }
}
