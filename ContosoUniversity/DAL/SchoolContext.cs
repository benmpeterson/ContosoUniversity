using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        //This code creates a DbSet property for each entity set. In Entity Framework terminology, an entity set typically corresponds to a database table, 
        //and an entity corresponds to a row in the table.
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This piece of code prevents names being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}