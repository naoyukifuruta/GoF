using System;

namespace Proxy
{
    public interface IPrintable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string str);
    }
}
