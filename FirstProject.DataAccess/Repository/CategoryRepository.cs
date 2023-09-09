using FirstProject.DataAccess.Data;
using FirstProject.DataAccess.Repository.IRepository;
using FirstProject.Models;

namespace FirstProject.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
