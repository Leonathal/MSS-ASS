using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    public abstract class Singleton<T> where T : Singleton<T>
    {
        private static Func<T> ctor;
        private static T instance = null;

        private static readonly object sLock = new object();

        protected static void setCtor(Func<T> _ctor)
        {
            ctor = _ctor;
        }

        public static T Instance
        {
            get
            {
                lock (sLock)
                {
                    if (instance == null)
                        instance = ctor();
                    return instance;
                }
            }
        }
    }
}
