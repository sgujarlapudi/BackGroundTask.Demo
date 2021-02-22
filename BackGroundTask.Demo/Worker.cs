﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BackGroundTask.Demo
{
    public interface IWorker
    {
        Task DoWork(CancellationToken cancellationToken);
    }

    public class Worker : IWorker
    {
        private readonly ILogger<Worker> logger;
        private int number = 0;

        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
        }

        public async Task DoWork(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Interlocked.Increment(ref number);
                logger.LogInformation($"Worker printing number:{number}");
                await Task.Delay(1000 * 5, cancellationToken);
            }
        }
    }
}
