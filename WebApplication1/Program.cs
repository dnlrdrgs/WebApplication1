using SenaiApi.Service.Services;
using SenaiApi.Service.Interface;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Repository.Repositorio;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Repository.Contexts;
using SenaiApi.Repository;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Injeção de Dependencia

            builder.Services.AddScoped<IPessoasServices, PessoasServices>();

            builder.Services.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddDbContext<ApiContext>(options => options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:ApiSenai")));

            #endregion

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}