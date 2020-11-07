using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context("expressions.xml");
            var expression = context.BuildExpression();

            Console.WriteLine($"expression.Operate() : {expression.Operate()}");
        }
    }
}
