using System;

namespace Proxy
{
    public class PrinterProxy : IPrintable
    {
        private string _name;
        private Printer _real;

        public PrinterProxy(string name)
        {
            _name = name;
        }

        public void SetPrinterName(string name)
        {
            if (_real != null) _real.SetPrinterName(name);
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string str)
        {
            Realize();
            _real.Print(str);
        }

        private void Realize()
        {
            if (_real == null)
            {
                _real = new Printer(_name);
            }
        }
    }
}
