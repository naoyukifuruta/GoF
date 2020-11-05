using System;

namespace State
{
    public class Brave : IAlly
    {
        private string name;
        private string[] magic;
        private string[] skill;
        private string[] item;
        private IState state;

        public Brave(string name)
        {
            this.name = name;
            this.state = Normal.GetInstance();
        }

        public void SetMagic(string[] magic)
        {
            this.magic = magic;
        }

        public void SetSkill(string[] skill)
        {
            this.skill = skill;
        }

        public void SetItem(string[] item)
        {
            this.item = item;
        }

        public void ChangeState(IState state)
        {
            this.state = state;
            Console.WriteLine(this.name + "は" + this.state + "状態になった。");
        }

        public void Attack(string target)
        {
            state.AttackCMD(name, target);
        }

        public void Magic(int magicNum, string target)
        {
            state.MagicCMD(name, magic[magicNum], target);
        }

        public void Skill(int skillNum, string target)
        {
            state.SkillCMD(name, skill[skillNum], target);
        }

        public void Defence()
        {
            state.DefenceCMD(name);
        }

        public void Item(int itemNum)
        {
            state.ItemCMD(name, item[itemNum]);
        }

        public int Escape()
        {
            return state.EscapeCMD(name);
        }
    }
}
