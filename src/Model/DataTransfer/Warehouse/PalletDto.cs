﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarelogManager.Model.DataTransfer.Common;

namespace WarelogManager.Model.DataTransfer.Warehouse
{
    [Table("Product")]
    public class PalletDto : BaseEntity
    {
        [ForeignKey("Owner")]
        public int? OwnerId { get; set; }
        public CompanyDto Owner { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DispacheTime { get; set; }
    }
}