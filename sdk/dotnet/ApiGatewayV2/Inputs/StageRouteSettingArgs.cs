// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGatewayV2.Inputs
{

    public sealed class StageRouteSettingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether data trace logging is enabled for the route. Affects the log entries pushed to Amazon CloudWatch Logs.
        /// Defaults to `false`. Supported only for WebSocket APIs.
        /// </summary>
        [Input("dataTraceEnabled")]
        public Input<bool>? DataTraceEnabled { get; set; }

        /// <summary>
        /// Whether detailed metrics are enabled for the route. Defaults to `false`.
        /// </summary>
        [Input("detailedMetricsEnabled")]
        public Input<bool>? DetailedMetricsEnabled { get; set; }

        /// <summary>
        /// The logging level for the route. Affects the log entries pushed to Amazon CloudWatch Logs.
        /// Valid values: `ERROR`, `INFO`, `OFF`. Defaults to `OFF`. Supported only for WebSocket APIs. This provider will only perform drift detection of its value when present in a configuration.
        /// </summary>
        [Input("loggingLevel")]
        public Input<string>? LoggingLevel { get; set; }

        /// <summary>
        /// Route key.
        /// </summary>
        [Input("routeKey", required: true)]
        public Input<string> RouteKey { get; set; } = null!;

        /// <summary>
        /// The throttling burst limit for the route.
        /// </summary>
        [Input("throttlingBurstLimit")]
        public Input<int>? ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// The throttling rate limit for the route.
        /// </summary>
        [Input("throttlingRateLimit")]
        public Input<double>? ThrottlingRateLimit { get; set; }

        public StageRouteSettingArgs()
        {
        }
    }
}
