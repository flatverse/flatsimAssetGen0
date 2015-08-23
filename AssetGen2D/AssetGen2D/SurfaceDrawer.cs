using System;
using System.Windows;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    public static class SurfaceDrawer
    {
        public static void drawFlat(string outputPath)
        {
            Pen pen = new Pen(Brushes.SlateBlue, 1);

            DrawingVisual dv = new DrawingVisual();
            DrawingContext dc = dv.RenderOpen();

            dc.DrawRectangle(Brushes.BurlyWood, pen, new Rect(100, 100, 100, 100));

            dc.Close();

            ImageUtils.SaveVisualAsPng(300, 300, dv, outputPath);
        }
    }
}