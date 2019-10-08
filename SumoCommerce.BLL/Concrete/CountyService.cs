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
    public class CountyService : ICountyService
    {
        ICountyDAL _countyDal;
        public CountyService(ICountyDAL countyDal)
        {
            _countyDal = countyDal;
        }

        public bool Add(County entity)
        {
            return _countyDal.Add(entity) > 0;
        }
        public bool Update(County entity)
        {
            return _countyDal.Update(entity) > 0;
        }
        public bool DeleteByID(int entityID)
        {
            County deleted = GetByID(entityID);
            return _countyDal.Delete(deleted) > 0;
        }
        public County GetByID(int entityID)
        {
            return _countyDal.Get(a => a.ID == entityID);
        }
        public List<County> GetList()
        {
            return _countyDal.GetAll().ToList();
        }
        public County GetByFilter(Expression<Func<County, bool>> filter)
        {
            return _countyDal.Get(filter);
        }
        public List<County> GetListByFilter(Expression<Func<County, bool>> filter)
        {
            return _countyDal.GetAll(filter).ToList();
        }
    }
}
