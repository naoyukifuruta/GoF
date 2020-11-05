using System;

namespace State
{
    public class Silence : IState
    {
        private static Silence singleton = new Silence();

        private Silence()
        {

        }

        public static IState getInstance()
        {
            return singleton;
        }

        public void AttackCMD(String name, String target)
        {
            Console.WriteLine(name + "は" + target + "に攻撃した。");
        }

        public void MagicCMD(String name, String magic, String target)
        {
            Console.WriteLine(name + "は魔法を唱えることができない。");
        }

        public void SkillCMD(String name, String skill, String target)
        {
            Console.WriteLine(name + "は" + target + "に" + skill + "をした。");
        }

        public void DefenceCMD(String name)
        {
            Console.WriteLine(name + "は身をまもっている。");
        }

        public void ItemCMD(String name, String item)
        {
            Console.WriteLine(name + "は" + item + "を使用した。");
        }

        public int EscapeCMD(String name)
        {
            Console.WriteLine(name + "は戦闘から逃げ出した。");
            return 1;
        }

        public override String ToString()
        {
            return "沈黙";
        }
    }
}
