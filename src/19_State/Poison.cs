using System;

namespace State
{
    public class Poison : IState
    {
        private static Poison singleton = new Poison();

        private Poison()
        {
        }
        public static IState getInstance()
        {
            return singleton;
        }

        public void AttackCMD(String name, String target)
        {
            Console.WriteLine(name + "は" + target + "に攻撃した。");
            Console.WriteLine(name + "は毒のダメージを受けた。");
        }

        public void MagicCMD(String name, String magic, String target)
        {
            Console.WriteLine(name + "は" + target + "に" + magic + "をとなえた。");
            Console.WriteLine(name + "は毒のダメージを受けた。");
        }

        public void SkillCMD(String name, String skill, String target)
        {
            Console.WriteLine(name + "は" + target + "に" + skill + "をした。");
            Console.WriteLine(name + "は毒のダメージを受けた。");
        }

        public void DefenceCMD(String name)
        {
            Console.WriteLine(name + "は身をまもっている。");
            Console.WriteLine(name + "は毒のダメージを受けた。");
        }

        public void ItemCMD(String name, String item)
        {
            Console.WriteLine(name + "は" + item + "を使用した。");
            Console.WriteLine(name + "は毒のダメージを受けた。");
        }

        public int EscapeCMD(String name)
        {
            Console.WriteLine(name + "は戦闘から逃げ出した。");
            return 1;
        }

        public override String ToString()
        {
            return "毒";
        }
    }
}
