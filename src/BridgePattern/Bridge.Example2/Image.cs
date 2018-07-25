using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Example2
{
    abstract class Image
    {
        protected ImageImp imp;

        //注入实现类接口对象
        public void SetImageImp(ImageImp imp)
        {
            this.imp = imp;
        }

        public abstract void ParseFile(string fileName);
    }
}
