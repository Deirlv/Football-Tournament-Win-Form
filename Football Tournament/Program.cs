using FootballTournament.DAL;
using FootballTournament.DAL.Architecture;
using FootballTournament.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Football_Tournament
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var host = Configuration().Build();

            var context = host.Services.GetRequiredService<TournamentContext>();

            ApplicationConfiguration.Initialize();
            Application.Run(new TournamentForm(context));
        }

        public static IHostBuilder Configuration()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddDbContext<TournamentContext>(o =>
                            o.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));

                    service.AddScoped<IRepository, Repository>();
                    service.AddScoped<IService, Service>();
                });
        }
    }
}