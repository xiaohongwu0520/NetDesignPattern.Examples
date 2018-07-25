﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Example2
{
    class JPGImage : Image
    {

        public override void ParseFile(string fileName)
        {
            //模拟解析JPG文件并获得一个像素矩阵对象m;
            Matrix m = new Matrix();
            imp.DoPaint(m);
            Console.WriteLine("{0}，格式为JPG。", fileName);
        }
    }
}
