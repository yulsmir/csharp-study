using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractionHW
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
}
