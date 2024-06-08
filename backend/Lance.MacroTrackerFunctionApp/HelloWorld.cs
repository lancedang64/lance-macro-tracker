using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Lance.MacroTrackerFunctionApp;

public class HelloWorld
{
    private readonly ILogger _logger;

    public HelloWorld(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<HelloWorld>();
    }

    [Function("HelloWorld")]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] 
        HttpRequestData req,
        FunctionContext executionContext)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

        await response.WriteStringAsync("Welcome to Azure Functions!");

        return response;
        
    }
}