using FirstProject.DataAccess.Data;
using FirstProject.DataAccess.Repository.IRepository;
using FirstProject.Models;

namespace FirstProject.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Update(ApplicationUser obj)
        {
            _db.ApplicationUsers.Update(obj);
        }
    }
}
