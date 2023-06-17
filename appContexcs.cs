using Microsoft.EntityFrameworkCore;



namespace ConsoleApp6
{
    public class appContexcs : DbContext

    {

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        private const string connectionString = "Server=LJUPCHO;Database=LJUPCHO123;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(connectionString); }

    }
}
