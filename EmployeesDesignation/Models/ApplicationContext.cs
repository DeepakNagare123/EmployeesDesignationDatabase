using Microsoft.EntityFrameworkCore;

namespace EmployeesDesignation.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) 
        {

        }
        public DbSet<EmployeeData> Employees { get; set; }
    }
}
