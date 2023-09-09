using FirstProject.DataAccess.Data;
using FirstProject.DataAccess.Repository.IRepository;
using FirstProject.Models;

namespace FirstProject.DataAccess.Repository
{
    public class ShoppingRepository : Repository<ShoppingCart>, IShoppingRepository
    {
        private ApplicationDbContext _db;
        public ShoppingRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
