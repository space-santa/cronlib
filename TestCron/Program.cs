using System;
using System.Threading.Tasks;

using CronLib;

namespace TestCron
{
    public class HelloJob : CronJob
    {
        protected override async Task Functionality()
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CronRunner<HelloJob>.Run("0/5 0/1 8-23 * * ?").GetAwaiter().GetResult();
        }
    }
}
