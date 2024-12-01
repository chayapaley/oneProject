using lesson3.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace lesson3.Repositories
{
    public class userRepository : IuserRepository
    {
        public readonly TasksDbContext _context;
        public userRepository(TasksDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            User? user = _context.User.Find(id);

            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }

        }
           
        public List<Tasks> GetAllTasksbyUserId(int id)
        {
            var t = _context.Tasks.Where(x => x.userId == id);
            return t.ToList();
        }

        public User getUserByUserId(int id)
        {
            /*         User? u = _context.User.Where(x => x.id == id);
                        return (User)u;*/
            User? user = _context.User.Find(id);
            return user;
        }

        public void Update(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }
    } }
