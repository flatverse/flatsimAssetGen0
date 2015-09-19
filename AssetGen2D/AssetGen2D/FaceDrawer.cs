using System;
using System.Windows;

namespace flatsim.AssetGen2D
{
    public static class FaceDrawer
    {
        public static void drawLeftFlat(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(halfWidth, halfHeight),
                new Point(halfWidth, height),
                new Point(0, halfHeight)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawRightFlat(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0, halfHeight),
                new Point(halfWidth, 0),
                new Point(halfWidth, halfHeight),
                new Point(0, height)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawLeftCornerUp(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0,0),
                new Point(halfWidth, height),
                new Point(0, halfHeight)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawMiddleCornerUpLeft(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0,0),
                new Point(halfWidth, 0),
                new Point(halfWidth, halfHeight)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawMiddleCornerUpRight(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0,0),
                new Point(halfWidth, 0),
                new Point(0, halfHeight)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }

        public static void drawRightCornerUp(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight();

            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;

            Point[] points = new Point[]
            {
                new Point(0,height),
                new Point(halfWidth, 0),
                new Point(halfWidth, halfHeight)
            };

            drawArgs.asset.drawPolygon(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), points, true);
        }
    }
}
