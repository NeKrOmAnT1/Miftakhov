using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miftakhov.Models
{
    public class MaterialType
    {
        [Key]
        public int MaterialTypeId { get; set; }

        [Required]
        public string TypeName { get; set; } = string.Empty;

        [Required]
        public double DefectPercentage { get; set; }
    }
}
