namespace Messenger
{
    internal static class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}