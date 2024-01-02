using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aulfah.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductNane { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        
        public ICollection<Cart>? Cart { get; set; } = new List<Cart>();
        public void addToCart(Product product) { }
    }
}