// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualGatewaySpecListenerConnectionPoolHttp
    {
        /// <summary>
        /// Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of `1`.
        /// </summary>
        public readonly int MaxConnections;
        /// <summary>
        /// Number of overflowing requests after `max_connections` Envoy will queue to upstream cluster. Minimum value of `1`.
        /// </summary>
        public readonly int? MaxPendingRequests;

        [OutputConstructor]
        private VirtualGatewaySpecListenerConnectionPoolHttp(
            int maxConnections,

            int? maxPendingRequests)
        {
            MaxConnections = maxConnections;
            MaxPendingRequests = maxPendingRequests;
        }
    }
}
