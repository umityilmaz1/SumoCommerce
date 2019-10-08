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
    public class OrderDetailService : IOrderDetailService
    {
        IOrderDetailDAL _orderDetailDal;
        public OrderDetailService(IOrderDetailDAL orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public bool Add(OrderDetail entity)
        {
            return _orderDetailDal.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            OrderDetail deleted = GetByID(entityID);
            return _orderDetailDal.Delete(deleted) > 0;
        }

        public OrderDetail GetByID(int entityID)
        {
            return _orderDetailDal.Get(a => a.ID == entityID);
        }

        public List<OrderDetail> GetList()
        {
            return _orderDetailDal.GetAll().ToList();
        }

        public bool Update(OrderDetail entity)
        {
            return _orderDetailDal.Update(entity) > 0;
        }
    }
}
