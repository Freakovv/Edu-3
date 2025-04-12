namespace Practice23
{
        public partial class ChildForm1 : Form
        {
            private ShapeType shapeType;
            private Point shapeLocation = new Point(100, 100);
            private const int ShapeSize = 100;

            public ChildForm1(ShapeType type)
            {
                InitializeComponent();
                shapeType = type;
                this.DoubleBuffered = true;
                this.Paint += ChildForm_Paint;
            }

            private void ChildForm_Paint(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;

                switch (shapeType)
                {
                    case ShapeType.Circle:
                        g.FillEllipse(Brushes.Blue, shapeLocation.X, shapeLocation.Y, ShapeSize, ShapeSize);
                        break;
                    case ShapeType.Rectangle:
                        g.FillRectangle(Brushes.Red, shapeLocation.X, shapeLocation.Y, ShapeSize, ShapeSize);
                        break;
                }
            }

            public void MoveShape(int dx, int dy)
            {
                shapeLocation.X += dx;
                shapeLocation.Y += dy;
                this.Invalidate(); // Перерисовка
            }
        }
}
