using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGA
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form1 frm1;
        public static Form2 frm2;
        public static Form3 frm3;
        public static Form4 frm4;
        public static Form5 frm5;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
    public static class Opt
    {
        public static string a1 { get; set; }
        public static string a2 { get; set; }
        public static string a3 { get; set; }
        public static string a4 { get; set; }
        public static string a5 { get; set; }
        public static string a6 { get; set; }
        public static string a7 { get; set; }
        public static string a8 { get; set; }
        public static string a9 { get; set; }
        public static string a10 { get; set; }
        public static string a11 { get; set; }
        public static string a12 { get; set; }
        public static string a13 { get; set; }
        public static string a14 { get; set; }
    }
}

