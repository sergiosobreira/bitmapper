using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;

namespace Bitmapper.Implementations
{
    public static class MicrosoftMauiGraphicsSkia
    {
        public static void Run()
        {
            Console.WriteLine("Executing from Microsoft.Maui.Graphics.Skia!");

            SkiaBitmapExportContext bmp = new(500, 500, 1.0f);
            ICanvas canvas = bmp.Canvas;
            canvas.FillColor = Colors.White;
            canvas.FillRectangle(0, 0, bmp.Width, bmp.Height);
            canvas.StrokeSize = 4;

            Point p1 = new(20, 20);
            Size s1 = new(20, 20);
            Rect r1 = new(p1, s1);

            Point p2 = new(120, 120);
            Size s2 = new(20, 20);
            Rect r2 = new(p2, s2);

            canvas.FillColor = Colors.Black;
            canvas.DrawLine(Center(r1), Center(r2));

            canvas.FillColor = Colors.Red;
            canvas.FillEllipse(r1);

            canvas.FillColor = Colors.Green;
            canvas.FillEllipse(r2);

            Directory.CreateDirectory("C:\\BitmapperTemp");
            bmp.WriteToFile("C:\\BitmapperTemp\\MicrosoftMauiGraphicsSkia.png");
        }

        static Point Center(Rect rect)
        {
            return new Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);
        }
    }
}

