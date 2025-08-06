package main

import (
	"github.com/aws/aws-cdk-go/awscdk/v2"
	"github.com/aws/aws-cdk-go/awscdk/v2/awslambda"
	"github.com/aws/constructs-go/constructs/v10"
	"github.com/aws/jsii-runtime-go"
)

type HelloCdkStackProps struct {
	awscdk.StackProps
}

func NewHelloCdkStack(scope constructs.Construct, id string, props *HelloCdkStackProps) awscdk.Stack {
	var sprops awscdk.StackProps
	if props != nil {
		sprops = props.StackProps
	}
	stack := awscdk.NewStack(scope, &id, &sprops)

	// Define the Lambda function resource
	myFunction := awslambda.NewFunction(stack, jsii.String("HelloWorldFunction"), &awslambda.FunctionProps{
		Runtime: awslambda.Runtime_NODEJS_18_X(), // Provide any supported Node.js runtime
		Handler: jsii.String("index.handler"),
		Code: awslambda.Code_FromInline(jsii.String(`
			exports.handler = async function(event) {
				return {
					statusCode: 200,
					body: JSON.stringify('Hello World!'),
				};
			};
		`)),
	})

	// Define the Lambda function URL resource
	myFunctionUrl := myFunction.AddFunctionUrl(&awslambda.FunctionUrlOptions{
		AuthType: awslambda.FunctionUrlAuthType_NONE,
	})

	// Define a CloudFormation output for your URL
	awscdk.NewCfnOutput(stack, jsii.String("myFunctionUrlOutput"), &awscdk.CfnOutputProps{
		Value: myFunctionUrl.Url(),
	})

	return stack
}

func main() {
	defer jsii.Close()

	app := awscdk.NewApp(nil)

	NewHelloCdkStack(app, "HelloCdkStack", &HelloCdkStackProps{
		awscdk.StackProps{
			Env: env(),
		},
	})

	app.Synth(nil)
}

func env() *awscdk.Environment {
	// Uncomment to specify account and region
	// return &awscdk.Environment{
	// 	Account: jsii.String("YOUR_ACCOUNT_ID"),
	// 	Region:  jsii.String("us-east-1"),
	// }
	return nil
}