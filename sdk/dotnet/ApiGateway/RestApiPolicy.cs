// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway
{
    /// <summary>
    /// ## Import
    /// 
    /// `aws_api_gateway_rest_api_policy` can be imported by using the REST API ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:apigateway/restApiPolicy:RestApiPolicy example 12345abcde
    /// ```
    /// </summary>
    public partial class RestApiPolicy : Pulumi.CustomResource
    {
        [Output("policy")]
        public Output<string> Policy { get; private set; } = null!;

        /// <summary>
        /// The ID of the REST API.
        /// </summary>
        [Output("restApiId")]
        public Output<string> RestApiId { get; private set; } = null!;


        /// <summary>
        /// Create a RestApiPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RestApiPolicy(string name, RestApiPolicyArgs args, CustomResourceOptions? options = null)
            : base("aws:apigateway/restApiPolicy:RestApiPolicy", name, args ?? new RestApiPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RestApiPolicy(string name, Input<string> id, RestApiPolicyState? state = null, CustomResourceOptions? options = null)
            : base("aws:apigateway/restApiPolicy:RestApiPolicy", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RestApiPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RestApiPolicy Get(string name, Input<string> id, RestApiPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new RestApiPolicy(name, id, state, options);
        }
    }

    public sealed class RestApiPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("policy", required: true)]
        public Input<string> Policy { get; set; } = null!;

        /// <summary>
        /// The ID of the REST API.
        /// </summary>
        [Input("restApiId", required: true)]
        public Input<string> RestApiId { get; set; } = null!;

        public RestApiPolicyArgs()
        {
        }
    }

    public sealed class RestApiPolicyState : Pulumi.ResourceArgs
    {
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        /// <summary>
        /// The ID of the REST API.
        /// </summary>
        [Input("restApiId")]
        public Input<string>? RestApiId { get; set; }

        public RestApiPolicyState()
        {
        }
    }
}
