using NamespacesExample.ThreeD;
using System;

namespace Helpers3D
{
    public static class ConsoleHelper
    {
        public static void PrintCoordinates(Point p)
        {
            if (p != null)
            {
                Console.WriteLine($"3D Point [X={p.X}, Y={p.Y}, Z={p.Z}]");
            }
        }
    }
}
