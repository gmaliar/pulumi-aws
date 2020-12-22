// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Rds.Inputs
{

    public sealed class InstanceRestoreToPointInTimeGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with `use_latest_restorable_time`.
        /// </summary>
        [Input("restoreTime")]
        public Input<string>? RestoreTime { get; set; }

        /// <summary>
        /// The identifier of the source DB instance from which to restore. Must match the identifier of an existing DB instance. Required if `source_dbi_resource_id` is not specified.
        /// </summary>
        [Input("sourceDbInstanceIdentifier")]
        public Input<string>? SourceDbInstanceIdentifier { get; set; }

        /// <summary>
        /// The resource ID of the source DB instance from which to restore. Required if `source_db_instance_identifier` is not specified.
        /// </summary>
        [Input("sourceDbiResourceId")]
        public Input<string>? SourceDbiResourceId { get; set; }

        /// <summary>
        /// A boolean value that indicates whether the DB instance is restored from the latest backup time. Defaults to `false`. Cannot be specified with `restore_time`.
        /// </summary>
        [Input("useLatestRestorableTime")]
        public Input<bool>? UseLatestRestorableTime { get; set; }

        public InstanceRestoreToPointInTimeGetArgs()
        {
        }
    }
}
