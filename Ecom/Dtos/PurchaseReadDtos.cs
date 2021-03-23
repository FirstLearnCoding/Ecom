using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Dtos
{
    public class PurchaseReadDtos
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
