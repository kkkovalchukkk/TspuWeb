﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class UserPurchase
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public decimal Price { get; set; }

    }
}
