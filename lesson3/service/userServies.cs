using lesson3.Models;
using lesson3.Repositories;

namespace lesson3.service
{
    public class userServies : IuserServies
    {

        public readonly IuserRepository _userRepository;
        public userServies(IuserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<Tasks> GetAllTasksbyUserId(int id)
        {
          return _userRepository.GetAllTasksbyUserId(id);
        }

        public User getUserByUserId(int id)
        {
            return _userRepository.getUserByUserId(id);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
