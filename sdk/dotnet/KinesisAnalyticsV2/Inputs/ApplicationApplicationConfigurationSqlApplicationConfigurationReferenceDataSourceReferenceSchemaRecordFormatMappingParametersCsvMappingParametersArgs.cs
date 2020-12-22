// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.KinesisAnalyticsV2.Inputs
{

    public sealed class ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The column delimiter. For example, in a CSV format, a comma (`,`) is the typical column delimiter.
        /// </summary>
        [Input("recordColumnDelimiter", required: true)]
        public Input<string> RecordColumnDelimiter { get; set; } = null!;

        /// <summary>
        /// The row delimiter. For example, in a CSV format, `\n` is the typical row delimiter.
        /// </summary>
        [Input("recordRowDelimiter", required: true)]
        public Input<string> RecordRowDelimiter { get; set; } = null!;

        public ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParametersArgs()
        {
        }
    }
}
