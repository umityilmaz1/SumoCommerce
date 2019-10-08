﻿using SumoCommerce.Core.DataAccess.EntityFramework;
using SumoCommerce.DAL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework
{
    public class CategoryDAL : EFRepositoryBase<Category, SumoDbContext>, ICategoryDAL
    {
    }
}
