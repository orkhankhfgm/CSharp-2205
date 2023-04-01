using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.DTOs
{
    public class ProductFeatureDto : BaseDto
    {
        public string Color { get; set; }
        public int Height { get; set; }
        public int With { get; set; }
        public int ProductId { get; set; }
    }
}
