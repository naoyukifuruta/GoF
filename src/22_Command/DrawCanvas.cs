using System;

namespace Command
{
    public partial class DrawCanvas : UserControl, IDrawable
    {
        public DrawCanvas()
        {
            InitializeComponent();
        }

        private Color color = Color.Black;

        private int radius = 6;

        private MacroCommand history = null;

        public void SetHistory(MacroCommand history) => this.history = history;

        public void Draw(int x, int y)
        {
            using (Graphics g = CreateGraphics())
            using (Brush brush = new SolidBrush(color))
            {
                Rectangle rectangle = new Rectangle(x, y, radius, radius);
                g.FillEllipse(brush, rectangle);
            }
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (history != null)
            {
                history.Execute();
            }
        }
    }
}
