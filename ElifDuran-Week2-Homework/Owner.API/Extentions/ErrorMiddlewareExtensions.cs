using Microsoft.AspNetCore.Builder;
using Owner.API.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Owner.API.Extentions
{
    public static class ErrorMiddlewareExtensions
    {
        // Extension method ile IApplicationBuilder altına custom methodumuzu eklenmesini sağlıyoruz.
       
            public static IApplicationBuilder UseErrorMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<ErrorMiddleware>();
            }        
    }
}
