﻿using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Deal : NamedEntityes
    {
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public virtual Client Client { get; set; }
    }
}
