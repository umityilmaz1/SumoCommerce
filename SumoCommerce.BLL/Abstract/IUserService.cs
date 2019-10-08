using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        User GetByLogin(string mail, string password);
        User GetByFilter(Expression<Func<User, bool>> filter);

    }
}
