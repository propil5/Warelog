﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarelogManager.Client.Warehouse
{
    public class BaseRackResource
    {
        public int LocalizationY { get; set; }
        public int LocalizationX { get; set; }
        public string Localization { get; set; }
        public int ColumnNumber { get; set; }
        public int ShelfNumber { get; set; }
        public int? DepthNumber { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? RowHeight { get; set; }
        public int? ColumnWidth { get; set; }
        public bool PalletRack { get; set; }
    }
}
