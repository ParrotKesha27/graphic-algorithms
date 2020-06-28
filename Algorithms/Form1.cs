using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ddaButton_Click(object sender, EventArgs e)
        {
            Point startPoint, endPoint;
            try
            {
                startPoint = new Point(startXInput.Text, startYInput.Text);
                endPoint = new Point(endXInput.Text, endYInput.Text);
                if (!startPoint.IsPositiveCoords() || !endPoint.IsPositiveCoords()) { throw new ArgumentException(); }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Координаты могут быть только целыми положительными числами!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LineBuilder analyzer = new LineBuilder();

            if (ddaRadioButton.Checked) { ddaHost.Child = analyzer.RasterizeLine(startPoint, endPoint, false); }
            else if (bresenhamRadioButton.Checked) { ddaHost.Child = analyzer.RasterizeLine(startPoint, endPoint, true); }
            else { MessageBox.Show("Выберите один из алгоритмов!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

        private void DrawControlLine(List<DoublePoint> controlPoints, ref Canvas canvas)
        {
            for (int i = 0; i < controlPoints.Count - 1; i++)
            {
                Line line = new Line
                {
                    StrokeThickness = 1,
                    SnapsToDevicePixels = true
                };
                line.Stroke = Brushes.Blue;
                line.SetValue(RenderOptions.EdgeModeProperty, EdgeMode.Aliased);
                line.X1 = controlPoints[i].CoordX;
                line.X2 = controlPoints[i + 1].CoordX;
                line.Y1 = controlPoints[i].CoordY;
                line.Y2 = controlPoints[i + 1].CoordY;
                canvas.Children.Add(line);
            }
        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            Point roundCenter;
            int radius;
            try
            {
                roundCenter = new Point(roundXInput.Text, roundYInput.Text);
                radius = int.Parse(roundRadiusInput.Text);
                if (radius <= 0 || !roundCenter.IsPositiveCoords()) { throw new ArgumentException(); }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Координаты и радиус могут быть только целыми положительными числами!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radius > roundCenter.CoordX || radius > roundCenter.CoordY)
            {
                MessageBox.Show("Радиус не может быть больше значения одной из координат", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RoundBuilder builder = new RoundBuilder();
            roundHost.Child = builder.RasterizeRound(roundCenter, radius);
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            DoublePoint newPoint;
            try
            {
                newPoint = new DoublePoint(splinePointXInput.Text, splinePointYInput.Text);
                if (!newPoint.IsPositiveCoords()) { throw new ArgumentException(); }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Координаты могут быть только положительными числами!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            splinePointList.Items.Add(newPoint);
            splinePointXInput.Clear(); splinePointYInput.Clear();
        }

        private void splineButton_Click(object sender, EventArgs e)
        {
            if (splinePointList.Items.Count < 2)
            {
                MessageBox.Show("Должно быть минимум 2 точки!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<DoublePoint> points = new List<DoublePoint>(splinePointList.Items.Count);
            foreach (DoublePoint point in splinePointList.Items) { points.Add(point); }
            CurveBezier curveBezier = new CurveBezier();
            Canvas canvas = curveBezier.RasterizeCurveBezier(points);
            //DrawControlLine(points, ref canvas);
            splineHost.Child = canvas;
        }

        private void clearPointList_Click(object sender, EventArgs e)
        {
            splinePointList.Items.Clear();
        }
    }
}
