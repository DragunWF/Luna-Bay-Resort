using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Forms.Test;
using Luna_Bay_Resort_App.Helpers;
using MainForms;

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

            // Method to be called when all forms are closed
            Application.ApplicationExit += OnApplicationExit;

            /*
              For production: Application.Run(new LoginForm());
              For testing and development: Application.Run(new FormOpener());
            */
            Application.Run(new FormOpener());
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            // Primarily placed this here for logging it in the activities table
            SessionData.LogoutUser();
        }
    }
}