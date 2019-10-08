using Ninject.Modules;
using SumoCommerce.DAL.Abstract;
using SumoCommerce.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.IoC.Ninject
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserDAL>().To<UserDAL>();
            Bind<IAddressDAL>().To<AddressDAL>();
            Bind<ICategoryDAL>().To<CategoryDAL>();
            Bind<ICityDAL>().To<CityDAL>();
            Bind<ICountyDAL>().To<CountyDAL>();
            Bind<IOrderDAL>().To<OrderDAL>();
            Bind<IOrderDetailDAL>().To<OrderDetailsDAL>();
            Bind<IProductDAL>().To<ProductDAL>();
            Bind<IShoppingCartDAL>().To<ShoppingCartDAL>();
            Bind<IUserRoleDAL>().To<UserRoleDAL>();
        }
    }
}
