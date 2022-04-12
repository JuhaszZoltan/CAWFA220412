using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalapacsForm
{
    internal static class Program
    {
        internal static List<Versenyzo> versenyzok = new List<Versenyzo>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileBeolvasasa();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        private static void FileBeolvasasa()
        {
            using (var sr = new StreamReader(
                path: "..\\..\\src\\Selejtezo2012.txt",
                encoding: Encoding.UTF8))
            {
                _ = sr.ReadLine();

                while (!sr.EndOfStream)
                    versenyzok.Add(new Versenyzo(sr.ReadLine()));
            }
        }
    }
}
