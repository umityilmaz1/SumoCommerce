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
    public class CategoryService : ICategoryService
    {

        ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public bool Add(Category entity)
        {
            return _categoryDAL.Add(entity) >0;
        }

        public bool DeleteByID(int entityID)
        {
            Category cat = GetByID(entityID);
            return _categoryDAL.Delete(cat) > 0;
        }

        public Category GetByID(int entityID)
        {
            return _categoryDAL.Get(a => a.ID == entityID);
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetAll().ToList();
        }

        public bool Update(Category entity)
        {
            return _categoryDAL.Update(entity) > 0;
        }
    }
}
