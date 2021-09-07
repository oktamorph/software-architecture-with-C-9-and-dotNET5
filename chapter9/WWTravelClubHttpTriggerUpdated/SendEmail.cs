using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Text;

namespace WWTravelClubHttpTriggerUpdated
{
    public static class SendEmail
    {
        [FunctionName(nameof(SendEmail))]
        public static async Task<HttpResponseMessage> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestMessage req, ILogger log)
        {
            var requestData = await req.Content.ReadAsStringAsync();
            var connectionString = Environment.GetEnvironmentVariable("AzureQueueStorage");
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();
            var messageQueue = queueClient.GetQueueReference("email");
            var message = new CloudQueueMessage(requestData);

            await messageQueue.AddMessageAsync(message);

            log.LogInformation("HTTP trigger from SendEmail function processed a request.");
            var responseObj = new { success = true };
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(responseObj), Encoding.UTF8, "application/json")
            };
        }
    }
}
