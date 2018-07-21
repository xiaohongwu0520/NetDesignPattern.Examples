using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    /// <summary>
    /// 懒汉单例
    /// </summary>
    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private static readonly object syncRoot = new object();
        private LazySingleton() { }
        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }
    }
}
