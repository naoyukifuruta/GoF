
namespace Decorator
{
    public class SideBorder : Border
    {
        private char _borderChar;

        public SideBorder(Display display, char ch) : base(display)
        {
            _borderChar = ch;

        }
        public override int Columns
        {
            get
            {
                return 1 + _display.Columns + 1;
            }
        }

        public override int Rows
        {
            get
            {
                return _display.Rows;
            }
        }

        public override string GetRowText(int row)
        {
            return _borderChar + _display.GetRowText(row) + _borderChar;
        }
    }
}
