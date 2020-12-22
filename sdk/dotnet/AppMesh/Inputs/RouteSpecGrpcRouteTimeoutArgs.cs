// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecGrpcRouteTimeoutArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The idle timeout. An idle timeout bounds the amount of time that a connection may be idle.
        /// </summary>
        [Input("idle")]
        public Input<Inputs.RouteSpecGrpcRouteTimeoutIdleArgs>? Idle { get; set; }

        /// <summary>
        /// The per request timeout.
        /// </summary>
        [Input("perRequest")]
        public Input<Inputs.RouteSpecGrpcRouteTimeoutPerRequestArgs>? PerRequest { get; set; }

        public RouteSpecGrpcRouteTimeoutArgs()
        {
        }
    }
}
