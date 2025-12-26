using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureDemos.Functions
{
    public static class ServiceBusTriggerDemo
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public static void Run(
            [ServiceBusTrigger("myqueue", Connection = "ServiceBusConnectionString")] string myQueueItem,
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
            
            // Logic to process the message goes here
        }
    }
}
