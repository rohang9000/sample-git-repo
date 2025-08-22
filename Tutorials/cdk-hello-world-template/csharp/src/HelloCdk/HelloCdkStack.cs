using Amazon.CDK;
using Constructs;
// Import the Lambda module
using Amazon.CDK.AWS.Lambda;

namespace AcmeServerlessApp
{
    public class AcmeServerlessStack : Stack
    {
        internal HelloCdkStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // Define the Lambda function resource
            var myFunction = new Function(this, "AcmeApiFunction", new FunctionProps
            {
                Runtime = Runtime.NODEJS_18_X, // Provide any supported Node.js runtime
                Handler = "index.handler",
                Code = Code.FromInline(@"
                    exports.handler = async function(event) {
                        return {
                            statusCode: 200,
                            body: JSON.stringify('Welcome to Acme Corp API!'),
                        };
                    };
                "),
            });

            // Define the Lambda function URL resource
            var myFunctionUrl = myFunction.AddFunctionUrl(new FunctionUrlOptions
            {
                AuthType = FunctionUrlAuthType.NONE
            });

            // Define a CloudFormation output for your URL
            new CfnOutput(this, "AcmeFunctionUrlOutput", new CfnOutputProps
            {
                Value = myFunctionUrl.Url
            });
        }
    }
}