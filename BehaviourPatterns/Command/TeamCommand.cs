using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Command
{
    class TeamCommand : ICommand
    {
        private Team team;

        public TeamCommand(Team team)
        {
            this.team = team;
        }
        
        public void Execute()
        {
            team.ChangeCoach();
        }
    }
}
