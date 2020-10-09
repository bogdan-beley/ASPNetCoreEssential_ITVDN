using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace L03_BasicsOfConfiguration_HW2
{
    public class TimeService
    {
        public string GetTime()
        {
            return $"{DateTime.Now.ToLongTimeString()}";
        }
    }
}
