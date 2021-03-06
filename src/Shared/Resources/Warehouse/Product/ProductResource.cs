﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarelogManager.Client.Resources.Common;

namespace WarelogManager.Shared.Resources.Warehouse.Product
{
    public class ProductResource : BaseProductResource
    {
        public int Id { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
        public string AddedByEmail { get; set; }
        public string EdditedByEmail { get; set; }
    }
}
