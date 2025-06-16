using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miftakhov.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [Required]
        public string MaterialTypeId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Required]
        public double InStock { get; set; }

        [Required]
        public double MinQty { get; set; }

        [Required]
        public double PackageQty { get; set; }

        [Required]
        public string Unit { get; set; } = "шт";
    }
}
