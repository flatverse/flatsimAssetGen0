using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace flatsim.AssetGen2D
{
    public class GraphicsAsset
    {
        public int width = 0;
        public int height = 0;

        public int dpiX = 96;
        public int dpiY = 96;

        DrawingVisual drawingVisual;
        DrawingContext drawingContext;

        public GraphicsAsset()
        {
            drawingVisual = new DrawingVisual();
        }

        public DrawingContext getContext()
        {
            return drawingContext;
        }

        public void renderOpen()
        {
            if (drawingContext != null)
            {
                throw new Exception("renderOpen was called again before renderClose");
            }

            drawingContext = drawingVisual.RenderOpen();
        }

        public void expandDimensions(int width, int height)
        {
            if (width > this.width)
            {
                this.width = width;
            }
            if (height > this.height)
            {
                this.height = height;
            }
        }

        public void renderClose()
        {
            if (drawingContext == null)
            {
                throw new Exception("renderClose was called before renderOpen");
            }

            drawingContext.Close();
            drawingContext = null;
        }

        public void saveAsPng(string outputPath)
        {
            if (width == 0 || height == 0)
            {
                return;
            }

            RenderTargetBitmap bmp = new RenderTargetBitmap(width, height, dpiX, dpiY, PixelFormats.Pbgra32);
            bmp.Render(drawingVisual);

            PngBitmapEncoder png = new PngBitmapEncoder();
            png.Frames.Add(BitmapFrame.Create(bmp));
            using (Stream stm = File.Create(outputPath))
            {
                png.Save(stm);
            }
        }

        /*
         * draw methods
         */
        public void drawPolygon(Brush baseBrush, Pen borderPen, Point[] points, bool expandToFit)
        {
            LineSegment[] segs = new LineSegment[]
            {
                new LineSegment(points[1], true),
                new LineSegment(points[2], true),
                new LineSegment(points[3], true)
            };
            PathGeometry geo = new PathGeometry(new PathFigure[] { new PathFigure(points[0], segs, true) });
            getContext().DrawGeometry(baseBrush, borderPen, geo);

            if (expandToFit)
            {
                foreach (Point p in points)
                {
                    expandDimensions((int)Math.Round(p.X), (int)Math.Round(p.Y));
                }
            }
        }
    }
}
