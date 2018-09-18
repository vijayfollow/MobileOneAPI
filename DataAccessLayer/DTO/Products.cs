﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Products
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
        public int CurrencyId { get; set; }
        public string Description { get; set; }
        public int SimType { get; set; }
        public int BatteryCapacity { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public int InsertUpdateType { get; set; }

        public int OrderId { get; set; }
        

    }
    public enum InsertUpdateType
    {
        Insert = 1,
        Update = 2
    }
}
