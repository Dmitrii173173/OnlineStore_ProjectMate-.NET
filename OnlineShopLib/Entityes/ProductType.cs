﻿using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class ProductType :NamedEntityes
    {
        public virtual ICollection<Product> Products { get; set; }


    }
}
