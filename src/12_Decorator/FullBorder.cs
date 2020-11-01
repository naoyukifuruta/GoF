using System.Text;

namespace Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display) { }

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
                return 1 + _display.Rows + 1;
            }
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', _display.Columns) + "+";
            }
            else if (row == _display.Rows + 1)
            {
                return "+" + MakeLine('-', _display.Columns) + "+";
            }
            else
            {
                return "|" + _display.GetRowText(row - 1) + "|";
            }
        }

        private string MakeLine(char ch, int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
