using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _instance = null;
        private int nextServer = 0;
        private static object lockObject = new object();

        private Singleton()
        {
            nextServer++;
            Console.WriteLine($"No, of instance created {nextServer}");
        }

        public static Singleton GetTableServers()
        {
            if(_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;
        }

        public void ServerMessage(string message)
        {
            Console.WriteLine(message);

        }
    }
}
