using System;
using System.Windows;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    public static class SurfaceDrawer
    {
        public static void drawFlat(DrawArgs drawArgs)
        {
            GraphicsAsset ga = drawArgs.asset;
            DrawingContext dc = ga.getContext();

            int height = drawArgs.getFlatTileHeight();

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

            ga.adjustDimensions(drawArgs.tileWidth, height);
        }

        public static void drawFullFacingBottom(DrawArgs drawArgs)
        {
            int height = drawArgs.getFlatTileHeight() * 2;
            int halfWidth = drawArgs.tileWidth / 2;
            int halfHeight = height / 2;
            Point start = new Point(0, halfHeight);
            LineSegment[] segs = new LineSegment[]
            {
                new LineSegment(new Point(halfWidth, 0), true),
                new LineSegment(new Point(drawArgs.tileWidth, halfHeight), true),
                new LineSegment(new Point(halfWidth, height), true)
            };

            PathGeometry geo = new PathGeometry(new PathFigure[] { new PathFigure(start, segs, true) });
            drawArgs.asset.getContext().DrawGeometry(drawArgs.getBaseBrush(), drawArgs.getBorderPen(), geo);
            drawArgs.asset.adjustDimensions(drawArgs.tileWidth, height);
        }
    }
}