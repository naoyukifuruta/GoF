using System;

namespace State
{
    public class Sleep : IState
    {
        private static Sleep singleton = new Sleep();

        private Sleep()
        {

        }

        public static IState getInstance()
        {
            return singleton;
        }

        public void AttackCMD(String name, String target)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
        }

        public void MagicCMD(String name, String magic, String target)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
        }

        public void SkillCMD(String name, String skill, String target)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
        }

        public void DefenceCMD(String name)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
        }

        public void ItemCMD(String name, String item)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
        }

        public int EscapeCMD(String name)
        {
            Console.WriteLine(name + "はねむっている。");
            Console.WriteLine(name + "は体力が回復した。");
            return 0;
        }

        public override String ToString()
        {
            return "眠り";
        }
    }
}
