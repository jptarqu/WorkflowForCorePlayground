using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using WorkflowFuncHelper;

namespace AzureFuncSampleUsingV1
{
    public static class Function1
    {
        [FunctionName("WinWorkflowFunc")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");


            var endingNumber = Helper.RunWorkflow();

            string responseMessage = $"hi WF 4, {endingNumber}. This HTTP triggered function executed successfully.";


            return req.CreateResponse(HttpStatusCode.OK, $"Hello {endingNumber}");
        }
    }
}
