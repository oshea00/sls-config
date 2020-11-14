using System;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Configuration;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AwsDotnetCsharp
{
    public class Handler
    {
      IConfiguration configuration;
      public string LogLevel { get; set; }
      public Handler()
      {
          configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
      }

      public Response Hello(Request request, ILambdaContext context)
      {
          foreach (var setting in configuration.GetChildren()) {
            System.Console.WriteLine($"{setting.Key} : {setting.Value}");
          }
          return new Response($"Go Serverless v1.0! Your function {context.FunctionName} executed successfully!", request);
      }

    }

    public class Response
    {
      public string Message {get; set;}
      public Request Request {get; set;}

      public Response(string message, Request request){
        Message = message;
        Request = request;
      }
    }

    public class Request
    {
      public string Key1 {get; set;}
      public string Key2 {get; set;}
      public string Key3 {get; set;}
    }
}
