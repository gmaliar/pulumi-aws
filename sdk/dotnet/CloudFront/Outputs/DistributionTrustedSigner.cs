// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Outputs
{

    [OutputType]
    public sealed class DistributionTrustedSigner
    {
        /// <summary>
        /// Whether the distribution is enabled to accept end
        /// user requests for content.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// List of nested attributes for each trusted signer
        /// </summary>
        public readonly ImmutableArray<Outputs.DistributionTrustedSignerItem> Items;

        [OutputConstructor]
        private DistributionTrustedSigner(
            bool? enabled,

            ImmutableArray<Outputs.DistributionTrustedSignerItem> items)
        {
            Enabled = enabled;
            Items = items;
        }
    }
}
