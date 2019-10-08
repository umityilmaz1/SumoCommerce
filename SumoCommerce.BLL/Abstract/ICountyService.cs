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
        List<County> GetByFilter(Expression<Func<County, bool>> filter);
    }
}
