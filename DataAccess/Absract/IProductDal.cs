using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Uptade(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);

    }
}
