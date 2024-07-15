using DiceSimulationProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DiceSimulationProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<DiceResultModel> DiceResults { get; set; }
        public DbSet<DiceRollModel> DiceRoll { get; set; }
    }
}
