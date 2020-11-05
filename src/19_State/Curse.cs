using System;

namespace State
{
    public class Curse : IState
    {
        private static Curse singleton = new Curse();

        private Curse()
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
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に攻撃した。");
            }
        }

        public void MagicCMD(String name, String magic, String target)
        {
            int random = rnd.Next(4);
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に" + magic + "をとなえた。");
            }
        }

        public void SkillCMD(String name, String skill, String target)
        {
            int random = rnd.Next(4);
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
            }
            else
            {
                Console.WriteLine(name + "は" + target + "に" + skill + "をした。");
            }
        }

        public void DefenceCMD(String name)
        {
            int random = rnd.Next(4);
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
            }
            else
            {
                Console.WriteLine(name + "は身をまもっている。");
            }
        }

        public void ItemCMD(String name, String item)
        {
            int random = rnd.Next(4);
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
            }
            else
            {
                Console.WriteLine(name + "は" + item + "を使用した。");
            }
        }

        public int EscapeCMD(String name)
        {
            int random = rnd.Next(4);
            if (random > 0)
            {
                Console.WriteLine(name + "は金縛りに遭って動けない。");
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
            return "呪い";
        }
    }
}
