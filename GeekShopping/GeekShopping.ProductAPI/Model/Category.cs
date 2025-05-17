using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("category")]
    public class Category : BaseEntity
    {
        [Column("name")]
        [Required]
        public string? Name  { get; set; }

        [Column("description")]
        [StringLength(200)]
        public string? Description { get; set; }

        ICollection<Product> Products { get; set; } = [];
    }
}
