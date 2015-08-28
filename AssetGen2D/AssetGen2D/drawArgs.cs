using System;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    public class DrawArgs
    {
        public Color baseColor = Colors.DarkGreen;
        public Color borderColor = Colors.DarkGray;

        public GraphicsAsset asset;

        public int tileWidth = 128;
        public int borderWidth = 1;

        public int paddingX = 0;
        public int paddingY = 0;

        public int dpiX = 96;
        public int dpiY = 96;

        public DrawArgs()
        {
            asset = new GraphicsAsset();
        }

        public Pen getBorderPen()
        {
            return new Pen(new SolidColorBrush(borderColor), borderWidth);
        }

        public Brush getBaseBrush()
        {
            return new SolidColorBrush(baseColor);
        }

    }
}