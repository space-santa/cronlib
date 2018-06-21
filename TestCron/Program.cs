using System;
using System.Threading.Tasks;

using Quartz;
using CronLib;

namespace TestCron
{
    public class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CronJob<HelloJob>.Run().GetAwaiter().GetResult();
        }
    }
}
