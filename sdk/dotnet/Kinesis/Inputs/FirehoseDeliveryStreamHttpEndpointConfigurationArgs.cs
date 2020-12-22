// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamHttpEndpointConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the destination.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// Buffer incoming data for the specified period of time, in seconds, before delivering it to the destination. The default value is 300 (5 minutes).
        /// </summary>
        [Input("bufferingInterval")]
        public Input<int>? BufferingInterval { get; set; }

        /// <summary>
        /// Buffer incoming data to the specified size, in MBs, before delivering it to the destination. The default value is 5.
        /// </summary>
        [Input("bufferingSize")]
        public Input<int>? BufferingSize { get; set; }

        /// <summary>
        /// The CloudWatch Logging Options for the delivery stream. More details are given below.
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationCloudwatchLoggingOptionsArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// The HTTP endpoint name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The data processing configuration.  More details are given below.
        /// </summary>
        [Input("processingConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfigurationArgs>? ProcessingConfiguration { get; set; }

        /// <summary>
        /// The request configuration.  More details are given below.
        /// </summary>
        [Input("requestConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationArgs>? RequestConfiguration { get; set; }

        /// <summary>
        /// Total amount of seconds Firehose spends on retries. This duration starts after the initial attempt fails, It does not include the time periods during which Firehose waits for acknowledgment from the specified destination after each attempt. Valid values between `0` and `7200`. Default is `300`.
        /// </summary>
        [Input("retryDuration")]
        public Input<int>? RetryDuration { get; set; }

        /// <summary>
        /// Kinesis Data Firehose uses this IAM role for all the permissions that the delivery stream needs. The pattern needs to be `arn:.*`.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// Defines how documents should be delivered to Amazon S3.  Valid values are `FailedEventsOnly` and `AllEvents`.  Default value is `FailedEventsOnly`.
        /// </summary>
        [Input("s3BackupMode")]
        public Input<string>? S3BackupMode { get; set; }

        /// <summary>
        /// The HTTP endpoint URL to which Kinesis Firehose sends your data.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public FirehoseDeliveryStreamHttpEndpointConfigurationArgs()
        {
        }
    }
}
