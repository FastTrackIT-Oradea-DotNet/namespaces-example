using twoD = NamespacesExample.TwoD;
using threeD = NamespacesExample.ThreeD;

public class Point
{
    public string Description;
}

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

            global::Point pointGlobal = new global::Point();
            pointGlobal.Description = "Something";
        }
    }
}
