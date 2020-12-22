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
    /// Manages an EC2 VPN connection. These objects can be connected to customer gateways, and allow you to establish tunnels between your network and Amazon.
    /// 
    /// &gt; **Note:** All arguments including `tunnel1_preshared_key` and `tunnel2_preshared_key` will be stored in the raw state as plain-text.
    /// 
    /// &gt; **Note:** The CIDR blocks in the arguments `tunnel1_inside_cidr` and `tunnel2_inside_cidr` must have a prefix of /30 and be a part of a specific range.
    /// [Read more about this in the AWS documentation](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_VpnTunnelOptionsSpecification.html).
    /// 
    /// ## Example Usage
    /// ### EC2 Transit Gateway
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleTransitGateway = new Aws.Ec2TransitGateway.TransitGateway("exampleTransitGateway", new Aws.Ec2TransitGateway.TransitGatewayArgs
    ///         {
    ///         });
    ///         var exampleCustomerGateway = new Aws.Ec2.CustomerGateway("exampleCustomerGateway", new Aws.Ec2.CustomerGatewayArgs
    ///         {
    ///             BgpAsn = "65000",
    ///             IpAddress = "172.0.0.1",
    ///             Type = "ipsec.1",
    ///         });
    ///         var exampleVpnConnection = new Aws.Ec2.VpnConnection("exampleVpnConnection", new Aws.Ec2.VpnConnectionArgs
    ///         {
    ///             CustomerGatewayId = exampleCustomerGateway.Id,
    ///             TransitGatewayId = exampleTransitGateway.Id,
    ///             Type = exampleCustomerGateway.Type,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Virtual Private Gateway
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var vpc = new Aws.Ec2.Vpc("vpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///         });
    ///         var vpnGateway = new Aws.Ec2.VpnGateway("vpnGateway", new Aws.Ec2.VpnGatewayArgs
    ///         {
    ///             VpcId = vpc.Id,
    ///         });
    ///         var customerGateway = new Aws.Ec2.CustomerGateway("customerGateway", new Aws.Ec2.CustomerGatewayArgs
    ///         {
    ///             BgpAsn = "65000",
    ///             IpAddress = "172.0.0.1",
    ///             Type = "ipsec.1",
    ///         });
    ///         var main = new Aws.Ec2.VpnConnection("main", new Aws.Ec2.VpnConnectionArgs
    ///         {
    ///             VpnGatewayId = vpnGateway.Id,
    ///             CustomerGatewayId = customerGateway.Id,
    ///             Type = "ipsec.1",
    ///             StaticRoutesOnly = true,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// VPN Connections can be imported using the `vpn connection id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:ec2/vpnConnection:VpnConnection testvpnconnection vpn-40f41529
    /// ```
    /// </summary>
    public partial class VpnConnection : Pulumi.CustomResource
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the VPN Connection.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The configuration information for the VPN connection's customer gateway (in the native XML format).
        /// </summary>
        [Output("customerGatewayConfiguration")]
        public Output<string> CustomerGatewayConfiguration { get; private set; } = null!;

        /// <summary>
        /// The ID of the customer gateway.
        /// </summary>
        [Output("customerGatewayId")]
        public Output<string> CustomerGatewayId { get; private set; } = null!;

        [Output("routes")]
        public Output<ImmutableArray<Outputs.VpnConnectionRoute>> Routes { get; private set; } = null!;

        /// <summary>
        /// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
        /// </summary>
        [Output("staticRoutesOnly")]
        public Output<bool> StaticRoutesOnly { get; private set; } = null!;

        /// <summary>
        /// Tags to apply to the connection.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// When associated with an EC2 Transit Gateway (`transit_gateway_id` argument), the attachment ID. See also the [`aws.ec2.Tag` resource](https://www.terraform.io/docs/providers/aws/r/ec2_tag.html) for tagging the EC2 Transit Gateway VPN Attachment.
        /// </summary>
        [Output("transitGatewayAttachmentId")]
        public Output<string> TransitGatewayAttachmentId { get; private set; } = null!;

        /// <summary>
        /// The ID of the EC2 Transit Gateway.
        /// </summary>
        [Output("transitGatewayId")]
        public Output<string?> TransitGatewayId { get; private set; } = null!;

        /// <summary>
        /// The public IP address of the first VPN tunnel.
        /// </summary>
        [Output("tunnel1Address")]
        public Output<string> Tunnel1Address { get; private set; } = null!;

        /// <summary>
        /// The bgp asn number of the first VPN tunnel.
        /// </summary>
        [Output("tunnel1BgpAsn")]
        public Output<string> Tunnel1BgpAsn { get; private set; } = null!;

        /// <summary>
        /// The bgp holdtime of the first VPN tunnel.
        /// </summary>
        [Output("tunnel1BgpHoldtime")]
        public Output<int> Tunnel1BgpHoldtime { get; private set; } = null!;

        /// <summary>
        /// The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
        /// </summary>
        [Output("tunnel1CgwInsideAddress")]
        public Output<string> Tunnel1CgwInsideAddress { get; private set; } = null!;

        /// <summary>
        /// The CIDR block of the inside IP addresses for the first VPN tunnel.
        /// </summary>
        [Output("tunnel1InsideCidr")]
        public Output<string> Tunnel1InsideCidr { get; private set; } = null!;

        /// <summary>
        /// The preshared key of the first VPN tunnel.
        /// </summary>
        [Output("tunnel1PresharedKey")]
        public Output<string> Tunnel1PresharedKey { get; private set; } = null!;

        /// <summary>
        /// The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
        /// </summary>
        [Output("tunnel1VgwInsideAddress")]
        public Output<string> Tunnel1VgwInsideAddress { get; private set; } = null!;

        /// <summary>
        /// The public IP address of the second VPN tunnel.
        /// </summary>
        [Output("tunnel2Address")]
        public Output<string> Tunnel2Address { get; private set; } = null!;

        /// <summary>
        /// The bgp asn number of the second VPN tunnel.
        /// </summary>
        [Output("tunnel2BgpAsn")]
        public Output<string> Tunnel2BgpAsn { get; private set; } = null!;

        /// <summary>
        /// The bgp holdtime of the second VPN tunnel.
        /// </summary>
        [Output("tunnel2BgpHoldtime")]
        public Output<int> Tunnel2BgpHoldtime { get; private set; } = null!;

        /// <summary>
        /// The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
        /// </summary>
        [Output("tunnel2CgwInsideAddress")]
        public Output<string> Tunnel2CgwInsideAddress { get; private set; } = null!;

        /// <summary>
        /// The CIDR block of the inside IP addresses for the second VPN tunnel.
        /// </summary>
        [Output("tunnel2InsideCidr")]
        public Output<string> Tunnel2InsideCidr { get; private set; } = null!;

        /// <summary>
        /// The preshared key of the second VPN tunnel.
        /// </summary>
        [Output("tunnel2PresharedKey")]
        public Output<string> Tunnel2PresharedKey { get; private set; } = null!;

        /// <summary>
        /// The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
        /// </summary>
        [Output("tunnel2VgwInsideAddress")]
        public Output<string> Tunnel2VgwInsideAddress { get; private set; } = null!;

        /// <summary>
        /// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        [Output("vgwTelemetries")]
        public Output<ImmutableArray<Outputs.VpnConnectionVgwTelemetry>> VgwTelemetries { get; private set; } = null!;

        /// <summary>
        /// The ID of the Virtual Private Gateway.
        /// </summary>
        [Output("vpnGatewayId")]
        public Output<string?> VpnGatewayId { get; private set; } = null!;


        /// <summary>
        /// Create a VpnConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpnConnection(string name, VpnConnectionArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/vpnConnection:VpnConnection", name, args ?? new VpnConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpnConnection(string name, Input<string> id, VpnConnectionState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/vpnConnection:VpnConnection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VpnConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpnConnection Get(string name, Input<string> id, VpnConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new VpnConnection(name, id, state, options);
        }
    }

    public sealed class VpnConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the customer gateway.
        /// </summary>
        [Input("customerGatewayId", required: true)]
        public Input<string> CustomerGatewayId { get; set; } = null!;

        /// <summary>
        /// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
        /// </summary>
        [Input("staticRoutesOnly")]
        public Input<bool>? StaticRoutesOnly { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags to apply to the connection.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The ID of the EC2 Transit Gateway.
        /// </summary>
        [Input("transitGatewayId")]
        public Input<string>? TransitGatewayId { get; set; }

        /// <summary>
        /// The CIDR block of the inside IP addresses for the first VPN tunnel.
        /// </summary>
        [Input("tunnel1InsideCidr")]
        public Input<string>? Tunnel1InsideCidr { get; set; }

        /// <summary>
        /// The preshared key of the first VPN tunnel.
        /// </summary>
        [Input("tunnel1PresharedKey")]
        public Input<string>? Tunnel1PresharedKey { get; set; }

        /// <summary>
        /// The CIDR block of the inside IP addresses for the second VPN tunnel.
        /// </summary>
        [Input("tunnel2InsideCidr")]
        public Input<string>? Tunnel2InsideCidr { get; set; }

        /// <summary>
        /// The preshared key of the second VPN tunnel.
        /// </summary>
        [Input("tunnel2PresharedKey")]
        public Input<string>? Tunnel2PresharedKey { get; set; }

        /// <summary>
        /// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The ID of the Virtual Private Gateway.
        /// </summary>
        [Input("vpnGatewayId")]
        public Input<string>? VpnGatewayId { get; set; }

        public VpnConnectionArgs()
        {
        }
    }

    public sealed class VpnConnectionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the VPN Connection.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The configuration information for the VPN connection's customer gateway (in the native XML format).
        /// </summary>
        [Input("customerGatewayConfiguration")]
        public Input<string>? CustomerGatewayConfiguration { get; set; }

        /// <summary>
        /// The ID of the customer gateway.
        /// </summary>
        [Input("customerGatewayId")]
        public Input<string>? CustomerGatewayId { get; set; }

        [Input("routes")]
        private InputList<Inputs.VpnConnectionRouteGetArgs>? _routes;
        public InputList<Inputs.VpnConnectionRouteGetArgs> Routes
        {
            get => _routes ?? (_routes = new InputList<Inputs.VpnConnectionRouteGetArgs>());
            set => _routes = value;
        }

        /// <summary>
        /// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
        /// </summary>
        [Input("staticRoutesOnly")]
        public Input<bool>? StaticRoutesOnly { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags to apply to the connection.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// When associated with an EC2 Transit Gateway (`transit_gateway_id` argument), the attachment ID. See also the [`aws.ec2.Tag` resource](https://www.terraform.io/docs/providers/aws/r/ec2_tag.html) for tagging the EC2 Transit Gateway VPN Attachment.
        /// </summary>
        [Input("transitGatewayAttachmentId")]
        public Input<string>? TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// The ID of the EC2 Transit Gateway.
        /// </summary>
        [Input("transitGatewayId")]
        public Input<string>? TransitGatewayId { get; set; }

        /// <summary>
        /// The public IP address of the first VPN tunnel.
        /// </summary>
        [Input("tunnel1Address")]
        public Input<string>? Tunnel1Address { get; set; }

        /// <summary>
        /// The bgp asn number of the first VPN tunnel.
        /// </summary>
        [Input("tunnel1BgpAsn")]
        public Input<string>? Tunnel1BgpAsn { get; set; }

        /// <summary>
        /// The bgp holdtime of the first VPN tunnel.
        /// </summary>
        [Input("tunnel1BgpHoldtime")]
        public Input<int>? Tunnel1BgpHoldtime { get; set; }

        /// <summary>
        /// The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
        /// </summary>
        [Input("tunnel1CgwInsideAddress")]
        public Input<string>? Tunnel1CgwInsideAddress { get; set; }

        /// <summary>
        /// The CIDR block of the inside IP addresses for the first VPN tunnel.
        /// </summary>
        [Input("tunnel1InsideCidr")]
        public Input<string>? Tunnel1InsideCidr { get; set; }

        /// <summary>
        /// The preshared key of the first VPN tunnel.
        /// </summary>
        [Input("tunnel1PresharedKey")]
        public Input<string>? Tunnel1PresharedKey { get; set; }

        /// <summary>
        /// The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
        /// </summary>
        [Input("tunnel1VgwInsideAddress")]
        public Input<string>? Tunnel1VgwInsideAddress { get; set; }

        /// <summary>
        /// The public IP address of the second VPN tunnel.
        /// </summary>
        [Input("tunnel2Address")]
        public Input<string>? Tunnel2Address { get; set; }

        /// <summary>
        /// The bgp asn number of the second VPN tunnel.
        /// </summary>
        [Input("tunnel2BgpAsn")]
        public Input<string>? Tunnel2BgpAsn { get; set; }

        /// <summary>
        /// The bgp holdtime of the second VPN tunnel.
        /// </summary>
        [Input("tunnel2BgpHoldtime")]
        public Input<int>? Tunnel2BgpHoldtime { get; set; }

        /// <summary>
        /// The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
        /// </summary>
        [Input("tunnel2CgwInsideAddress")]
        public Input<string>? Tunnel2CgwInsideAddress { get; set; }

        /// <summary>
        /// The CIDR block of the inside IP addresses for the second VPN tunnel.
        /// </summary>
        [Input("tunnel2InsideCidr")]
        public Input<string>? Tunnel2InsideCidr { get; set; }

        /// <summary>
        /// The preshared key of the second VPN tunnel.
        /// </summary>
        [Input("tunnel2PresharedKey")]
        public Input<string>? Tunnel2PresharedKey { get; set; }

        /// <summary>
        /// The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
        /// </summary>
        [Input("tunnel2VgwInsideAddress")]
        public Input<string>? Tunnel2VgwInsideAddress { get; set; }

        /// <summary>
        /// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("vgwTelemetries")]
        private InputList<Inputs.VpnConnectionVgwTelemetryGetArgs>? _vgwTelemetries;
        public InputList<Inputs.VpnConnectionVgwTelemetryGetArgs> VgwTelemetries
        {
            get => _vgwTelemetries ?? (_vgwTelemetries = new InputList<Inputs.VpnConnectionVgwTelemetryGetArgs>());
            set => _vgwTelemetries = value;
        }

        /// <summary>
        /// The ID of the Virtual Private Gateway.
        /// </summary>
        [Input("vpnGatewayId")]
        public Input<string>? VpnGatewayId { get; set; }

        public VpnConnectionState()
        {
        }
    }
}
