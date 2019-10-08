using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Abstract
{
    public interface IShoppingCartService:IBaseService<ShoppingCart>
    {
        ShoppingCart GetByFilter(Expression<Func<ShoppingCart, bool>> filter);
        List<ShoppingCart> GetListByFilter(Expression<Func<ShoppingCart, bool>> filter);
    }
}
