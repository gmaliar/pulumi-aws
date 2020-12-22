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
    public sealed class RouteSpecHttp2RouteTimeoutPerRequest
    {
        /// <summary>
        /// The unit of time. Valid values: `ms`, `s`.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// The number of time units. Minimum value of `0`.
        /// </summary>
        public readonly int Value;

        [OutputConstructor]
        private RouteSpecHttp2RouteTimeoutPerRequest(
            string unit,

            int value)
        {
            Unit = unit;
            Value = value;
        }
    }
}
