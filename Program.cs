// Our GPAUX namespace
namespace GPAUX
{
    // The main Program class that runs our application.
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        // The Main method which specifically initializes the application.
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GPAHarbor());
        }
    }
}