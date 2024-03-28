using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFunctionDemo
{
    public class SayHelloFunction
    {
        private readonly ILogger<SayHelloFunction> _logger;

        public SayHelloFunction(ILogger<SayHelloFunction> logger)
        {
            _logger = logger;
        }

        [Function("SayHelloFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
