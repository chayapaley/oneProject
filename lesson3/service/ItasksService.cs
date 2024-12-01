using lesson3.Models;


namespace lesson3.service
{
    public interface ItasksService

    {

        public IEnumerable<Tasks> GetAllTasks();
        public IEnumerable<Tasks> GetAllTasksbyid(int id);
        public IEnumerable<Tasks> createTask(Tasks task);

    }
}

