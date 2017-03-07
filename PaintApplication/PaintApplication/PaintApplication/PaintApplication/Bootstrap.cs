using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PaintApplication.Model;
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
            builder.RegisterType<PaintForm>();
            builder.RegisterType<PaintTool>();
            builder.RegisterType<App>().As<IApp>();

            var container = builder.Build();
            return container.Resolve<IApp>();
        }
    }
}
