using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace WWTravelClubQueueTrigger
{
    public static class ProcessEmailQueue
    {
        [FunctionName("ProcessEmailQueue")]
        public static void Run([QueueTrigger("email", Connection = "EmailQueueConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
