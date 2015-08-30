using System;
using System.Windows.Media;

namespace flatsim.AssetGen2D
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawArgs dArgs = new DrawArgs();
            dArgs.borderWidth = 0;
            dArgs.asset.renderOpen();

            SurfaceDrawer.drawFlat(dArgs);

            dArgs.baseColor = Color.FromArgb(128, 255, 128, 128);
            SurfaceDrawer.drawFullFacingBottom(dArgs);

            dArgs.asset.renderClose();

            if (args.Length > 0)
            {
                dArgs.asset.saveAsPng(args[0]);
            }
        }
    }
}
