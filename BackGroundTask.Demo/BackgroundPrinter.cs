using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace BackGroundTask.Demo
{
    public class BackgroundPrinter: IHostedService
    {
        private readonly ILogger<BackgroundPrinter> _logger;
        private readonly IWorker _worker;

        public BackgroundPrinter(ILogger<BackgroundPrinter> logger,IWorker worker)
        {
            this._logger = logger;
            this._worker = worker;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _worker.DoWork(cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Printing worker stopping");
            return Task.CompletedTask;
        }

       
    }
}
