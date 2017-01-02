using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database filmy_base = new Database();
            if (filmy_base.Ping())
            {        
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main_Window(ref filmy_base));                
            }
            else Console.WriteLine("Nie udalo sie otworzyc bazy danych"); //TODO Zmienic na okno 
        }
    }
}



