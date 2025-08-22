#!/usr/bin/env node
import * as cdk from 'aws-cdk-lib';
import { ECommerceStack } from '../lib/stack';

const app = new cdk.App();
new ECommerceStack(app, 'ECommerceStack');