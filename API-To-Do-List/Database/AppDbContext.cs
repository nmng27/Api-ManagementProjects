using API_To_Do_List.Model.Activitie;
using API_To_Do_List.Model.ContractModel;
using API_To_Do_List.Model.EmployeerModel;
using API_To_Do_List.Model.ProjectModel;
using API_To_Do_List.Model.CustomerModel;
using Microsoft.EntityFrameworkCore;

namespace API_To_Do_List.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<EmployeerModel> Employeers { get; set; }
        public DbSet<ActivityModel> Activity {  get; set; }
        public DbSet<ProjectModel> Project { get; set; }
        public DbSet<ContractModel> Contract { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "Server=localhost;Database=Projeto;Trusted_Connection=True;\r\n";
            optionsBuilder.UseSqlServer(cs);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
