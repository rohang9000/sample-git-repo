from aws_cdk import Stack, Duration
from aws_cdk import aws_sqs as sqs
from aws_cdk import aws_sns as sns
from aws_cdk import aws_sns_subscriptions as subs
from constructs import Construct

class DataProcessingStack(Stack):
    def __init__(self, scope: Construct, construct_id: str, **kwargs) -> None:
        super().__init__(scope, construct_id, **kwargs)

        queue = sqs.Queue(self, "DataProcessingQueue",
            visibility_timeout=Duration.seconds(300)
        )

        topic = sns.Topic(self, "DataProcessingTopic")

        topic.add_subscription(subs.SqsSubscription(queue))