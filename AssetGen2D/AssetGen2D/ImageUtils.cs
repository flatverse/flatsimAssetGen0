using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace flatsim.AssetGen2D
{
    public static class ImageUtils
    {
        public const int DEFAULT_DPI_X = 100;
        public const int DEFAULT_DPI_Y = 100;

        public static void SaveVisualAsPng(int width, int height, DrawingVisual visual, string filePath)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap(width, height, DEFAULT_DPI_X, DEFAULT_DPI_Y, PixelFormats.Pbgra32);
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