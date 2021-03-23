using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Ppty
{
    public class Profiles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string FacebookId { get; set; }
    }
}
