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
    public sealed class RouteSpecGrpcRouteMatchMetadataMatch
    {
        /// <summary>
        /// The value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.
        /// </summary>
        public readonly string? Exact;
        /// <summary>
        /// The value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.
        /// This parameter must always start with /, which by itself matches all requests to the virtual router service name.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// The object that specifies the range of numbers that the value sent by the client must be included in.
        /// </summary>
        public readonly Outputs.RouteSpecGrpcRouteMatchMetadataMatchRange? Range;
        /// <summary>
        /// The value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.
        /// </summary>
        public readonly string? Regex;
        /// <summary>
        /// The value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.
        /// </summary>
        public readonly string? Suffix;

        [OutputConstructor]
        private RouteSpecGrpcRouteMatchMetadataMatch(
            string? exact,

            string? prefix,

            Outputs.RouteSpecGrpcRouteMatchMetadataMatchRange? range,

            string? regex,

            string? suffix)
        {
            Exact = exact;
            Prefix = prefix;
            Range = range;
            Regex = regex;
            Suffix = suffix;
        }
    }
}
