using System;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Form1.Scores = XmlSerializeWrapper.Deserialize<List<Score>>("output.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}