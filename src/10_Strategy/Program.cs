using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Input  two args as radomeseed1 ane randomeseed2");
                Console.WriteLine("Example: 314 15");
                Environment.Exit(0);
            }

            int seed1 = int.Parse(args[0]);
            int seed2 = int.Parse(args[1]);

            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hanako", new ProbStrategy(seed2));

            for (int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();

                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }

                Console.WriteLine("Total result:");
                Console.WriteLine(player1.ToString());
                Console.WriteLine(player2.ToString());
            }
        }
    }
}
