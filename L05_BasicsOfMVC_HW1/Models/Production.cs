using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L05_BasicsOfMVC_HW1.Models
{
    public class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
