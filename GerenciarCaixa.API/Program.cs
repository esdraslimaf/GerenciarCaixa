
using GerenciarCaixa.Application.Mappings;
using GerenciarCaixa.Application.Services;
using GerenciarCaixa.Domain.Interfaces.Repositories;
using GerenciarCaixa.Domain.Interfaces.Services;
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
            //builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            builder.Services.AddScoped<IMesaService, MesaService>();
            builder.Services.AddScoped<IMesaRepository, MesaRepository>();
            builder.Services.AddAutoMapper(typeof(MesaMappingProfile));
            
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
