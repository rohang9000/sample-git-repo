package com.acmecorp;

import software.amazon.awscdk.App;
import software.amazon.awscdk.Environment;
import software.amazon.awscdk.StackProps;

public class HelloCdkApp {
    public static void main(final String[] args) {
        App app = new App();

        new HelloCdkStack(app, "HelloCdkStack", StackProps.builder()
                // .env(Environment.builder()
                //         .account("123456789012")
                //         .region("us-east-1")
                //         .build())
                .build());

        app.synth();
    }
}