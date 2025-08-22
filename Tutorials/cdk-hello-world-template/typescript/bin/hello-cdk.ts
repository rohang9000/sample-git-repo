#!/usr/bin/env node
import 'source-map-support/register';
import * as cdk from 'aws-cdk-lib';
import { AcmeServerlessStack } from '../lib/hello-cdk-stack';

const app = new cdk.App();
new AcmeServerlessStack(app, 'AcmeServerlessStack', {
  // env: { account: '123456789012', region: 'us-east-1' },
});