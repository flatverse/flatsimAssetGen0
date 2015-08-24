using System;
using System.Windows;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    public static class SurfaceDrawer
    {
        public static void drawFlat(string outputPath, DrawArgs drawArgs)
        {
            DrawingVisual dv = new DrawingVisual();
            DrawingContext dc = dv.RenderOpen();

            //dc.DrawRectangle(Brushes.BurlyWood, pen, new Rect(100, 100, 100, 100));
            int height = (int)Math.Round((double)drawArgs.tileWidth / Math.Sqrt(3));

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            bool strokeSegments = true;
            Point start = new Point(0, halfHeight);
            LineSegment[] segments = new LineSegment[]
            {
                new LineSegment(new Point(halfWidth, 0), strokeSegments),
                new LineSegment(new Point(drawArgs.tileWidth, halfHeight), strokeSegments),
                new LineSegment(new Point(halfWidth, height), strokeSegments)
            };

            PathGeometry geo = new PathGeometry(new PathFigure[] {new PathFigure(start, segments, true)});
            dc.DrawGeometry(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), geo);

            dc.Close();

            ImageUtils.SaveVisualAsPng(drawArgs.tileWidth, height, drawArgs.dpiX, drawArgs.dpiY, dv, outputPath);
        }
    }
}