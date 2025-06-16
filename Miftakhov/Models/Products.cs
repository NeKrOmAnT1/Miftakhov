using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miftakhov.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductTypeId { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public string Article { get; set; } = string.Empty;

        [Required]
        public double MinPartnerPrice { get; set; }

        [Required]
        public double RollWidthMeters { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }

        public double CalculatedCost => ProductMaterials?.Sum(pm => pm.RequiredQuantity * pm.Material.Price) ?? 0;

    }
}
