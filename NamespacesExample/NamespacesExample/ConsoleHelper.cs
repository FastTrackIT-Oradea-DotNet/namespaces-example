namespace NamespacesExample
{
    namespace System
    {
        namespace Console
        {
            public class ConsoleHelper
            {
                public static void PrintCoordinates(TwoD.Point point)
                {
                    if (point is null)
                    {
                        return;
                    }

                    global::System.Console.WriteLine($"Point X={point.X}, Y={point.Y}");
                }
            }
        }
    }
}
