// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3Control.Outputs
{

    [OutputType]
    public sealed class BucketLifecycleConfigurationRuleFilter
    {
        /// <summary>
        /// Object prefix for rule filtering.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// Key-value map of object tags for rule filtering.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private BucketLifecycleConfigurationRuleFilter(
            string? prefix,

            ImmutableDictionary<string, string>? tags)
        {
            Prefix = prefix;
            Tags = tags;
        }
    }
}
