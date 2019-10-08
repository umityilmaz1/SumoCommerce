using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Abstract
{
    public interface IBaseService<TEntity> where TEntity:BaseEntity
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool DeleteByID(int entity);
        TEntity GetByID(int entity);

        List<TEntity> GetList();
    }
}
