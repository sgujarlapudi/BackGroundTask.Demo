using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace BackGroundTask.Demo
{
    public class DerivedBackgroundPrinter : BackgroundService
    {
        private readonly IWorker _worker;
        public DerivedBackgroundPrinter(IWorker worker)
        {
            this._worker = worker;
        }

       protected override async Task ExecuteAsync(CancellationToken stoppingToken)
       {
           await _worker.DoWork(stoppingToken);
       }
    }
}
