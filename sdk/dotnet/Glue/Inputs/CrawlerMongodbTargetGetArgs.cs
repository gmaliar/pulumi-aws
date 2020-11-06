// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class CrawlerMongodbTargetGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the connection to use to connect to the Amazon DocumentDB or MongoDB target.
        /// </summary>
        [Input("connectionName", required: true)]
        public Input<string> ConnectionName { get; set; } = null!;

        /// <summary>
        /// The path of the Amazon DocumentDB or MongoDB target (database/collection).
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table. Default value is `true`.
        /// </summary>
        [Input("scanAll")]
        public Input<bool>? ScanAll { get; set; }

        public CrawlerMongodbTargetGetArgs()
        {
        }
    }
}
