using FirstProject.DataAccess.Data;
using FirstProject.DataAccess.Repository.IRepository;

namespace FirstProject.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category{ get; set; }
        public IProductRepository Product{ get; set; }
        public IProductImageRepository ProductImage { get; set; }
        public ICompanyRepository Company { get; set; }
        public IShoppingRepository ShoppingCart { get; set; }
        public IApplicationUserRepository ApplicationUser { get; set; }
        public IOrderDetailRepository OrderDetail { get; set; }
        public IOrderHeaderRepository OrderHeader { get; set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ShoppingCart = new ShoppingRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            ProductImage = new ProductImageRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
