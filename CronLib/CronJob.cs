using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace CronLib
{
    public abstract class CronJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Functionality();
        }

        protected abstract Task Functionality();
    }
}
