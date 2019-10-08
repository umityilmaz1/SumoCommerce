using SumoCommerce.BLL.Abstract;
using SumoCommerce.DAL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Concrete
{
    public class ProductService : IProductService
    {
        IProductDAL _productDAL;

        public ProductService(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public bool Add(Product entity)
        {
            return _productDAL.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Product product = GetByID(entityID);
            return _productDAL.Delete(product) > 0;
        }

        public Product GetByID(int entityID)
        {
           return _productDAL.Get(a => a.ID == entityID);
        }

        public List<Product> GetList()
        {
            return _productDAL.GetAll().ToList();
        }

        public List<Product> GetListByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productDAL.GetAll(filter).ToList(); ;
        }

        public bool Update(Product entity)
        {
            return _productDAL.Update(entity) > 0;
        }
    }
}
