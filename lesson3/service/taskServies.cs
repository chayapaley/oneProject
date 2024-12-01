using lesson3.Models;
using lesson3.Repositories;

namespace lesson3.service
{
    public class taskServies: ItasksService
    {
        private readonly ItasksRepository _tasksRepositories;

        public taskServies(ItasksRepository tasksRepositories)
        {
            _tasksRepositories = tasksRepositories;
        }

        public IEnumerable<Tasks> createTask(Tasks task)
        {
       
         /*   if(task.userId!=null)*/
            return _tasksRepositories.createTask(task);
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _tasksRepositories.GetAll();
        }

        
        public IEnumerable<Tasks> GetAllTasksbyid(int id)
        {
            return _tasksRepositories.GetAlltasksbyid(id);
        }
    }
}
