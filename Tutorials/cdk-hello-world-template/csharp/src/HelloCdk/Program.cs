using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new HelloCdkStack(app, "HelloCdkStack", new StackProps
            {
                // Env = new Amazon.CDK.Environment
                // {
                //     Account = "YOUR_ACCOUNT_ID",
                //     Region = "us-east-1",
                // }
            });
            app.Synth();
        }
    }
}