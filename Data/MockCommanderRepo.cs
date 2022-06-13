using CommanderAPI.Models;

namespace CommanderAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an Egg", Line="Boil Water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Bake Bread", Line="Get an Oen", Platform="In the Oven"},
                new Command{Id=0, HowTo="Make a cup of tea", Line="Put a teabug in a cup", Platform="Kettle and Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an Egg", Line="Boil Water", Platform="Kettle and Pan"};
        }
    }
}