using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using songAPI.Data;
using System.Text.Json.Serialization;

namespace songAPI;

public class Program
{
    public static void Main(string[] args)
    {
        // CORS policy for UI access
        var CORSPolicy = "CORSPolicy";
        
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddCors( options => 
        {
            options.AddPolicy( name: CORSPolicy,
                                policy =>
                                {
                                    policy.WithOrigins("http://localhost:4200")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                                });
        });

        builder.Services.AddControllers().AddJsonOptions( options => 
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add Database Context for EF Core on Azure
        builder.Services.AddDbContext<DataContext>(options => 
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("run"));
        });

        var app = builder.Build();

        // Use our new CORS Policy
        app.UseCors(CORSPolicy);

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
