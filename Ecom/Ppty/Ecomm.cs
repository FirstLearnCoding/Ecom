using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Ppty
{
    public class Ecomm
    {
        // variables for stor and access 
        // It create a table in database with primary key is product name
        [Key]
        public string ProductName { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
