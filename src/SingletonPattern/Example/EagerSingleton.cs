using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    /// <summary>
    /// 饿汉单例
    /// </summary>
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();

        public EagerSingleton() { }
        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
