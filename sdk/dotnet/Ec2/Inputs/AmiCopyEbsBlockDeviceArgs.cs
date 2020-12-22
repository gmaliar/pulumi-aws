// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class AmiCopyEbsBlockDeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean controlling whether the EBS volumes created to
        /// support each created instance will be deleted once that instance is terminated.
        /// </summary>
        [Input("deleteOnTermination")]
        public Input<bool>? DeleteOnTermination { get; set; }

        /// <summary>
        /// The path at which the device is exposed to created instances.
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// Boolean controlling whether the created EBS volumes will be encrypted. Can't be used with `snapshot_id`.
        /// </summary>
        [Input("encrypted")]
        public Input<bool>? Encrypted { get; set; }

        /// <summary>
        /// Number of I/O operations per second the
        /// created volumes will support.
        /// </summary>
        [Input("iops")]
        public Input<int>? Iops { get; set; }

        /// <summary>
        /// The id of an EBS snapshot that will be used to initialize the created
        /// EBS volumes. If set, the `volume_size` attribute must be at least as large as the referenced
        /// snapshot.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// The size of created volumes in GiB.
        /// If `snapshot_id` is set and `volume_size` is omitted then the volume will have the same size
        /// as the selected snapshot.
        /// </summary>
        [Input("volumeSize")]
        public Input<int>? VolumeSize { get; set; }

        /// <summary>
        /// The type of EBS volume to create. Can be one of "standard" (the
        /// default), "io1", "io2" or "gp2".
        /// </summary>
        [Input("volumeType")]
        public Input<string>? VolumeType { get; set; }

        public AmiCopyEbsBlockDeviceArgs()
        {
        }
    }
}
