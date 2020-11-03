using System;

namespace ChainOfResponsibility
{
    public abstract class Support
    {
        private string _name;

        private Support _next;

        public Support(string name)
        {
            _name = name;
        }

        public Support SetNext(Support next)
        {
            _next = next;
            return next;
        }

        public void SupportTrouble(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Console.WriteLine("問題" + trouble.Number + "は" + _name + "が解決しました。");
            }
            else if (_next != null)
            {
                _next.SupportTrouble(trouble);
            }
            else
            {
                Console.WriteLine("問題" + trouble.Number + "は現在のサポート体制では解決できませんでした。");
            }
        }

        protected abstract bool Resolve(Trouble trouble);
    }
}
