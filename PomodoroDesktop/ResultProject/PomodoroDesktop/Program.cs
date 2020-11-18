using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroDesktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var countdownService = serviceProvider.GetRequiredService<ICountdown>();
                Application.Run(new Pomodoro(countdownService));
            }    
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ICountdown, Countdown>();
        }
    }
}
