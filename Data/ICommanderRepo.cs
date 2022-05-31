using CommanderAPI.Models;

namespace CommanderAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}