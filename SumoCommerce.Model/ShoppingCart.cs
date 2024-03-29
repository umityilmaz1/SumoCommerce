﻿using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class ShoppingCart:BaseEntity
    {
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
