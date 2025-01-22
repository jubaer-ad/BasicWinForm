using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSignUp
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
            Application.Run(new SignUp());
        }


        public static void TakeComplexObjAndDo(Object obj)
        {
            ComplexObj actualObj = obj as ComplexObj;
            while (true)
            {
                if (!(actualObj.Limit > 0))
                {
                    return;
                }
                for (int i = 0; i < actualObj.Limit; i++)
                {
                    Console.WriteLine($"{i}: {actualObj.Message}");
                    Thread.Sleep(750);
                } 
            }
        }
    }

    class ComplexObj
    {
        public int Limit { get; set; }
        public string Message { get; set; }
    }
}