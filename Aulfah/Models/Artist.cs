using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aulfah.Models
{
    internal class Artist : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistID { get; set; }
        public string Skills { get; set; }
        public string Courses { get; set; }
        public string socialMedia { get; set; }
        public string ServicesType { get; set; }

        [ForeignKey("Service")]
        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public void addService(string Service)
        {

        }

        public void uodateCatalog(Product product) { }
        public override void upateProfile()
        {
            throw new NotImplementedException();
        }

        public override bool verifyLogin()
        {
            throw new NotImplementedException();
        }

        public override void login()
        {
            throw new NotImplementedException();
        }

        public override void register()
        {
            throw new NotImplementedException();
        }

        
    }
}
