using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstProject.Models;

namespace FirstProject.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository: IRepository<Company>
    {
        public void Update(Company obj);
    }
}
