using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public sealed class Singletone<T> where T : new()
    {
        static readonly object ThreadLock = new object();
        static private T instance;

        public static T GetInstance()
        {
            lock (ThreadLock)
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }

        public static void NullInstance(T t)
        {
            if (t is T)
            {
                instance = new T();
            }
        }
    }
}
