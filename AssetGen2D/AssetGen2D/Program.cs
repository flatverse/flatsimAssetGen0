using System;

namespace flatsim.AssetGen2D
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawArgs dArgs = new DrawArgs();

            SurfaceDrawer.drawFlat(dArgs);

            if (args.Length > 0)
            {
                dArgs.getAsset().saveAsPng(args[0]);
            }
        }
    }
}
