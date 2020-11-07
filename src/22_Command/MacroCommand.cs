using System;
using System.Collections;
using System.Collections.Generic;

namespace Command
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void Execute()
        {
            if (commands.Count > 0)
            {
                IEnumerator enumerator = commands.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ICommand obj = (ICommand)enumerator.Current;
                    obj.Execute();
                }
            }
        }

        public virtual void Apppend(ICommand addCommand)
        {
            if (addCommand != this) commands.Push(addCommand);
        }

        public void Undo()
        {
            if (commands.Count > 0) commands.Pop();
        }

        public void Clear() => commands.Clear();
    }
}
