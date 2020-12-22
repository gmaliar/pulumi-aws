// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecListenerConnectionPoolTcpArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of `1`.
        /// </summary>
        [Input("maxConnections", required: true)]
        public Input<int> MaxConnections { get; set; } = null!;

        public VirtualNodeSpecListenerConnectionPoolTcpArgs()
        {
        }
    }
}
