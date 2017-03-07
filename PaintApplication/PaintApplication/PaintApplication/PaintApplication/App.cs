using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Presenter;

namespace PaintApplication
{
    class App : IApp
    {
        private PaintPresenter _paintPresenter;

        public App(PaintPresenter paintPresenter)
        {
            _paintPresenter = paintPresenter;
        }

        public void Run()
        {
            _paintPresenter.RunApp();
        }
    }
}