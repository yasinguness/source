﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta06_AdoNet
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
                
        }
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        
    }
}
