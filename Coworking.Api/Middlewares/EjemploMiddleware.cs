using Coworking.Api.Middlewares;

namespace Microsoft.AspNetCore.Builder
{
    public static class EjemploMiddleware
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseEjemploMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Ejemplo>();

            return builder;
        }

    }
}
