// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualGatewaySpecListenerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The connection pool information for the listener.
        /// </summary>
        [Input("connectionPool")]
        public Input<Inputs.VirtualGatewaySpecListenerConnectionPoolArgs>? ConnectionPool { get; set; }

        /// <summary>
        /// The health check information for the listener.
        /// </summary>
        [Input("healthCheck")]
        public Input<Inputs.VirtualGatewaySpecListenerHealthCheckArgs>? HealthCheck { get; set; }

        /// <summary>
        /// The port mapping information for the listener.
        /// </summary>
        [Input("portMapping", required: true)]
        public Input<Inputs.VirtualGatewaySpecListenerPortMappingArgs> PortMapping { get; set; } = null!;

        /// <summary>
        /// The Transport Layer Security (TLS) properties for the listener
        /// </summary>
        [Input("tls")]
        public Input<Inputs.VirtualGatewaySpecListenerTlsArgs>? Tls { get; set; }

        public VirtualGatewaySpecListenerArgs()
        {
        }
    }
}
