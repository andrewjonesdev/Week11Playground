
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
            builder.Services.AddSingleton<IOnePieceService, OnePieceService>();
            builder.Services.AddSingleton<IOrganizationService, OrganizationService>();
            builder.Services.AddSingleton<ISkillService, SkillService>();
            builder.Services.AddSingleton<IWeaponService, WeaponService>();
            builder.Services.AddScoped<IUnitOfWork>(s => s.GetService<OnePieceContext>()!)
            .AddDbContext<OnePieceContext>(options =>
                options.UseSqlServer(GetAppSettings("OnePieceContext")));

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


        internal static string GetAppSettings(string settingKey, bool isRequired = true)

        {

            var environmentVariable = Environment.GetEnvironmentVariable(settingKey, EnvironmentVariableTarget.Process);




            if (string.IsNullOrWhiteSpace(environmentVariable) && isRequired)

                throw new ApplicationException(

                    $"Could not find app setting. Ensure *setting.json or equivalent has {settingKey} defined.");

            return environmentVariable ?? string.Empty;

        }
    }
}
