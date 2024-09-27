
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Persistence.Context;
using GerenciarCaixa.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCaixa.API
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
            builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
