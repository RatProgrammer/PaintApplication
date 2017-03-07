using System;
using PaintApplication.Model;
using PaintApplication.Presenter;
using PaintApplication.View;

namespace PaintApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var app = Bootstrap.Create();
            app.Run();

        }
    }
}
