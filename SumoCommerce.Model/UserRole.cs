using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class UserRole:BaseEntity
    {
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
