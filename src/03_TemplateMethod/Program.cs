
namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, Wirld");
            AbstractDisplay d3 = new StringDisplay("こんにちは！");

            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}
