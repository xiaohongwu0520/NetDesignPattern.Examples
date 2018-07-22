using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Creator
    {
        // 工厂方法
        public abstract Food CreateFoddFactory();
    }
}
