using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace L03_BasicsOfConfiguration_HW1
{
    public class MaxEmployeesService
    {
        public string GetMaxEmployees(IEnumerable<IConfigurationSection> sections)
        {
            var maxEmpl = sections.Max(s => int.Parse(s.GetSection("Employees").Value));

            return $"Max employees: {maxEmpl}";
        }
    }
}
