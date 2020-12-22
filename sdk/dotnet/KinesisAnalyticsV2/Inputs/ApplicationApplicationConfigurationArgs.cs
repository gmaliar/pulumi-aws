// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.KinesisAnalyticsV2.Inputs
{

    public sealed class ApplicationApplicationConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The code location and type parameters for the application.
        /// </summary>
        [Input("applicationCodeConfiguration", required: true)]
        public Input<Inputs.ApplicationApplicationConfigurationApplicationCodeConfigurationArgs> ApplicationCodeConfiguration { get; set; } = null!;

        /// <summary>
        /// Describes whether snapshots are enabled for a Flink-based application.
        /// </summary>
        [Input("applicationSnapshotConfiguration")]
        public Input<Inputs.ApplicationApplicationConfigurationApplicationSnapshotConfigurationArgs>? ApplicationSnapshotConfiguration { get; set; }

        /// <summary>
        /// Describes execution properties for a Flink-based application.
        /// </summary>
        [Input("environmentProperties")]
        public Input<Inputs.ApplicationApplicationConfigurationEnvironmentPropertiesArgs>? EnvironmentProperties { get; set; }

        /// <summary>
        /// The configuration of a Flink-based application.
        /// </summary>
        [Input("flinkApplicationConfiguration")]
        public Input<Inputs.ApplicationApplicationConfigurationFlinkApplicationConfigurationArgs>? FlinkApplicationConfiguration { get; set; }

        /// <summary>
        /// The configuration of a SQL-based application.
        /// </summary>
        [Input("sqlApplicationConfiguration")]
        public Input<Inputs.ApplicationApplicationConfigurationSqlApplicationConfigurationArgs>? SqlApplicationConfiguration { get; set; }

        /// <summary>
        /// The VPC configuration of a Flink-based application.
        /// </summary>
        [Input("vpcConfiguration")]
        public Input<Inputs.ApplicationApplicationConfigurationVpcConfigurationArgs>? VpcConfiguration { get; set; }

        public ApplicationApplicationConfigurationArgs()
        {
        }
    }
}
