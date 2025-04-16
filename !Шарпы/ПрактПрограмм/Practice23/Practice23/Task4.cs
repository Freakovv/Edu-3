using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Practice23
{
    public partial class Task4 : Form
    {
        private Font axisFont = new Font("Arial", 10);
        private Font labelFont = new Font("Arial", 12, FontStyle.Bold);

        public Task4()
        {
            InitializeComponent();
            this.Load += Task4_Load;
        }

        private void Task4_Load(object sender, EventArgs e)
        {
            PlotFunction();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            PlotFunction();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                axisFont = fontDialog.Font;
                PlotFunction();
            }
        }

        private void PlotFunction()
        {
            if (pictureBox.Width <= 0 || pictureBox.Height <= 0)
                return;

            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                g.Clear(Color.White);

                int margin = 50;
                int graphWidth = bmp.Width - 2 * margin;
                int graphHeight = bmp.Height - 2 * margin;

                float xMin = 2.0f;
                float xMax = 10.0f;

                float yMin = float.MaxValue;
                float yMax = float.MinValue;
                int testPoints = 1000;
                float elasticity = (float)numericElasticity.Value;

                for (int i = 0; i < testPoints; i++)
                {
                    float x = xMin + i * (xMax - xMin) / (testPoints - 1);
                    float y = CalculateFunction(x, elasticity);

                    if (y < yMin) yMin = y;
                    if (y > yMax) yMax = y;
                }

                float yPadding = (yMax - yMin) * 0.1f;
                yMin -= yPadding;
                yMax += yPadding;

                float xScale = graphWidth / (xMax - xMin);
                float yScale = graphHeight / (yMax - yMin);

                int xAxisY = bmp.Height - margin - (int)((0 - yMin) * yScale);
                int yAxisX = margin + (int)((0 - xMin) * xScale);

                xAxisY = Math.Max(margin, Math.Min(bmp.Height - margin, xAxisY));
                yAxisX = Math.Max(margin, Math.Min(bmp.Width - margin, yAxisX));

                using (Pen axisPen = new Pen(Color.Black, 2))
                {
                    g.DrawLine(axisPen, margin, xAxisY, bmp.Width - margin, xAxisY);

                    g.DrawLine(axisPen, yAxisX, margin, yAxisX, bmp.Height - margin);
                }

                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;

                    g.DrawString("X", labelFont, Brushes.Black,
                                new PointF(bmp.Width - margin + 20, xAxisY), sf);

                    sf.LineAlignment = StringAlignment.Near;
                    g.DrawString("Y", labelFont, Brushes.Black,
                                new PointF(yAxisX, margin - 20), sf);
                }

                DrawAxisTicks(g, margin, graphWidth, graphHeight, xMin, xMax, yMin, yMax,
                             xScale, yScale, xAxisY, yAxisX);

                int pointCount = (int)numericPointCount.Value;
                PointF[] points = new PointF[pointCount];

                for (int i = 0; i < pointCount; i++)
                {
                    float x = xMin + i * (xMax - xMin) / (pointCount - 1);
                    float y = CalculateFunction(x, elasticity);

                    points[i] = new PointF(
                        margin + (x - xMin) * xScale,
                        margin + graphHeight - (y - yMin) * yScale);
                }

                using (Pen curvePen = new Pen(Color.Red, 2))
                {
                    g.DrawCurve(curvePen, points);
                }
            }

            pictureBox.Image = bmp;
        }
        private float CalculateFunction(float x, float elasticity)
        {
            return (float)(Math.Sqrt(x * x + 5) - elasticity * 10 * Math.Pow(Math.Sin(x - 1), 2));
        }

        private void DrawAxisTicks(Graphics g, int margin, int graphWidth, int graphHeight,
                                 float xMin, float xMax, float yMin, float yMax,
                                 float xScale, float yScale, int xAxisY, int yAxisX)
        {
            for (float x = xMin; x <= xMax; x += 1.0f)
            {
                float screenX = margin + (x - xMin) * xScale;
                g.DrawLine(Pens.Black, screenX, xAxisY - 5, screenX, xAxisY + 5);
                g.DrawString(x.ToString("0"), axisFont, Brushes.Black,
                            new PointF(screenX, xAxisY + 10),
                            new StringFormat() { Alignment = StringAlignment.Center });
            }

            for (float y = yMin; y <= yMax; y += 2.0f)
            {
                float screenY = xAxisY - (y - yMin) * yScale;
                g.DrawLine(Pens.Black, yAxisX - 5, screenY, yAxisX + 5, screenY);
                g.DrawString(y.ToString("0"), axisFont, Brushes.Black,
                            new PointF(yAxisX - 20, screenY),
                            new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });
            }
        }
    }
}