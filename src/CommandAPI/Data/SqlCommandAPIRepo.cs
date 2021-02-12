using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPILibrary.DataAccess;
using CommandAPILibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public SqlCommandAPIRepo(CommandContext context)
        {
            this._context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
                throw new ArgumentNullException(nameof(cmd));
            
            _context.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
                throw new ArgumentNullException(nameof(cmd));
            
            _context.CommandItems.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        // public async Task<Command> GetCommandByIdAsync(int id)
        // {
        //     return await _context.CommandItems.FindAsync(id);
        // }

        // public async Task<bool> SaveChangesAsync()
        // {
        //     return await _context.SaveChangesAsync() >= 0;
        // }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            // We don't need to do anything here
        }
    }
}