using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
   public class Order
    {
        [Key]
        public int OrderId { get; set; } 
        public int  CustomerId { get; set; }
        public string? CustomerName { get; set; }    
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        [ForeignKey("Product")]
        public int id { get; set; }

        public Product? Product { get; set; }


        [ForeignKey("RegisterModel")]
        public int UserId { get; set; }

        public RegisterModel? RegisterModel { get; set; }


    }
}
