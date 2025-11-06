 
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
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:4200");
                });
            }); 

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
            // ✅ 1. يجب وضع CORS بعد ExceptionMiddleware لكن قبل Authorization
            app.UseMiddleware<MiddleWare.ExcptionsMiddleware>();

            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
