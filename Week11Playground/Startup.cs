
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Week11Playground.Data.Database;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Services;
using Week11Playground.Services.Interfaces;

namespace Week11Playground
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("settings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IDevilFruitService, DevilFruitService>();
            builder.Services.AddSingleton<IDevilFruitWeaponService, DevilFruitWeaponService>();
            builder.Services.AddSingleton<IMemberService, MemberService>();
            builder.Services.AddSingleton<IMemberSkillService, MemberSkillService>();
            builder.Services.AddSingleton<IMemberWeaponService, MemberWeaponService>();
            builder.Services.AddSingleton<IMemberDevilFruitService, MemberDevilFruitService>();
            builder.Services.AddSingleton<IOnePieceService, OnePieceService>();
            builder.Services.AddSingleton<IOrganizationService, OrganizationService>();
            builder.Services.AddSingleton<ISkillService, SkillService>();
            builder.Services.AddSingleton<IWeaponService, WeaponService>();
            builder.Services.AddSingleton<IUnitOfWork>(s => s.GetService<OnePieceContext>()!)
            .AddDbContext<OnePieceContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("OnePieceContext")));

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
