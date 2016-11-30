using System.Windows.Forms;

namespace PaintApplication.View
{
    internal static class ControlExtension
    {
        public static int GetClientWidth(this Control theControl)
        {
            return theControl.Width - Resizer.Decoration;
        }

        public static int GetClientHeight(this Control theControl)
        {
            return theControl.Height - Resizer.Decoration;
        }

        public static void SetClientWidth(this Control theControl, int width)
        {
            theControl.Width = width + Resizer.Decoration;
        }

        public static void SetClientHeight(this Control theControl, int height)
        {
            theControl.Height = height + Resizer.Decoration;
        }
    }
}