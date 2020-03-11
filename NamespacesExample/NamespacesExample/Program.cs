using twoD = NamespacesExample.TwoD;
using threeD = NamespacesExample.ThreeD;
using helpers2D = Helpers2D;
using helpers3D = Helpers3D;

namespace NamespacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            twoD::Point point2D = new twoD.Point();
            point2D.X = 100;
            point2D.Y = 200;

            helpers2D::ConsoleHelper.PrintCoordinates(point2D);

            threeD::Point point3D = new threeD.Point();
            point3D.X = 100;
            point3D.Y = 200;
            point3D.Z = 300;

            helpers3D::ConsoleHelper.PrintCoordinates(point3D);
        }
    }
}
