# Hello CDK (Python)

This is a minimal CDK Hello World project template based on the AWS CDK tutorial for Python.

## Getting Started

1. Create and activate a virtual environment:
   ```
   python3 -m venv .venv
   source .venv/bin/activate  # On Windows: .venv\Scripts\activate
   ```

2. Install dependencies:
   ```
   python -m pip install -r requirements.txt
   ```

3. Deploy the stack:
   ```
   cdk deploy
   ```

## What's Included

- A simple Lambda function that returns "Hello World!"
- Lambda function URL for HTTP access
- CloudFormation output for the function URL
- Python implementation using aws-cdk-lib

## Useful Commands

- `cdk deploy` - deploy this stack to your default AWS account/region
- `cdk diff` - compare deployed stack with current state
- `cdk synth` - emits the synthesized CloudFormation template
- `cdk destroy` - delete the stack and all resources

## Virtual Environment

Remember to activate your virtual environment before running CDK commands:
```
source .venv/bin/activate  # On Windows: .venv\Scripts\activate
```