using DAL.Repositories.AddressRepository;
using DAL.Repositories.CartRepository;
using DAL.Repositories.DiscountRepository;
using DAL.Repositories.EventRepository;
using DAL.Repositories.OrderRepository;
using DAL.Repositories.TicketDiscountRepository;
using DAL.Repositories.TicketRepository;
using DAL.Repositories.UserRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Helper.Seeders;
using Project.Services.EventService;
using Project.Services.UserService;

namespace Project.Helper.Extensions
{
    [Route("api/[controller]")]
    [ApiController]
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<IDiscountRepository, DiscountRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ITicketDiscountRepository, TicketDiscountRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IEventService, EventService>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddScoped<EventSeeder>();
            return services;
        }
    }
}
