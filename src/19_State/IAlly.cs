using System;

namespace State
{
    interface IAlly
    {
        void SetMagic(String[] magic);
        void SetSkill(String[] skill);
        void SetItem(String[] item);
        void ChangeState(IState state);
        void Attack(String target);
        void Magic(int magic, String target);
        void Skill(int skill, String target);
        void Defence();
        void Item(int item);
        int Escape();
    }
}
