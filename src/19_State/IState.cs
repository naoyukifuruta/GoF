using System;

namespace State
{
    public interface IState
    {
        void AttackCMD(string name, string target);
        void MagicCMD(string name, string magic, string target);
        void SkillCMD(string name, string skill, string target);
        void DefenceCMD(string name);
        void ItemCMD(string name, string item);
        int EscapeCMD(string name);
    }
}
