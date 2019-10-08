using SumoCommerce.BLL.Abstract;
using SumoCommerce.DAL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.BLL.Concrete
{
    public class CityService : ICityService
    {
        ICityDAL _cityDal;
        public CityService(ICityDAL cityDal)
        {
            _cityDal = cityDal;
        }
        public bool Add(City entity)
        {
            return _cityDal.Add(entity)>0;
        }

        public bool DeleteByID(int entityID)
        {
            City deleted = GetByID(entityID);
            return _cityDal.Delete(deleted) > 0;
        }

        public City GetByID(int entityID)
        {
            return _cityDal.Get(a => a.ID == entityID);
        }

        public List<City> GetList()
        {
            return _cityDal.GetAll().ToList();
        }

        public bool Update(City entity)
        {
            return _cityDal.Update(entity) > 0;
        }
    }
}
