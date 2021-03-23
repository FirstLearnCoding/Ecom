using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Ppty
{
    public class Ecomm
    {
       
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
