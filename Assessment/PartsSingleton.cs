using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public sealed class BuildingSingleton
    {
        private static readonly object padlock = new object();
        private static Building instance = null;
        public static Building Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Building();
                    }
                    return instance;
                }
            }
        }
    }
}
