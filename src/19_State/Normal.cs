using System;

namespace State
{
    public class Normal : IState
    {
        private static Normal singleton = new Normal();

        private Normal()
        {
        }

        public static IState GetInstance()
        {
            return singleton;
        }

        public void AttackCMD(String name, String target)
        {
            Console.WriteLine(name + "は" + target + "に攻撃した。");
        }

        public void MagicCMD(String name, String magic, String target)
        {
            Console.WriteLine(name + "は" + target + "に" + magic + "をとなえた。");
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
            return "通常";
        }
    }
}
