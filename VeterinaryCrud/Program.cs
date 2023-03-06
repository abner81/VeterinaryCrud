using VeterinaryCrud.Presenter;
using VeterinaryCrud.Repository;
using VeterinaryCrud.View;

namespace VeterinaryCrud
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
            var view = new PetView();
            new PetPresenter(view, new PetRepository());
            Application.Run(view);
        }
    }
}