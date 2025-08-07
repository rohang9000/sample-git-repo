# Hello CDK (C#)

This is a minimal CDK Hello World project template based on the AWS CDK tutorial for C#.

## Prerequisites

- .NET 6.0 or later
- AWS CDK CLI

## Getting Started

1. Restore dependencies:
   ```
   dotnet restore src/
   ```

2. Build the project:
   ```
   dotnet build src/
   ```

3. Deploy the stack:
   ```
   cdk deploy
   ```

## What's Included

- A simple Lambda function that returns "Hello World!"
- Lambda function URL for HTTP access
- CloudFormation output for the function URL
- C# implementation using Amazon.CDK.Lib
- .NET 6.0 project configuration

## Useful Commands

- `dotnet build src/` - build the C# project
- `cdk deploy` - deploy this stack to your default AWS account/region
- `cdk diff` - compare deployed stack with current state
- `cdk synth` - emits the synthesized CloudFormation template
- `cdk destroy` - delete the stack and all resources

## Project Structure

- `src/HelloCdk/Program.cs` - Main application entry point
- `src/HelloCdk/HelloCdkStack.cs` - CDK stack definition
- `src/HelloCdk/HelloCdk.csproj` - .NET project file
- `cdk.json` - CDK configuration

## Visual Studio

If using Visual Studio, you can open the solution file in the `src` directory and build using F6 or the Build menu.