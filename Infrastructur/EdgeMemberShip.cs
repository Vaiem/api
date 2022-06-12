using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace ReservateAPI.Infrastructur
{
    public class EdgeMemberShip
    {
        RequestDelegate nextDelegat;
        public EdgeMemberShip(RequestDelegate next)
        {
            nextDelegat = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value == "/Oder")
            {
                await context.Response.WriteAsync("Test", Encoding.UTF8);
            }
            else
            {
                await nextDelegat.Invoke(context);
            }
        }


    }
}
