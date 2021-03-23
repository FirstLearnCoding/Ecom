using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Dtos
{
    public class ProfileCreateDtos
    {
        [Required]
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
