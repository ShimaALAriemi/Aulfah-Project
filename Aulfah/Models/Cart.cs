
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aulfah.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public float? totatPrice { get; set; }
        public ICollection<Product>? Products { get; set; } = new List<Product>();
        public ICollection<Customer>? Customers { get; set; }

        public void addCartItem(Product product) { }
        public void updateOuantity() { }
        public void viewCartDetails() { }
        public void chechOut() { }

    }
}
