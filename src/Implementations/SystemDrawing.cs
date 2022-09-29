using System.Drawing;
using System.Drawing.Imaging;

namespace Bitmapper.Implementations
{
    public static class SystemDrawing
    {
        public static void Run()
        {
            Console.WriteLine("Executing from System.Drawing!");

            Pen blackPen = new(Color.Black, 5);
            Pen redPen = new(Color.Red, 5);
            Pen greenPen = new(Color.Green, 5);
            SolidBrush redBrush = new(Color.Red);
            SolidBrush greenBrush = new(Color.Green);

            Bitmap bmp = new(500, 500);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Point p1 = new(20, 20);
            Size s1 = new(20, 20);
            Rectangle r1 = new(p1, s1);

            Point p2 = new(120, 120);
            Size s2 = new(20, 20);
            Rectangle r2 = new(p2, s2);

            g.DrawLine(blackPen, Center(r1), Center(r2));

            g.DrawEllipse(redPen, r1);
            g.FillEllipse(redBrush, r1);

            g.DrawEllipse(greenPen, r2);
            g.FillEllipse(greenBrush, r2);

            Directory.CreateDirectory("C:\\BitmapperTemp");
            bmp.Save("C:\\BitmapperTemp\\SystemDrawing.png", ImageFormat.Png);

            g.Dispose();
            bmp.Dispose();
        }

        static Point Center(Rectangle rect)
        {
            return new Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);
        }
    }
}
