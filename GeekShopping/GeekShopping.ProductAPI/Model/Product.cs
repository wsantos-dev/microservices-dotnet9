using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {

        [Column("name")]
        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        [Column("price", TypeName = "decimal(18,2)")]
        [Range(0.01, 99999999.99)]
        [Required]
        public decimal Price { get; set; }

        [Column("description")]
        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        [Column("category_id")]
        public long CategoryId { get; set; }

        public Category? Category { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string? ImageUrl { get; set; }
    }
}
