namespace SimpleMsgViewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    mainForm.fileToOpen = args[0];
                }
                else
                {
                    MessageBox.Show("File not found: " + args[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Run(mainForm);
        }
    }
}