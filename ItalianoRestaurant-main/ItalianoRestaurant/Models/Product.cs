using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItalianoRestaurant.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        [ForeignKey("Categories")]
        public int categoryId { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
        public bool hasAllergens { get; set; }
    }
}





