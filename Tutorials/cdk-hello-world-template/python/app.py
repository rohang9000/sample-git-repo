#!/usr/bin/env python3
import os

import aws_cdk as cdk

from hello_cdk.hello_cdk_stack import AcmeServerlessStack

app = cdk.App()
AcmeServerlessStack(app, "AcmeServerlessStack",
    # env=cdk.Environment(account='123456789012', region='us-east-1'),
)

app.synth()