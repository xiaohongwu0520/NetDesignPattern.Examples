﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Example2
{
    class WindowsImp : ImageImp
    {
        public void DoPaint(Matrix m)
        {
            //调用Windows系统的绘制函数绘制像素矩阵
            Console.Write("在Windows操作系统中显示图像：");
        }
    }
}
