using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
    public class Product_Details
    {
        public int Id { get; set; }
        public string? ProductImage { get; set; }
        public string? ProductName { get; set; }
        public int count { get; set; } 
        public DateTime SoldDate { get; set; }  
    }
}
