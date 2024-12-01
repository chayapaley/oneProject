
using lesson3.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace lesson3.Repositories
{
    public class tasksRepositories : ItasksRepository

       
    {
        private readonly TasksDbContext _context;
       
        public tasksRepositories(TasksDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tasks> GetAll()
        {
            return _context.Tasks.ToList();
         
        }

        public IEnumerable<Tasks> GetAlltasksbyid(int id)
        {
            return _context.Tasks;
        }
        public IEnumerable<Tasks> createTask(Tasks task)
        {
           return _context.Tasks.Add(task);

          
        }

    }
}
