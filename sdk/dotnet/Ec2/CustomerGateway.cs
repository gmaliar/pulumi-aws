// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides a customer gateway inside a VPC. These objects can be connected to VPN gateways via VPN connections, and allow you to establish tunnels between your network and the VPC.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var main = new Aws.Ec2.CustomerGateway("main", new Aws.Ec2.CustomerGatewayArgs
    ///         {
    ///             BgpAsn = "65000",
    ///             IpAddress = "172.83.124.10",
    ///             Tags = 
    ///             {
    ///                 { "Name", "main-customer-gateway" },
    ///             },
    ///             Type = "ipsec.1",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Customer Gateways can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:ec2/customerGateway:CustomerGateway main cgw-b4dc3961
    /// ```
    /// </summary>
    public partial class CustomerGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the customer gateway.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        /// </summary>
        [Output("bgpAsn")]
        public Output<string> BgpAsn { get; private set; } = null!;

        /// <summary>
        /// The IP address of the gateway's Internet-routable external interface.
        /// </summary>
        [Output("ipAddress")]
        public Output<string> IpAddress { get; private set; } = null!;

        /// <summary>
        /// Tags to apply to the gateway.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of customer gateway. The only type AWS
        /// supports at this time is "ipsec.1".
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a CustomerGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomerGateway(string name, CustomerGatewayArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/customerGateway:CustomerGateway", name, args ?? new CustomerGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomerGateway(string name, Input<string> id, CustomerGatewayState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/customerGateway:CustomerGateway", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CustomerGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomerGateway Get(string name, Input<string> id, CustomerGatewayState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomerGateway(name, id, state, options);
        }
    }

    public sealed class CustomerGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        /// </summary>
        [Input("bgpAsn", required: true)]
        public Input<string> BgpAsn { get; set; } = null!;

        /// <summary>
        /// The IP address of the gateway's Internet-routable external interface.
        /// </summary>
        [Input("ipAddress", required: true)]
        public Input<string> IpAddress { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags to apply to the gateway.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of customer gateway. The only type AWS
        /// supports at this time is "ipsec.1".
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CustomerGatewayArgs()
        {
        }
    }

    public sealed class CustomerGatewayState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the customer gateway.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        /// </summary>
        [Input("bgpAsn")]
        public Input<string>? BgpAsn { get; set; }

        /// <summary>
        /// The IP address of the gateway's Internet-routable external interface.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags to apply to the gateway.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of customer gateway. The only type AWS
        /// supports at this time is "ipsec.1".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public CustomerGatewayState()
        {
        }
    }
}
