using lesson3.Models;

namespace lesson3.service
{
    public interface IuserServies
    {
        public User getUserByUserId(int id);
        void UpdateUser(User user);
        void DeleteUser(int id);
        public IEnumerable<Tasks> GetAllTasksbyUserId(int id);
    }
}
