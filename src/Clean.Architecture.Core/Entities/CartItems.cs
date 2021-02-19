﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    class CartItems
    {
        public int Id {get;set;} 
        public int Quantity {get;set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }


    }
}
