using twoD = NamespacesExample.TwoD;
using threeD = NamespacesExample.ThreeD;

namespace NamespacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            twoD::Point point2D = new twoD.Point();
            point2D.X = 100;
            point2D.Y = 200;

            threeD::Point point3D = new threeD.Point();
            point3D.X = 100;
            point3D.Y = 200;
            point3D.Z = 300;

            // alternatively, you can use
            twoD.Point otherPoint2D = new twoD.Point();
            otherPoint2D.X = 100;
            otherPoint2D.Y = 200;

            threeD.Point otherPoint3D = new threeD.Point();
            otherPoint3D.X = 100;
            otherPoint3D.Y = 200;
            otherPoint3D.Z = 300;

        }
    }
}
