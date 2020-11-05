using System;

namespace State
{
    public class Paralyzed : IState
    {
        private static Paralyzed singleton = new Paralyzed();

        private Paralyzed()
        {

        }

        public static IState getInstance()
        {
            return singleton;
        }

        public void AttackCMD(String name, String target)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
        }

        public void MagicCMD(String name, String magic, String target)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
        }

        public void SkillCMD(String name, String skill, String target)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
        }

        public void DefenceCMD(String name)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
        }

        public void ItemCMD(String name, String item)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
        }

        public int EscapeCMD(String name)
        {
            Console.WriteLine(name + "は体がしびれて動けない。");
            return 0;
        }

        public override String ToString()
        {
            return "麻痺";
        }
    }
}
