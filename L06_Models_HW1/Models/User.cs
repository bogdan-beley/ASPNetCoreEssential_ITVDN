using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L06_Models_HW1.Models
{
    public class User
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Address { get; set; }
    }
}
