using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrompterAyar prompterAyar = new PrompterAyar();
            prompterAyar.yaziBoyut = 70f;
            prompterAyar.KaymaHizi = 10;
            prompterAyar.barBoyuttu =15;
        
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
