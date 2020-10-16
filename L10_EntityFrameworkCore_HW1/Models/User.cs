using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L10_EntityFrameworkCore_HW1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string FName { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string LName { get; set; }

        [Required, Range(1, 100)]
        public int Age { get; set; }
    }
}
