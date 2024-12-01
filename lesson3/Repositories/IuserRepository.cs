using lesson3.Models;

namespace lesson3.Repositories
{
    public interface IuserRepository
    {
        public User getUserByUserId(int id);
        void Update(User user);
        void Delete(int id);
        public List<Tasks> GetAllTasksbyUserId(int id);
    }
}
