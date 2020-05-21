using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCommand.Models;

namespace PracticeCommand.Data
{
    public class MockCommandRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Holla", Line = "Chai", Platform = "Two Face" }; 
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Holla", Line = "Chai", Platform = "Two Face" },
                new Command { Id = 2, HowTo = "Raheem", Line = "Come", Platform = "Faze Alone" },
                new Command { Id = 3, HowTo = "Scenery", Line = "Place", Platform = "Balck Faze" }
            };

            return commands;

        }
    }
}
