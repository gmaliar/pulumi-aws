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
    public sealed class RouteSpecHttp2RouteActionWeightedTarget
    {
        /// <summary>
        /// The virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.
        /// </summary>
        public readonly string VirtualNode;
        /// <summary>
        /// The relative weight of the weighted target. An integer between 0 and 100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private RouteSpecHttp2RouteActionWeightedTarget(
            string virtualNode,

            int weight)
        {
            VirtualNode = virtualNode;
            Weight = weight;
        }
    }
}
