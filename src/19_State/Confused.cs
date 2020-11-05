using System;

namespace State
{
    public class Confused : IState
    {
        private static Confused singleton = new Confused();

        private Confused()
        {

        }

        public static IState getInstance()
        {
            return singleton;
        }

        private static Random rnd = new Random();

        public void AttackCMD(String name, String target)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に攻撃した。");
            }
        }

        public void MagicCMD(String name, String magic, String target)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に" + magic + "をとなえた。");
            }
        }

        public void SkillCMD(String name, String skill, String target)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に" + skill + "をした。");
            }
        }

        public void DefenceCMD(String name)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
            }
            else
            {
                Console.WriteLine(name + "は身をまもっている。");
            }
        }

        public void ItemCMD(String name, String item)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
            }
            else
            {
                Console.WriteLine(name + "は" + item + "を使用した。");
            }
        }

        public int EscapeCMD(String name)
        {
            int random = rnd.Next(4);
            if (random == 3)
            {
                Console.WriteLine(name + "はわけが分からなくなってしまっている。");
                return 0;
            }
            else if (random == 2)
            {
                Console.WriteLine(name + "は自分を攻撃した。");
                return 0;
            }
            else if (random == 1)
            {
                Console.WriteLine(name + "はぼーっとしている。");
                return 0;
            }
            else
            {
                Console.WriteLine(name + "は戦闘から逃げ出した。");
                return 1;
            }
        }

        public override String ToString()
        {
            return "混乱";
        }
    }
}
