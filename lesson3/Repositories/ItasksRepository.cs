using lesson3.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace lesson3.Repositories
{
    public interface ItasksRepository
    {
        public IEnumerable<Tasks> GetAll();
        public IEnumerable<Tasks> GetAlltasksbyid(int id);
        public IEnumerable<Tasks> createTask(Tasks task);

    }
}
