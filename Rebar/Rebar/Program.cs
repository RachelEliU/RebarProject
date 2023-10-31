using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using Rebar.Model;
using Rebar.Services;

namespace Rebar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /////
            string connectionString = "mongodb://127.0.0.1:27017";
            string databaseName = "reber_db";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            /////
            var builder = WebApplication.CreateBuilder(args);
            Console.WriteLine("Hello");
            // Add services to the container.
            builder.Services.Configure<RebarStoreDataBaseSetting>(builder.Configuration.GetSection(nameof(RebarStoreDataBaseSetting)));
            builder.Services.AddSingleton<IRebarStoreDataBaseSetting>(sp=>sp.GetRequiredService<IOptions<RebarStoreDataBaseSetting>>().Value);
            builder.Services.AddSingleton<IMongoClient>(s=> new MongoClient(builder.Configuration.GetValue<string>("RebarStoreDataBaseSetting:ConnectionString")));
            builder.Services.AddScoped<IOrderService,OrderService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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