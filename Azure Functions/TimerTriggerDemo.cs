using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureDemos.Functions
{
    public static class TimerTriggerDemo
    {
        // Runs every day at 6:00 AM UTC
        [FunctionName("DailyCleanupJob")]
        public static async Task Run(
            [TimerTrigger("0 0 6 * * *")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation($"Timer trigger function executed at: {DateTime.Now}");

            if (myTimer.IsPastDue)
            {
                log.LogWarning("Timer is running late!");
            }

            // Perform cleanup or scheduled task
            await PerformCleanupAsync();

            log.LogInformation($"Next timer schedule: {myTimer.Schedule}");
        }

        private static async Task PerformCleanupAsync()
        {
            // Simulate cleanup work
            await Task.Delay(1000);
            Console.WriteLine("Cleanup completed successfully");
        }
    }
}
