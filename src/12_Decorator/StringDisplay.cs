using System.Text;

namespace Decorator
{
    public class StringDisplay : Display
    {
        private string _str;

        public StringDisplay(string str)
        {
            _str = str;
        }

        public override int Columns
        {
            get
            {
                return _str.Length;
            }
        }

        public override int Rows
        {
            get { return 1; }
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return _str;
            }
            else
            {
                return null;
            }
        }
    }
}
