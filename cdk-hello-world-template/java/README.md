# Hello CDK (Java)

This is a minimal CDK Hello World project template based on the AWS CDK tutorial for Java.

## Prerequisites

- Java 8 (1.8) or later
- Maven 3.6 or later
- AWS CDK CLI

## Getting Started

1. Compile the project:
   ```
   mvn compile
   ```

2. Deploy the stack:
   ```
   cdk deploy
   ```

## What's Included

- A simple Lambda function that returns "Hello World!"
- Lambda function URL for HTTP access
- CloudFormation output for the function URL
- Java implementation using aws-cdk-lib
- Maven build configuration

## Useful Commands

- `mvn compile` - compile the Java code
- `cdk deploy` - deploy this stack to your default AWS account/region
- `cdk diff` - compare deployed stack with current state
- `cdk synth` - emits the synthesized CloudFormation template
- `cdk destroy` - delete the stack and all resources

## Project Structure

- `src/main/java/com/myorg/HelloCdkApp.java` - Main application entry point
- `src/main/java/com/myorg/HelloCdkStack.java` - CDK stack definition
- `pom.xml` - Maven project configuration
- `cdk.json` - CDK configuration