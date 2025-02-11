namespace Bücherei_Windows_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // Um die Anwendungskonfiguration anzupassen, wie z.B. das Setzen von hohen DPI-Einstellungen oder der Standardschriftart,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Run the main form of the application.
            // Starten Sie das Hauptformular der Anwendung.
            Application.Run(new Forms.Dashboard_Form());
        }
    }
}