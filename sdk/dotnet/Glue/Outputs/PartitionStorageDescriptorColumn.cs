// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Outputs
{

    [OutputType]
    public sealed class PartitionStorageDescriptorColumn
    {
        /// <summary>
        /// Free-form text comment.
        /// </summary>
        public readonly string? Comment;
        /// <summary>
        /// Name of the SerDe.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The datatype of data in the Column.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private PartitionStorageDescriptorColumn(
            string? comment,

            string name,

            string? type)
        {
            Comment = comment;
            Name = name;
            Type = type;
        }
    }
}
