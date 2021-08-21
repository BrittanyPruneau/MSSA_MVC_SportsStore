using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SportsStore.Models
{
    [Table("Product")]  // this makes it so the database shows "PRODUCT"
    public class Product
    {
        // F i e l d s   &   P r o p e r t i e s 

        public int ProductId { get; set; }
        [Column(TypeName ="varchar(40)")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName ="decimal(8,2)")] // annotations are in [ ] decimal means x amount to the right of the dec and x total digits
        public decimal Price { get; set; }
        public string Category { get; set; }


        // C o n s t r u c t o r s 

        // M e t h o d s 



    }
}
