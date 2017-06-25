using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BibliotecaNET4.Services;
namespace BibliotecaNET4
{
    static class Program
        //programa principal
    {
        [STAThread]
        static void Main()
        {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(new MsgBoxDisplayService()));
            } catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
