using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Example2
{
    class BMPImage : Image
    {
        public override void ParseFile(string fileName)
        {
            //模拟解析BMP文件并获得一个像素矩阵对象m;
            Matrix m = new Matrix();
            imp.DoPaint(m);
            Console.WriteLine("{0}，格式为BMP。", fileName);
        }
    }
}
