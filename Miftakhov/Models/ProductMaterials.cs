using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miftakhov.Models
{
    public class ProductMaterials
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public string MaterialId { get; set; }

        [Required]
        public double RequiredQuantity { get; set; }
        public Material Material { get; set; }
    }
}
