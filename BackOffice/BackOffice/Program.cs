using System;
using System.Windows.Forms;

namespace BackOffice
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Asegúrate de que 'Form1' es tu formulario
        }
    }
}
