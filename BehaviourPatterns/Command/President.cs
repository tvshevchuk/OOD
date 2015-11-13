using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Command
{
    class President
    {
        ICommand command;

        public string Name { get; set; }

        public President(string name)
        {
            Name = name;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void MakeHardDecision()
        {
            command.Execute();
        }
    }
}
