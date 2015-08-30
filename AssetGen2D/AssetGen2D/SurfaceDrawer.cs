using System;
using System.Windows;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    public static class SurfaceDrawer
    {
        public static void drawFlat(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0, halfHeight),
                new Point(halfWidth, 0),
                new Point(drawArgs.tileWidth, halfHeight),
                new Point(halfWidth, height)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawFullFacingBottom(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight() * 2;
            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0, halfHeight),
                new Point(halfWidth, 0),
                new Point(drawArgs.tileWidth, halfHeight),
                new Point(halfWidth, height)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }
    }
}