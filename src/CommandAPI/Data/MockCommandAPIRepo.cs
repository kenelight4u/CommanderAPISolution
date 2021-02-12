using System.Collections.Generic;
using System.Threading.Tasks;
using CommandAPILibrary.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> 
            {
                new Command{
                    Id = 0, Howto = "How to generate a migration", 
                    CommandLine = "dotnet ef migrations add <name of Migration>", Platform = ".Net Core Ef"
                },
                new Command{
                    Id = 1, Howto = "Run Migrations", 
                    CommandLine = "dotnet ef database update", Platform = ".Net Core Ef"
                },
                new Command{
                    Id = 2, Howto = "List active migrations", 
                    CommandLine = "dotnet ef migrations list", Platform = ".Net Core Ef"
                }
            };
            return commands;
        }

        public Task<IEnumerable<Command>> GetAllCommandsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                    Id = 0, Howto = "How to generate a migration", 
                    CommandLine = "dotnet ef migrations add <name of Migration>", Platform = ".Net Core Ef"
                };
        }

        public Task<Command> GetCommandByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}