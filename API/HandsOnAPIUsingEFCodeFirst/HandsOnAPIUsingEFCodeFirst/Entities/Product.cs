using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(20)]
        [Column(TypeName ="varchar")]
        [Required]
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }
    }
}
