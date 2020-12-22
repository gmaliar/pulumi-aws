// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualGatewaySpecListenerConnectionPoolGrpcArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of `1`.
        /// </summary>
        [Input("maxRequests", required: true)]
        public Input<int> MaxRequests { get; set; } = null!;

        public VirtualGatewaySpecListenerConnectionPoolGrpcArgs()
        {
        }
    }
}
