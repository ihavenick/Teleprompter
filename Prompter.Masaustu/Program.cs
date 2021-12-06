using System;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var prompterAyar = new PrompterAyar();
            prompterAyar.yaziBoyut = 70f;
            prompterAyar.KaymaHizi = 10;
            prompterAyar.barBoyuttu = 15;

            prompterAyar.uygulamaCalisiyormu = true;
            var prompter = new FormPrompter(prompterAyar);
            var kontrolPanel = new FormKontrolPanel(prompterAyar, prompter);
            var Ekran = new FormEkran(prompter);

            kontrolPanel.Show();
            Ekran.Show();

            Application.Run();
        }
    }
}