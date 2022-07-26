using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using TMDb.WinFormsClient.Forms;

namespace TMDb.WinFormsClient
{
    internal static class Program
    {

        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            

            if (Debugger.IsAttached)
            {
               builder.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
                Configuration = builder.Build();
            }
            else
            {
               builder.AddJsonFile("appsettings.Production.json", optional: true, reloadOnChange: true);
                Configuration = builder.Build();
            }
            

            ApplicationConfiguration.Initialize();
            Application.Run(new IndexForm());

        }
    }
}

// TODO: Create Light/Dark Theme
// TODO: Add this appp as an OIDC client for the AuthService
// TODO: Make all the pages liek the BlazorClient