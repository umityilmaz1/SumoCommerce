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
    public class UserService : IUserService
    {
        IUserDAL _userDal;
        public UserService(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public bool Add(User entity)
        {
            return _userDal.Add(entity) > 0;
        }
        public bool Update(User entity)
        {
            return _userDal.Update(entity) > 0;
        }
        public bool DeleteByID(int entityID)
        {
            User deleted = GetByID(entityID);
            return _userDal.Delete(deleted)>0;
        }
        public User GetByID(int entityID)
        {
            return _userDal.Get(a => a.ID == entityID);
        }
        public List<User> GetList()
        {
            return _userDal.GetAll().ToList();
        }
        public User GetByFilter(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }
        public List<User> GetListByFilter(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetAll(filter).ToList();
        }
    }
}
