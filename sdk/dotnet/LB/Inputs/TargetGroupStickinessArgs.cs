// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Inputs
{

    public sealed class TargetGroupStickinessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only used when the type is `lb_cookie`. The time period, in seconds, during which requests from a client should be routed to the same target. After this time period expires, the load balancer-generated cookie is considered stale. The range is 1 second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// </summary>
        [Input("cookieDuration")]
        public Input<int>? CookieDuration { get; set; }

        /// <summary>
        /// Indicates whether  health checks are enabled. Defaults to true.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The type of sticky sessions. The only current possible values are `lb_cookie` for ALBs and `source_ip` for NLBs.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public TargetGroupStickinessArgs()
        {
        }
    }
}
