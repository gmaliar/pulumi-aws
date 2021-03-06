// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class VpcPeeringConnectionAccepterRequester
    {
        /// <summary>
        /// Indicates whether a local ClassicLink connection can communicate
        /// with the peer VPC over the VPC Peering Connection.
        /// </summary>
        public readonly bool? AllowClassicLinkToRemoteVpc;
        /// <summary>
        /// Indicates whether a local VPC can resolve public DNS hostnames to
        /// private IP addresses when queried from instances in a peer VPC.
        /// </summary>
        public readonly bool? AllowRemoteVpcDnsResolution;
        /// <summary>
        /// Indicates whether a local VPC can communicate with a ClassicLink
        /// connection in the peer VPC over the VPC Peering Connection.
        /// </summary>
        public readonly bool? AllowVpcToRemoteClassicLink;

        [OutputConstructor]
        private VpcPeeringConnectionAccepterRequester(
            bool? allowClassicLinkToRemoteVpc,

            bool? allowRemoteVpcDnsResolution,

            bool? allowVpcToRemoteClassicLink)
        {
            AllowClassicLinkToRemoteVpc = allowClassicLinkToRemoteVpc;
            AllowRemoteVpcDnsResolution = allowRemoteVpcDnsResolution;
            AllowVpcToRemoteClassicLink = allowVpcToRemoteClassicLink;
        }
    }
}
