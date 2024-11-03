using LabaWebApp.API.dbContext;
using LabaWebApp.API.Repository.Interfaces;
using LabaWebApp.API.Repository.Services;
using Microsoft.EntityFrameworkCore;

namespace LabaWebApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<PatientsDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
            }); 
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin() // Разрешить любые источники
                               .AllowAnyMethod() // Разрешить любые HTTP-методы
                               .AllowAnyHeader(); // Разрешить любые заголовки
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRouting();

            app.UseCors("AllowAllOrigins"); // Применение политики CORS

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
