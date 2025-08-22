#!/usr/bin/env python3
import aws_cdk as cdk
from my_cdk_project.my_cdk_project_stack import DataProcessingStack

app = cdk.App()
DataProcessingStack(app, "DataProcessingStack")
app.synth()