#!/usr/bin/env node
import * as cdk from 'aws-cdk-lib';
import { InventoryStack } from '../lib/my-stack.js';

const app = new cdk.App();
new InventoryStack(app, 'NorthwindInventoryStack');