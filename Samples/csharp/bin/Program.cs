using Amazon.CDK;
using MyCdkApp;

var app = new App();
new MyCdkAppStack(app, "MyCdkAppStack");
app.Synth();