using Microsoft.EntityFrameworkCore;
using Retail.Repository;
using Retail.Repository.Implementation;
using Retail.Repository.Interface;
using Retail.Services.Implementation;
using Retail.Services.Interface;

namespace Retail.API
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
            builder.Services.AddTransient<IProductServices,ProductServices>();
            builder.Services.AddTransient<IOrderServices,OrderServices>();
            builder.Services.AddTransient<IProductRepository,ProductRepository>();
            builder.Services.AddTransient<IOrderRepository,OrderRepository>();
            builder.Services.AddAutoMapper(typeof(Repository.AutoMapper));
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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