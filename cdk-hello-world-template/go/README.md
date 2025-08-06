# Hello CDK (Go)

This is a minimal CDK Hello World project template based on the AWS CDK tutorial for Go.

## Prerequisites

- Go 1.18 or later
- AWS CDK CLI

## Getting Started

1. Download dependencies:
   ```
   go get
   ```

2. Build the project (optional):
   ```
   go build
   ```

3. Deploy the stack:
   ```
   cdk deploy
   ```

## What's Included

- A simple Lambda function that returns "Hello World!"
- Lambda function URL for HTTP access
- CloudFormation output for the function URL
- Go implementation using aws-cdk-go
- Go modules configuration

## Useful Commands

- `go get` - download Go module dependencies
- `go build` - build the Go application
- `cdk deploy` - deploy this stack to your default AWS account/region
- `cdk diff` - compare deployed stack with current state
- `cdk synth` - emits the synthesized CloudFormation template
- `cdk destroy` - delete the stack and all resources

## Project Structure

- `hello-cdk.go` - Main application file with stack definition
- `go.mod` - Go module file with dependencies
- `cdk.json` - CDK configuration

## Go-Specific Notes

- Uses `jsii.String()` to convert Go strings to JSII strings
- Uses `defer jsii.Close()` to properly clean up JSII runtime
- Function calls use method syntax (e.g., `myFunction.AddFunctionUrl()`)
- Pointers are used for struct parameters