using Ecom.Core.interfaces;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection InfrastructureServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepositry<>), typeof(GenericRepositry<>));
            //services.AddScoped<IGategoryRepositry, GategoryRepositry>();
            //services.AddScoped<IProductRepositry, ProductRepositry>();
            //services.AddScoped<IPhotoRepositry, PhotoRepositry>();  
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("EComDataBase")));

            return services;
        }
    }
}
