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
    public class ShoppingCartService : IShoppingCartService
    {
        IShoppingCartDAL _shoppingCartDal;
        public ShoppingCartService(IShoppingCartDAL shoppingCartDal)
        {
            _shoppingCartDal = shoppingCartDal;
        }
        public bool Add(ShoppingCart entity)
        {
            return _shoppingCartDal.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            ShoppingCart deleted = GetByID(entityID);
            return _shoppingCartDal.Delete(deleted)>0;
        }

        public ShoppingCart GetByID(int entityID)
        {
            return _shoppingCartDal.Get(a => a.ID == entityID);
        }

        public List<ShoppingCart> GetList()
        {
            return _shoppingCartDal.GetAll().ToList();
        }

        public bool Update(ShoppingCart entity)
        {
            return _shoppingCartDal.Update(entity) > 0;
        }

        public ShoppingCart GetByFilter(Expression<Func<ShoppingCart, bool>> filter)
        {
            return _shoppingCartDal.Get(filter);
        }

        public List<ShoppingCart> GetListByFilter(Expression<Func<ShoppingCart, bool>> filter)
        {
            return _shoppingCartDal.GetAll(filter).ToList(); ;
        }
    }
}
