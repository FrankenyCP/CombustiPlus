using System.Globalization;

namespace CombustiPlus
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Los montos se muestran siempre con punto decimal y coma de miles
            // (RD$ 6,439.97), sin importar la configuración regional de Windows.
            CultureInfo cultura = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
