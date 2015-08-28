using System;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawArgs dArgs = new DrawArgs();
            dArgs.asset.renderOpen();

            SurfaceDrawer.drawFlat(dArgs);

            dArgs.tileWidth = 64;
            dArgs.baseColor = Color.FromArgb(128, 255, 128, 128);
            SurfaceDrawer.drawFlat(dArgs);

            dArgs.asset.renderClose();

            if (args.Length > 0)
            {
                dArgs.asset.saveAsPng(args[0]);
            }
        }
    }
}
