// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudWatch.Inputs
{

    public sealed class EventTargetEcsTargetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies an ECS task group for the task. The maximum length is 255 characters.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        /// <summary>
        /// Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values are `EC2` or `FARGATE`.
        /// </summary>
        [Input("launchType")]
        public Input<string>? LaunchType { get; set; }

        /// <summary>
        /// Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.
        /// </summary>
        [Input("networkConfiguration")]
        public Input<Inputs.EventTargetEcsTargetNetworkConfigurationArgs>? NetworkConfiguration { get; set; }

        /// <summary>
        /// Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see [AWS Fargate Platform Versions](http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
        /// </summary>
        [Input("platformVersion")]
        public Input<string>? PlatformVersion { get; set; }

        /// <summary>
        /// The number of tasks to create based on the TaskDefinition. The default is 1.
        /// </summary>
        [Input("taskCount")]
        public Input<int>? TaskCount { get; set; }

        /// <summary>
        /// The ARN of the task definition to use if the event target is an Amazon ECS cluster.
        /// </summary>
        [Input("taskDefinitionArn", required: true)]
        public Input<string> TaskDefinitionArn { get; set; } = null!;

        public EventTargetEcsTargetArgs()
        {
        }
    }
}
