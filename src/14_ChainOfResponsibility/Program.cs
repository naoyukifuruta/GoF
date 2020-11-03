﻿
namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Support alice = new NoSupport("Alice");
            Support bob = new LimitSupport("Bob", 100);
            Support charlie = new SpecialSupport("Charlie", 429);
            Support diana = new LimitSupport("Diana", 200);
            Support elmo = new OddSupport("Elmo");
            Support fred = new LimitSupport("Fred", 300);

            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);

            for (var i = 0; i < 500; i += 33)
            {
                alice.SupportTrouble(new Trouble(i));
            }
        }
    }
}
