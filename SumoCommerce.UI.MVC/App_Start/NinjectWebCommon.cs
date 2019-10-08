[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SumoCommerce.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SumoCommerce.UI.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace SumoCommerce.UI.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using SumoCommerce.BLL.Abstract;
    using SumoCommerce.BLL.Concrete;
    using SumoCommerce.BLL.IoC.Ninject;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAddressService>().To<AddressService>();
            kernel.Bind<IUserRoleService>().To<UserRoleService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<ICountyService>().To<CountyService>();
            kernel.Bind<IOrderDetailService>().To<OrderDetailService>();
            kernel.Bind<IOrderService>().To<OrderService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IShoppingCartService>().To<ShoppingCartService>();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Load(new DALModule());
        }        
    }
}
