using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DataAccess.Repository.IRepository
{
    public interface IShoppingRepository: IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
