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

            dArgs.baseColor = Color.FromArgb(0xff, (byte)(dArgs.baseColor.R + 0xf), (byte)(dArgs.baseColor.G + 0xf), (byte)(dArgs.baseColor.B + 0xf));
            SurfaceDrawer.drawFullFacingBottom(dArgs);

            dArgs.asset.renderClose();

            if (args.Length > 0)
            {
                dArgs.asset.saveAsPng(args[0]);
            }
        }
    }
}
