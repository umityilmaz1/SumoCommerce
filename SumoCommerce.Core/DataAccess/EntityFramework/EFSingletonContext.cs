using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Core.DataAccess.EntityFramework
{
    class EFSingletonContext<TContext>where TContext : DbContext, new()
    {
        private static TContext _ctx;

        private EFSingletonContext()
        {

        }

        public static TContext GetInstance()
        {
            if (_ctx == null)
            {
                _ctx = new TContext();
            }
            return _ctx;
        }
    }
}
