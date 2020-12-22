// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ImageBuilder.Inputs
{

    public sealed class InfrastructureConfigurationLoggingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block with S3 logging settings. Detailed below.
        /// </summary>
        [Input("s3Logs", required: true)]
        public Input<Inputs.InfrastructureConfigurationLoggingS3LogsArgs> S3Logs { get; set; } = null!;

        public InfrastructureConfigurationLoggingArgs()
        {
        }
    }
}
