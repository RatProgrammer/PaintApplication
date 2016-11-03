using System.Drawing;
using System.Windows.Forms;

namespace PaintApplication.View
{
    internal static class ControlExtension
    {
        public static int GetClientWidth(this Control theControl)
        {
            return theControl.Width - TCResize.Decoration;
        }

        public static int GetClientHeight(this Control theControl)
        {
            return theControl.Height - TCResize.Decoration;
        }

        public static Size GetClientSize(this Control theControl)
        {
            return new Size(theControl.GetClientWidth(), theControl.GetClientHeight());
        }

        public static void SetClientWidth(this Control theControl, int width)
        {
            theControl.Width = width + TCResize.Decoration;
        }

        public static void SetClientHeight(this Control theControl, int height)
        {
            theControl.Height = height + TCResize.Decoration;
        }

        public static void SetClientSize(this Control theControl, Size size)
        {
            theControl.SetClientWidth(size.Width);
            theControl.SetClientHeight(size.Height);
        }
    }
}