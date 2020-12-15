﻿using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class SubCategory:EntityRepository
    {
        public string SubCategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
