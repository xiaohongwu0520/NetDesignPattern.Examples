using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    /// <summary>
    /// 泛型单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericSingleton<T> where T : class, new()
    {
        private static T _instance;
        private static readonly object syslock = new object();

        public static T GetInstance()
        {
            if (_instance == null)
            {
                lock (syslock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }
            }
            return _instance;
        }

    }
}
