using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
   public class Cart
    {
        [Key]
        public int CartId { get; set; }
        
        public int ProductId { get; set; }
        
        public string? Productimage { get; set; }   
        
        public string? ProductName { get; set; }
        
        public string? Brand { get; set; }
        public int Quantity { get; set; }

        public float Price { get; set; }
        [ForeignKey("Product")]
        public int id { get; set; }

        public Product? Product { get; set; }


    }
}
