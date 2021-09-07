using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;

namespace WWTravelClubHttpTrigger
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // string name = req.Query["name"];

            var requestData = await req.Content.ReadAsStringAsync();
            var connectionString = Environment.GetEnvironmentVariable("AzureQueueStorage");
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();
            var messageQueue = queueClient.GetQueueReference("email");
            var message = new CloudQueueMessage(requestData);
            await messageQueue.AddMessageAsync(message);

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //string responseMessage = string.IsNullOrEmpty(name)
            //    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello, {name}. This HTTP triggered function executed successfully.";

            var responseMessage = new { success = true };
            return new OkObjectResult(responseMessage);
        }

    }

    //public static class SendEmail
    //{
    //    [FunctionName(nameof(SendEmail))]
    //    public static async Task<HttpResponseMessage> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestMessage req,
    //        ILogger log)
    //    {
    //        var requestData = await req.Content.ReadAsStringAsync();
    //        var connectionString = Environment.GetEnvironmentVariable("AzureQueueStorage");
    //        var storageAccount = CloudStorageAccount.Parse(connectionString);
    //        var queueClient = storageAccount.CreateCloudQueueClient();
    //        var messageQueue = queueClient.GetQueueReference("email");
    //        var message = new CloudQueueMessage(requestData);
    //        await messageQueue.AddMessageAsync(message);

    //        log.LogInformation("HTTP trigger from SendEmail function processed a request.");
    //        var responseObj = new { success = true };

    //        return new HttpResponseMessage(HttpStatusCode.OK)
    //        {
    //            Content = new StringContent(JsonConvert.SerializeObject(responseObj), Encoding.UTF8, "application/json"),
    //        };
    //    }
    //}

}

