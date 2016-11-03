using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PaintApplication.Model.Commands
{
    class BucketCommand : IPaintCommand
    {
        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            FloodFill(current, point.X, point.Y, paintTool.Color);
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {

        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {

        }

        private void  FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride/4*data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y*data.Stride/4];
            bits[x + y*data.Stride/4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[]
                    {
                        new Point(0, -1), new Point(0, 1),
                        new Point(-1, 0), new Point(1, 0)
                    })
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y*data.Stride/4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y*data.Stride/4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }
    }
}
