using Lab10.DB;
using Microsoft.EntityFrameworkCore;
using System;
namespace Lab10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddDbContext<PlantdbContext>(opt =>
                opt.UseInMemoryDatabase("Lab10"));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();


            app.MapControllers();


            app.Run();

        }
    }
}
