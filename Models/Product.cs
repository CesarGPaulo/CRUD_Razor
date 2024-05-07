using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Razor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName ("Product Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Product Price")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
