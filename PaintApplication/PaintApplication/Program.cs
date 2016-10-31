using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            PaintForm paintForm = new PaintForm();
            Canvas canvas = new Canvas(400, 400);
            PaintTool paintTool = new PaintTool();
            PaintPresenter paintPresenter = new PaintPresenter(paintForm, canvas, paintTool);
            paintPresenter.RunApp();

        }
    }
}
