﻿using DigitalX.GatDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalX.Models
{
    public class Item
    {
        public Product product
        {
            get;
            set;
        }

        public int quantity
        {
            get; set;
        }
    }
}