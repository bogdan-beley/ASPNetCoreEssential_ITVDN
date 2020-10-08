using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L02_StructureOfTheBasicProjectAndMiddleware_HW3
{
    public class CompanyDataMiddleware
    {
        private readonly RequestDelegate next;

        public CompanyDataMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string method = context.Request.Method;
            if (method == "GET")
            {
                Company c1 = new Company()
                {
                    Id = 1,
                    Name = "Amazon",
                    Address = "440 Terry Avenue North, Seattle, WA 98109, USA",
                    Phone = "(206) 266-1000"
                };

                await context.Response.WriteAsync(
                    $"Company Name: {c1.Name}\n" +
                    $"Address: {c1.Address}\n" +
                    $"Phone: {c1.Phone}");
            }
            else
                await next.Invoke(context);
        }
    }
}
