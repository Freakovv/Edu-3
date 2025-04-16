using Practice23.Task3;

namespace Practice23
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Task4());
        }
    }
}