namespace Messenger.Classes
{
    internal static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ApplicationConfiguration.Initialize();
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.connection();
            Application.Run(new frmMain());
        }
    }
}