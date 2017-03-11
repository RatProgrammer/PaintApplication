using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Autofac;
using PaintApplication.Model;
using PaintApplication.Model.MementoItems;
using PaintApplication.Presenter;
using PaintApplication.View;

namespace PaintApplication
{
    static class Bootstrap
    {
        public static IApp Create()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PaintPresenter>();
            builder.RegisterType<Resizer>();
            builder.RegisterType<PaintForm>().As<IPaintForm>();
            builder.RegisterType<PaintTool>();
            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<OpenFileDialog>();
            builder.RegisterType<Canvas>();
            builder.RegisterType<Bitmap>().SingleInstance();
            builder.RegisterType<BrushFactory>();
            builder.RegisterType<Pen>();
            builder.RegisterType<SaveControler>();
            builder.RegisterType<BitmapLoader>();
            builder.RegisterType<Originator>();
            builder.RegisterType<SaveControler>();
            builder.RegisterType<Caretaker>();


            var container = builder.Build();
            return container.Resolve<IApp>();
        }
    }
}
