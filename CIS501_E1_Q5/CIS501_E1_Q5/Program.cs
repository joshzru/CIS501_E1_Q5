namespace CIS501_E1_Q5
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

            LibraryController controller = new LibraryController();

            LibraryView libraryView = new(controller.SetBookView);
            BookView bookView = new(controller.AddBookmark, controller.RemoveBookmark, controller.ChangePage, controller.ReturnPage);

            controller.AttachLibraryDels(libraryView.UpdateBooks);
            controller.AttachBookDels(bookView.SetBook, bookView.SetButtonStates);

            Application.Run(libraryView);
        }
    }
}