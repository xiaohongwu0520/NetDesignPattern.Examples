using System;

namespace Bridge.Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new BMPImage();
            var imp = new LinuxImp();
            image.SetImageImp(imp);
            image.ParseFile("中国地图");
            Console.Read();
        }
    }
}
