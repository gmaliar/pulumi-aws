// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class DefaultRouteTableRouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CIDR block of the route.
        /// </summary>
        [Input("cidrBlock")]
        public Input<string>? CidrBlock { get; set; }

        /// <summary>
        /// Identifier of a VPC Egress Only Internet Gateway.
        /// </summary>
        [Input("egressOnlyGatewayId")]
        public Input<string>? EgressOnlyGatewayId { get; set; }

        /// <summary>
        /// Identifier of a VPC internet gateway or a virtual private gateway.
        /// </summary>
        [Input("gatewayId")]
        public Input<string>? GatewayId { get; set; }

        /// <summary>
        /// Identifier of an EC2 instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// The Ipv6 CIDR block of the route
        /// </summary>
        [Input("ipv6CidrBlock")]
        public Input<string>? Ipv6CidrBlock { get; set; }

        /// <summary>
        /// Identifier of a VPC NAT gateway.
        /// </summary>
        [Input("natGatewayId")]
        public Input<string>? NatGatewayId { get; set; }

        /// <summary>
        /// Identifier of an EC2 network interface.
        /// </summary>
        [Input("networkInterfaceId")]
        public Input<string>? NetworkInterfaceId { get; set; }

        /// <summary>
        /// Identifier of an EC2 Transit Gateway.
        /// </summary>
        [Input("transitGatewayId")]
        public Input<string>? TransitGatewayId { get; set; }

        /// <summary>
        /// Identifier of a VPC Endpoint. This route must be removed prior to VPC Endpoint deletion.
        /// </summary>
        [Input("vpcEndpointId")]
        public Input<string>? VpcEndpointId { get; set; }

        /// <summary>
        /// Identifier of a VPC peering connection.
        /// </summary>
        [Input("vpcPeeringConnectionId")]
        public Input<string>? VpcPeeringConnectionId { get; set; }

        public DefaultRouteTableRouteArgs()
        {
        }
    }
}
