namespace Practice23
{
        public partial class Task1 : Form
        {
            private int childCount = 0;

            public Task1()
            {
                InitializeComponent();
                this.IsMdiContainer = true;
                this.WindowState = FormWindowState.Maximized;
            }

            private void CreateCircleToolStripMenuItem_Click(object sender, EventArgs e)
            {
                childCount++;
                ChildForm1 newChild = new ChildForm1(ShapeType.Circle);
                newChild.MdiParent = this;
                newChild.Text = $"Circle {childCount}";
                newChild.Show();
            }

            private void CreateRectangleToolStripMenuItem_Click(object sender, EventArgs e)
            {
                childCount++;
                ChildForm1 newChild = new ChildForm1(ShapeType.Rectangle);
                newChild.MdiParent = this;
                newChild.Text = $"Rectangle {childCount}";
                newChild.Show();
            }

            private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }

            private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }

            private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }

            private void MoveUpToolStripButton_Click(object sender, EventArgs e)
            {
                if (this.ActiveMdiChild is ChildForm1 activeChild)
                {
                    activeChild.MoveShape(0, -10);
                }
            }

            private void MoveDownToolStripButton_Click(object sender, EventArgs e)
            {
                if (this.ActiveMdiChild is ChildForm1 activeChild)
                {
                    activeChild.MoveShape(0, 10);
                }
            }

            private void MoveLeftToolStripButton_Click(object sender, EventArgs e)
            {
                if (this.ActiveMdiChild is ChildForm1 activeChild)
                {
                    activeChild.MoveShape(-10, 0);
                }
            }

            private void MoveRightToolStripButton_Click(object sender, EventArgs e)
            {
                if (this.ActiveMdiChild is ChildForm1 activeChild)
                {
                    activeChild.MoveShape(10, 0);
                }
            }
        }

        public enum ShapeType
        {
            Circle,
            Rectangle
        }
}
