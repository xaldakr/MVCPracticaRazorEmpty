using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace MVCPracticaRazorEmpty.Models
{
    public class DbContexto:DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }
        public DbSet<usuario> USUARIOS { get; set; }
    }
}
