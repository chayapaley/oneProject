using lesson3.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace lesson3.Repositories
{
    public class TasksDbContext: DbContext
    {

        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {

        }
        public DbSet<Tasks> Tasks { get; set; }
        public  DbSet<User> User { get; set; }

      /*  internal void SaveChanges()
        {
            throw new NotImplementedException();
        }*/
    }
}
