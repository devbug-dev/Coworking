using Microsoft.Extensions.DependencyInjection;

using Coworking.DataContracts.Repositories;
using Coworking.DataAccess.Repositories;
using Coworking.AppContracts.Services;
using Coworking.Application.Services;
using Coworking.Application.Configuration;
using Coworking.AppContracts.ApiCaller;
using Coworking.Application.ApiCaller;

namespace Coworking.CrossCutting.Register
{
    // INVERSION OF CONTROL 
    public static class IoCRegister
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterOthers(services);

            return services;
        }
        private static IServiceCollection RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IOfficeService, OfficesService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IServicesService, ServicesService>();

            return services;
        }

        private static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IServicesRepository, ServicesRepository>();

            return services;
        }

        private static IServiceCollection RegisterOthers(IServiceCollection services)
        {

            services.AddTransient<IAppConfig, AppConfig>();
            services.AddTransient<IApiCaller, ApiCaller>();

            return services;
        }

    }
}