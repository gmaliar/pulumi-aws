// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall
{
    /// <summary>
    /// Provides an AWS Network Firewall Logging Configuration Resource
    /// 
    /// ## Example Usage
    /// ### Logging to S3
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.NetworkFirewall.LoggingConfiguration("example", new Aws.NetworkFirewall.LoggingConfigurationArgs
    ///         {
    ///             FirewallArn = aws_networkfirewall_firewall.Example.Arn,
    ///             LoggingConfiguration = new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationArgs
    ///             {
    ///                 LogDestinationConfigs = 
    ///                 {
    ///                     new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationLogDestinationConfigArgs
    ///                     {
    ///                         LogDestination = 
    ///                         {
    ///                             { "bucketName", aws_s3_bucket.Example.Bucket },
    ///                             { "prefix", "/example" },
    ///                         },
    ///                         LogDestinationType = "S3",
    ///                         LogType = "FLOW",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Logging to CloudWatch
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.NetworkFirewall.LoggingConfiguration("example", new Aws.NetworkFirewall.LoggingConfigurationArgs
    ///         {
    ///             FirewallArn = aws_networkfirewall_firewall.Example.Arn,
    ///             LoggingConfiguration = new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationArgs
    ///             {
    ///                 LogDestinationConfigs = 
    ///                 {
    ///                     new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationLogDestinationConfigArgs
    ///                     {
    ///                         LogDestination = 
    ///                         {
    ///                             { "logGroup", aws_cloudwatch_log_group.Example.Name },
    ///                         },
    ///                         LogDestinationType = "CloudWatchLogs",
    ///                         LogType = "ALERT",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Logging to Kinesis Data Firehose
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.NetworkFirewall.LoggingConfiguration("example", new Aws.NetworkFirewall.LoggingConfigurationArgs
    ///         {
    ///             FirewallArn = aws_networkfirewall_firewall.Example.Arn,
    ///             LoggingConfiguration = new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationArgs
    ///             {
    ///                 LogDestinationConfigs = 
    ///                 {
    ///                     new Aws.NetworkFirewall.Inputs.LoggingConfigurationLoggingConfigurationLogDestinationConfigArgs
    ///                     {
    ///                         LogDestination = 
    ///                         {
    ///                             { "deliveryStream", aws_kinesis_firehose_delivery_stream.Example.Name },
    ///                         },
    ///                         LogDestinationType = "KinesisDataFirehose",
    ///                         LogType = "ALERT",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Network Firewall Logging Configurations can be imported using the `firewall_arn` e.g
    /// 
    /// ```sh
    ///  $ pulumi import aws:networkfirewall/loggingConfiguration:LoggingConfiguration example arn:aws:network-firewall:us-west-1:123456789012:firewall/example
    /// ```
    /// </summary>
    public partial class LoggingConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the Network Firewall firewall.
        /// </summary>
        [Output("firewallArn")]
        public Output<string> FirewallArn { get; private set; } = null!;

        /// <summary>
        /// A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.
        /// </summary>
        [Output("loggingConfiguration")]
        public Output<Outputs.LoggingConfigurationLoggingConfiguration> LoggingConfig { get; private set; } = null!;


        /// <summary>
        /// Create a LoggingConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoggingConfiguration(string name, LoggingConfigurationArgs args, CustomResourceOptions? options = null)
            : base("aws:networkfirewall/loggingConfiguration:LoggingConfiguration", name, args ?? new LoggingConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoggingConfiguration(string name, Input<string> id, LoggingConfigurationState? state = null, CustomResourceOptions? options = null)
            : base("aws:networkfirewall/loggingConfiguration:LoggingConfiguration", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoggingConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoggingConfiguration Get(string name, Input<string> id, LoggingConfigurationState? state = null, CustomResourceOptions? options = null)
        {
            return new LoggingConfiguration(name, id, state, options);
        }
    }

    public sealed class LoggingConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the Network Firewall firewall.
        /// </summary>
        [Input("firewallArn", required: true)]
        public Input<string> FirewallArn { get; set; } = null!;

        /// <summary>
        /// A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.
        /// </summary>
        [Input("loggingConfiguration", required: true)]
        public Input<Inputs.LoggingConfigurationLoggingConfigurationArgs> LoggingConfig { get; set; } = null!;

        public LoggingConfigurationArgs()
        {
        }
    }

    public sealed class LoggingConfigurationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the Network Firewall firewall.
        /// </summary>
        [Input("firewallArn")]
        public Input<string>? FirewallArn { get; set; }

        /// <summary>
        /// A configuration block describing how AWS Network Firewall performs logging for a firewall. See Logging Configuration below for details.
        /// </summary>
        [Input("loggingConfiguration")]
        public Input<Inputs.LoggingConfigurationLoggingConfigurationGetArgs>? LoggingConfig { get; set; }

        public LoggingConfigurationState()
        {
        }
    }
}
