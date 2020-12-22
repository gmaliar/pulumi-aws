// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class VirtualNodeSpecListenerTimeoutHttpIdleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unit of time. Valid values: `ms`, `s`.
        /// </summary>
        [Input("unit", required: true)]
        public Input<string> Unit { get; set; } = null!;

        /// <summary>
        /// The number of time units. Minimum value of `0`.
        /// </summary>
        [Input("value", required: true)]
        public Input<int> Value { get; set; } = null!;

        public VirtualNodeSpecListenerTimeoutHttpIdleGetArgs()
        {
        }
    }
}
