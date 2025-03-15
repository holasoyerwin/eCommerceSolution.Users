
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infraestructure.DbContext;
using eCommerce.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TO DO: Add services to the IoC container
            //Infrastructure services often include data access, caching and other low-level components.

            services.AddTransient<IUsersRepository, UsersRepository>();

            services.AddTransient<DapperDbContext>();

            return services;
        }
    }
}
