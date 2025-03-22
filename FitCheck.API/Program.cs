using FitCheck.BAL.Interfaces;
using FitCheck.BAL.Services;
using FitCheck.Common.Mapper;
using FitCheck.DAL.DataContext;
using FitCheck.DAL.Interfaces;
using FitCheck.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Globalization;


namespace FitCheck.API
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

            var defaultConnectionString = builder.Configuration.GetConnectionString("FitCheck");
            builder.Services.AddDbContext<FitCheckDbContext>(options => 
                options.UseSqlServer(defaultConnectionString));

            builder.Host.UseSerilog((context, config) =>
                config.ReadFrom.Configuration(context.Configuration));

            //DAL
            builder.Services.AddScoped<IBodyMeasurementRepository, BodyMeasurementRepository>();

            //BAL
            builder.Services.AddScoped<IBodyMeasurementService, BodyMeasrumentService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

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
