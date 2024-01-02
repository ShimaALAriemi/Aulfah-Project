

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aulfah.Models
{
    public class Customer : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [ForeignKey("Cart")]
        public int? CartId { get; set; }
        public Cart Cart { get; set; }

        public void chooseProduct(Product product)
        {

        }

        public Service postService()
        {
            return new Service();
        }

        public override void login()
        {
            throw new NotImplementedException();
        }

        public override void register()
        {
            throw new NotImplementedException();
        }

        public override void upateProfile()
        {
            throw new NotImplementedException();
        }

        public override bool verifyLogin()
        {
            throw new NotImplementedException();
        }
    }
}
