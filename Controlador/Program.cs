using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
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
            Application.Run(new Loguin());
        }
    }
}