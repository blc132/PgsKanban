using Microsoft.EntityFrameworkCore;
using PGS.Kanban.Domain.Models;

namespace PGS.Kanban.Domain
{
    public class KanbanContext : DbContext
    {        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PgsKanban;Trusted_Connection=True;");
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<List> Lists { get; set; }
    }
}
