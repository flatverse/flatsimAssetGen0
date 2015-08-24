using System;

namespace flatsim.AssetGen2D
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawArgs dArgs = new DrawArgs();

            SurfaceDrawer.drawFlat(@"F:\0contents\downloads\omg.png", dArgs);
        }
    }
}
