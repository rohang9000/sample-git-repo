from aws_cdk import (
    Stack,
    CfnOutput,
    aws_lambda as _lambda,
)
from constructs import Construct

class AcmeServerlessStack(Stack):

    def __init__(self, scope: Construct, construct_id: str, **kwargs) -> None:
        super().__init__(scope, construct_id, **kwargs)

        # Define the Lambda function resource
        my_function = _lambda.Function(
            self, "AcmeApiFunction",
            runtime=_lambda.Runtime.NODEJS_18_X,  # Provide any supported Node.js runtime
            handler="index.handler",
            code=_lambda.Code.from_inline(
                """
                exports.handler = async function(event) {
                  return {
                    statusCode: 200,
                    body: JSON.stringify('Welcome to Acme Corp API!'),
                  };
                };
                """
            ),
        )

        # Define the Lambda function URL resource
        my_function_url = my_function.add_function_url(
            auth_type=_lambda.FunctionUrlAuthType.NONE,
        )

        # Define a CloudFormation output for your URL
        CfnOutput(self, "AcmeFunctionUrlOutput", value=my_function_url.url)