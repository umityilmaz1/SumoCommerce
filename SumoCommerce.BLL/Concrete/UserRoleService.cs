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
    public class UserRoleService : IUserRoleService
    {
        IUserRoleDAL _userRoleDal;
        public UserRoleService(IUserRoleDAL userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }
        public bool Add(UserRole entity)
        {
            return _userRoleDal.Add(entity) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            UserRole deleted = GetByID(entityID);
            return _userRoleDal.Delete(deleted) > 0;
        }

        public UserRole GetByID(int entityID)
        {
            return _userRoleDal.Get(a => a.ID == entityID);
        }

        public List<UserRole> GetList()
        {
            return _userRoleDal.GetAll().ToList();
        }

        public bool Update(UserRole entity)
        {
            return _userRoleDal.Update(entity) > 0;
        }
    }
}
