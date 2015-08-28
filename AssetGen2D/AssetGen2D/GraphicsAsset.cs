using System;
using System.IO;
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

        public void adjustDimensions(int width, int height)
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
    }
}
