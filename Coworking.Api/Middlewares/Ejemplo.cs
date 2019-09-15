using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Coworking.Api.Middlewares
{
    public class Ejemplo
    {

        private readonly RequestDelegate _next;

        public Ejemplo(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Cualqueir accion

            await _next(context);

            //vuelve desde el final

        }


    }
}
