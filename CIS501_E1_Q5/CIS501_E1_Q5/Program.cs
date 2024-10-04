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
            BookModifiedDel bookModifiedDel = controller.UpdateBook;
            LibraryView libraryView = new LibraryView(bookModifiedDel);
            DataSyncDel dataSyncDel = libraryView.SyncData;
            controller.AttachDelToController(dataSyncDel);
            Application.Run(libraryView);
        }
    }
}