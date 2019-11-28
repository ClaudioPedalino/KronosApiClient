using Hotels.ApiClient;
using System;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CustomClient();
            client.Test();

            Console.ReadLine();
        }
    }
}
