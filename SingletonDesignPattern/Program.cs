using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                () => Host1GetNextServer(),
                () => Host2GetNextServer());

            Console.ReadLine();
        }

        private static void Host1GetNextServer()
        {
            Singleton host1List = Singleton.GetTableServers();;
            host1List.ServerMessage("Hello from host1");
        }

        private static void Host2GetNextServer()
        {
            Singleton host2List = Singleton.GetTableServers();
            host2List.ServerMessage("Hello from host2");
        }
    }
}
