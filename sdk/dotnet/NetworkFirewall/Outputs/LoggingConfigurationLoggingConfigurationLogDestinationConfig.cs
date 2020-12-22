// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class LoggingConfigurationLoggingConfigurationLogDestinationConfig
    {
        /// <summary>
        /// A map describing the logging destination for the chosen `log_destination_type`.
        /// * For an Amazon S3 bucket, specify the key `bucketName` with the name of the bucket and optionally specify the key `prefix` with a path.
        /// * For a CloudWatch log group, specify the key `logGroup` with the name of the CloudWatch log group.
        /// * For a Kinesis Data Firehose delivery stream, specify the key `deliveryStream` with the name of the delivery stream.
        /// </summary>
        public readonly ImmutableDictionary<string, string> LogDestination;
        /// <summary>
        /// The location to send logs to. Valid values: `S3`, `CloudWatchLogs`, `KinesisDataFirehose`.
        /// </summary>
        public readonly string LogDestinationType;
        /// <summary>
        /// The type of log to send. Valid values: `ALERT` or `FLOW`. Alert logs report traffic that matches a `StatefulRule` with an action setting that sends a log message. Flow logs are standard network traffic flow logs.
        /// </summary>
        public readonly string LogType;

        [OutputConstructor]
        private LoggingConfigurationLoggingConfigurationLogDestinationConfig(
            ImmutableDictionary<string, string> logDestination,

            string logDestinationType,

            string logType)
        {
            LogDestination = logDestination;
            LogDestinationType = logDestinationType;
            LogType = logType;
        }
    }
}
