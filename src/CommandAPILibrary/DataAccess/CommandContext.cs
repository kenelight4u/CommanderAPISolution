using CommandAPILibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPILibrary.DataAccess
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }

        public DbSet<Command> CommandItems { get; set; }
    }
}