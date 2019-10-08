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
    public class OrderService : IOrderService
    {
        IOrderDAL _orderDal;
        public OrderService(IOrderDAL orderDal)
        {
            _orderDal = orderDal;
        }
        public bool Add(Order entity)
        {
            return _orderDal.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Order deleted = GetByID(entityID);
            return _orderDal.Delete(deleted) > 0;
        }

        public Order GetByID(int entityID)
        {
            return _orderDal.Get(a => a.ID == entityID);
        }

        public List<Order> GetList()
        {
            return _orderDal.GetAll().ToList();
        }

        public bool Update(Order entity)
        {
            return _orderDal.Update(entity) > 0;
        }
    }
}
