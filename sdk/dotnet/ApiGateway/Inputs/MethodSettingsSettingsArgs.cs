// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway.Inputs
{

    public sealed class MethodSettingsSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether the cached responses are encrypted.
        /// </summary>
        [Input("cacheDataEncrypted")]
        public Input<bool>? CacheDataEncrypted { get; set; }

        /// <summary>
        /// Specifies the time to live (TTL), in seconds, for cached responses. The higher the TTL, the longer the response will be cached.
        /// </summary>
        [Input("cacheTtlInSeconds")]
        public Input<int>? CacheTtlInSeconds { get; set; }

        /// <summary>
        /// Specifies whether responses should be cached and returned for requests. A cache cluster must be enabled on the stage for responses to be cached.
        /// </summary>
        [Input("cachingEnabled")]
        public Input<bool>? CachingEnabled { get; set; }

        /// <summary>
        /// Specifies whether data trace logging is enabled for this method, which effects the log entries pushed to Amazon CloudWatch Logs.
        /// </summary>
        [Input("dataTraceEnabled")]
        public Input<bool>? DataTraceEnabled { get; set; }

        /// <summary>
        /// Specifies the logging level for this method, which effects the log entries pushed to Amazon CloudWatch Logs. The available levels are `OFF`, `ERROR`, and `INFO`.
        /// </summary>
        [Input("loggingLevel")]
        public Input<string>? LoggingLevel { get; set; }

        /// <summary>
        /// Specifies whether Amazon CloudWatch metrics are enabled for this method.
        /// </summary>
        [Input("metricsEnabled")]
        public Input<bool>? MetricsEnabled { get; set; }

        /// <summary>
        /// Specifies whether authorization is required for a cache invalidation request.
        /// </summary>
        [Input("requireAuthorizationForCacheControl")]
        public Input<bool>? RequireAuthorizationForCacheControl { get; set; }

        /// <summary>
        /// Specifies the throttling burst limit. Default: `-1` (throttling disabled).
        /// </summary>
        [Input("throttlingBurstLimit")]
        public Input<int>? ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// Specifies the throttling rate limit. Default: `-1` (throttling disabled).
        /// </summary>
        [Input("throttlingRateLimit")]
        public Input<double>? ThrottlingRateLimit { get; set; }

        /// <summary>
        /// Specifies how to handle unauthorized requests for cache invalidation. The available values are `FAIL_WITH_403`, `SUCCEED_WITH_RESPONSE_HEADER`, `SUCCEED_WITHOUT_RESPONSE_HEADER`.
        /// </summary>
        [Input("unauthorizedCacheControlHeaderStrategy")]
        public Input<string>? UnauthorizedCacheControlHeaderStrategy { get; set; }

        public MethodSettingsSettingsArgs()
        {
        }
    }
}
