using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public sealed class Singleton
    {
        private static readonly object padlock = new object();
        private static User instance = null;
        public static User Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new User();
                    }
                    return instance;
                }
            }
        }
    }
}
