using System;
using System.Windows.Forms;

namespace WindowsFormsApp1_LAB5._2_
{
    internal static class Program
    {
        [STAThread] // yêu cầu cho WinForms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // chạy Form1
        }
    }
}
