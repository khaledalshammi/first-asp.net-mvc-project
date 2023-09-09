using FirstProject.Models;
namespace FirstProject.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void Update(Category obj);
    }
}
