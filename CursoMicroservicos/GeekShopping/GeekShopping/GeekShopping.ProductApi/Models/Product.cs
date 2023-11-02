using GeekShopping.ProductApi.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductApi.Models
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("Name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Column("Price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string? Description { get; set; }

        [Column("CategoryName")]
        [StringLength(50)]
        public string? CategoryName { get; set;}

        [Column("ImagemUrl")]
        [StringLength(300)]
        public string? ImagemUrl { get; set;}
    }
}
