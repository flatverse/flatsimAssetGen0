using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace flatsim.AssetGen2D
{
    public class GraphicsAsset
    {
        DrawingVisual drawingVisual;

        public GraphicsAsset()
        {
            drawingVisual = new DrawingVisual();
        }

        public DrawingContext renderOpen()
        {
            return drawingVisual.RenderOpen();
        }

        public void renderClose(DrawingContext dc)
        {
            dc.Close();
        }

        public void saveAsPng(int width, int height, int dpiX, int dpiY, string outputPath)
        {
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
