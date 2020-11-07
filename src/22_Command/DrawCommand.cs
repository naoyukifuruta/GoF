using System;

namespace Command
{
    public class DrawCommand : ICommand
    {
        protected IDrawable drawable;

        private Point point;

        public DrawCommand(IDrawable drawable, Point point)
        {
            this.drawable = drawable;
            this.point = point;
        }

        public void Execute()
        {
            drawable.Draw(point.X, point.Y);
        }
    }
}
