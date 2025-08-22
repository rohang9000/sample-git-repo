using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeServerlessApp
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new AcmeServerlessStack(app, "AcmeServerlessStack", new StackProps
            {
                // Env = new Amazon.CDK.Environment
                // {
                //     Account = "123456789012",
                //     Region = "us-east-1",
                // }
            });
            app.Synth();
        }
    }
}