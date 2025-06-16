using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miftakhov.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }

        [Required]
        public string TypeName { get; set; } = string.Empty;

        [Required]
        public double TypeCoefficient { get; set; }
    }
}
