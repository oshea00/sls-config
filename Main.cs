using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Lambda.Core;

namespace Main {

    public class Program {
        public static void Main(string[] args) {
            System.Console.WriteLine("Starting Handler...");
            var h = new AwsDotnetCsharp.Handler();
            var response = h.Hello(
                new AwsDotnetCsharp.Request { Key1 = "Key1 Value" }, 
                new Context());
            System.Console.WriteLine(response.Message);
        }
    }

    public class Context : ILambdaContext
    {
        public string AwsRequestId => throw new NotImplementedException();
        public IClientContext ClientContext => throw new NotImplementedException();
        public string FunctionName => "Hello";
        public string FunctionVersion => throw new NotImplementedException();
        public ICognitoIdentity Identity => throw new NotImplementedException();
        public string InvokedFunctionArn => throw new NotImplementedException();
        public ILambdaLogger Logger => throw new NotImplementedException();
        public string LogGroupName => throw new NotImplementedException();
        public string LogStreamName => throw new NotImplementedException();
        public int MemoryLimitInMB => throw new NotImplementedException();
        public TimeSpan RemainingTime => throw new NotImplementedException();
    }

}