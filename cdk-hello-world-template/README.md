# CDK Hello World Template

A complete collection of AWS CDK Hello World projects in all supported programming languages. Each implementation creates a simple Lambda function with a public HTTP endpoint that returns "Hello World!".

## What's Included

- **Lambda Function** - Returns "Hello World!" message
- **Function URL** - Public HTTP endpoint to invoke the function
- **CloudFormation Output** - Displays the function URL after deployment

## Available Languages

| Language   | Directory      | Prerequisites                    |
|------------|----------------|----------------------------------|
| TypeScript | `typescript/`  | Node.js, npm                     |
| JavaScript | `javascript/`  | Node.js, npm                     |
| Python     | `python/`      | Python 3.7+, pip                |
| Java       | `java/`        | Java 8+, Maven                  |
| C#         | `csharp/`      | .NET 6.0+                       |
| Go         | `go/`          | Go 1.18+                        |

## Quick Start

1. **Choose your language** and navigate to the corresponding directory
2. **Install dependencies** (see language-specific README)
3. **Configure AWS credentials** (if not already done)
4. **Deploy the stack**:
   ```bash
   cdk deploy
   ```
5. **Test your function** using the output URL

## Common Commands

All language implementations support these CDK commands:

- `cdk list` - List all stacks in the app
- `cdk synth` - Synthesize CloudFormation template
- `cdk deploy` - Deploy stack to AWS
- `cdk diff` - Compare deployed stack with current state
- `cdk destroy` - Delete all resources

## Tutorial

This template follows the official [AWS CDK Hello World Tutorial](https://docs.aws.amazon.com/cdk/v2/guide/hello-world.html). Each language directory contains the complete implementation with language-specific setup instructions.

## Prerequisites

- AWS CLI configured with credentials
- AWS CDK CLI installed (`npm install -g aws-cdk`)
- Language-specific runtime (see table above)

## Architecture

```
┌─────────────────┐    HTTP Request    ┌──────────────────┐
│   Function URL  │ ──────────────────▶│ Lambda Function  │
│  (Public HTTP)  │                    │ (Hello World!)   │
└─────────────────┘                    └──────────────────┘
```

## Security Note

⚠️ **Warning**: The Lambda function URL is configured without authentication for tutorial purposes. This creates a publicly accessible endpoint. Remember to run `cdk destroy` when finished to clean up resources.