using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace flatsim.AssetGen2D
{
    public static class ImageUtils
    {
        public static void SaveVisualAsPng(int width, int height, int dpiX, int dpiY, DrawingVisual visual, string filePath)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap(width, height, dpiX, dpiY, PixelFormats.Pbgra32);
            bmp.Render(visual);

            PngBitmapEncoder png = new PngBitmapEncoder();
            png.Frames.Add(BitmapFrame.Create(bmp));
            using (Stream stm = File.Create(filePath))
            {
                png.Save(stm);
            }
        }
    }
}