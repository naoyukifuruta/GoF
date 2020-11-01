using System.Text;

namespace Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder sb = new StringBuilder();

        public string Result
        {
            get { return sb.ToString(); }
        }

        public override void MakeTitle(string title)
        {
            sb.Append("==============================\n");
            sb.Append($"『{title}』");
            sb.Append("\n");
        }

        public override void MakeString(string str)
        {
            sb.Append($"■{str}\n");
            sb.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                sb.Append($"　・{items[i]}\n");
            }
            sb.Append("\n");
        }

        public override void Close()
        {
            sb.Append("==============================\n");
        }
    }
}
