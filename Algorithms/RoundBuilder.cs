using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Algorithms
{
    class RoundBuilder
    {
        private Canvas RoundCanvas { get; set; }
        private Point Center { get; set; }

        public Canvas RasterizeRound(Point center, int radius)
        {
            RoundCanvas = new Canvas(); // Создаем холст, на котором будем рисовать точки
            Center = center; // Запоминаем центр исходной окружности
            BresenhamAlgorithm(radius); // Рисуем по алгоритму Брезенхема

            // Возвращаем холст с точками
            return RoundCanvas; 
        }

        // Алгоритм Брезенхема
        private void BresenhamAlgorithm(int radius)
        {
            // Начальная точка в четвертом октанте
            Point point = new Point(-radius, 0);
            // Считаем F, delta_s, delta_d
            int F = 1 - radius, delta_s = 3, delta_d = 5 - 2 * radius;

            // Пока находимся в четвертом октанте
            while (point.CoordX + point.CoordY < 0)
            {
                DrawPoint(point); // Рисуем точку и ее проекции в другие октанты

                if (F > 0)
                {
                    // Диагональное смещение
                    F += delta_d;
                    point.CoordX++; point.CoordY++;
                    delta_s += 2;
                    delta_d += 4;
                }
                else
                {
                    // Вертикальное смещение
                    F += delta_s;
                    point.CoordY++;
                    delta_s += 2;
                    delta_d += 2;
                }
            }
        }

        // Функция, которя возвращает список проекций точки в 8 октантов
        private List<Point> GenerateOctantsList(Point point)
        {
            List<Point> points = new List<Point>() { point };
            for (int i = 1; i <= 8; i++)
            {
                if (i == 4) { continue; }
                Point fPoint = new Point(point);
                fPoint.ProjectingPointFromFourthOctant(i);
                points.Add(fPoint);
            }

            return points.Select(x => x).Distinct().ToList();
        }

        private void DrawPoint(Point point)
        {
            // Копируем точку, чтобы не испортить исходную
            Point drawPoint = new Point(point);
            // Находим проекцию точки в остальные октанты
            List<Point> octantsPoint = GenerateOctantsList(drawPoint);

            foreach (Point p in octantsPoint)
            {
                // Смещаем точку относительно исходного центра
                p.CoordX += Center.CoordX;
                p.CoordY = -(p.CoordY - Center.CoordY);

                // Рисуем точку как прямоугольник, размера 1х1
                Rectangle rectangle = new Rectangle
                {
                    Width = 1,
                    Height = 1,
                    Fill = new SolidColorBrush(Colors.Red)
                };
                Canvas.SetTop(rectangle, p.CoordY);
                Canvas.SetLeft(rectangle, p.CoordX);
                RoundCanvas.Children.Add(rectangle);
            }
        }
    }
}
