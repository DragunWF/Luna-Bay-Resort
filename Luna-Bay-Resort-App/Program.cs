using Luna_Bay_Resort_App.Forms.Test;

namespace Luna_Bay_Resort_App
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
            ApplicationConfiguration.Initialize();

            /*
              For production: Application.Run(new LoginForm());
              For testing and development: Application.Run(new FormOpener());
            */
            Application.Run(new FormOpener());
        }
    }
}