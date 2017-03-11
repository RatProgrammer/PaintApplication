using PaintApplication.Presenter;

namespace PaintApplication
{
    class App : IApp
    {
        private readonly PaintPresenter _paintPresenter;

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