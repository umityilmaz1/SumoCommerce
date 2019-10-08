using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Abstract
{
    public interface ICountyService:IBaseService<County>
    {
        County GetByFilter(Expression<Func<County, bool>> filter);
        List<County> GetListByFilter(Expression<Func<County, bool>> filter);
    }
}
