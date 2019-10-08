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
   public class AddressService : IAddressService
    {
        IAddressDAL _addressDAL;

        public AddressService(IAddressDAL addressDAL)
        {
            _addressDAL = addressDAL;
        }
        public bool Add(Address entity)
        {
            return _addressDAL.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Address address = GetByID(entityID);
           return _addressDAL.Delete(address) > 0;

        }

        public Address GetByID(int entityID)
        {
           return _addressDAL.Get(a=>a.ID==entityID);
        }

        public List<Address> GetList()
        {
            return _addressDAL.GetAll().ToList();
        }

        public bool Update(Address entity)
        {
            return _addressDAL.Update(entity) > 0;
        }
    }
}
