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
            var largestCompany = sections.Where(s => int.Parse(s.GetSection("Employees").Value) == sections.Max(y => int.Parse(y.GetSection("Employees").Value))).FirstOrDefault();
            
            return $"The company with the largest number of employees: {largestCompany.Key} ({largestCompany.GetSection("Employees").Value})";
        }
    }
}
