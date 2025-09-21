 
using Ecom.Infrastructure;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
namespace Ecom.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Extension method to add infrastructure services
            IServiceCollection serviceCollection = builder.Services.InfrastructureServices(builder.Configuration);

            //builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(builder.Environment.ContentRootPath));  //--77

            builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());  

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
