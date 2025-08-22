package com.stellartech;

import software.amazon.awscdk.App;
import software.amazon.awscdk.assertions.Template;
import org.junit.jupiter.api.Test;

public class NotificationStackTest {

    @Test
    public void testStack() {
        App app = new App();
        NotificationStack stack = new NotificationStack(app, "TestStack", null);

        Template template = Template.fromStack(stack);

        template.hasResourceProperties("AWS::SQS::Queue", 
            java.util.Map.of("VisibilityTimeout", 300));
        template.resourceCountIs("AWS::SNS::Topic", 1);
    }
}