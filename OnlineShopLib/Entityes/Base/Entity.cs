﻿using OnlineShop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShopLib.Entityes.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
    
    
}
