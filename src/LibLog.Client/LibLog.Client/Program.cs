using System;
using System.Windows.Forms;

namespace LibLog.Client
{
    public static class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
