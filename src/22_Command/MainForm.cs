using System;
namespace Command
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            drawCanvas1.SetHistory(history);
        }

        private MacroCommand history = new MacroCommand();

        bool drag = false;

        private void drawCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                ICommand command = new DrawCommand(drawCanvas1, e.Location);
                history.Apppend(command);
                command.Execute();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            history.Clear();
            drawCanvas1.Invalidate();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            history.Undo();
            drawCanvas1.Invalidate();
        }

        private void drawCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void drawCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
