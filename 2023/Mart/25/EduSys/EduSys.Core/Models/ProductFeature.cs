﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.Models
{
    public class ProductFeature : BaseEntity
    {
        public string Color { get; set; }
        public int Height { get; set; }
        public int With { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
