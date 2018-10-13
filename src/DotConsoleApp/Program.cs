using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace DotConsoleApp
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .Build();

            await host.RunAsync();
        }
    }
}