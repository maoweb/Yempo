using Yempo_API.Data;
using Yempo_API.Models;
using Yempo_API.Repository.IRepository;

namespace Yempo_API.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext _db;
        public PersonRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
