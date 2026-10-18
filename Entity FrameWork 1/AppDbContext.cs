
using Microsoft.EntityFrameworkCore;

namespace Entity_FrameWork_1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\MSSQLSERVER01;Database=EfHomeworkDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

    }
}
