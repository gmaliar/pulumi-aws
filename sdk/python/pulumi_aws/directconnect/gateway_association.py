# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['GatewayAssociation']


class GatewayAssociation(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allowed_prefixes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 associated_gateway_id: Optional[pulumi.Input[str]] = None,
                 associated_gateway_owner_account_id: Optional[pulumi.Input[str]] = None,
                 dx_gateway_id: Optional[pulumi.Input[str]] = None,
                 proposal_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Associates a Direct Connect Gateway with a VGW or transit gateway.

        To create a cross-account association, create an `directconnect.GatewayAssociationProposal` resource
        in the AWS account that owns the VGW or transit gateway and then accept the proposal in the AWS account that owns the Direct Connect Gateway
        by creating an `directconnect.GatewayAssociation` resource with the `proposal_id` and `associated_gateway_owner_account_id` attributes set.

        ## Example Usage
        ### VPN Gateway Association

        ```python
        import pulumi
        import pulumi_aws as aws

        example_gateway = aws.directconnect.Gateway("exampleGateway", amazon_side_asn="64512")
        example_vpc = aws.ec2.Vpc("exampleVpc", cidr_block="10.255.255.0/28")
        example_vpn_gateway = aws.ec2.VpnGateway("exampleVpnGateway", vpc_id=example_vpc.id)
        example_gateway_association = aws.directconnect.GatewayAssociation("exampleGatewayAssociation",
            dx_gateway_id=example_gateway.id,
            associated_gateway_id=example_vpn_gateway.id)
        ```
        ### Transit Gateway Association

        ```python
        import pulumi
        import pulumi_aws as aws

        example_gateway = aws.directconnect.Gateway("exampleGateway", amazon_side_asn="64512")
        example_transit_gateway = aws.ec2transitgateway.TransitGateway("exampleTransitGateway")
        example_gateway_association = aws.directconnect.GatewayAssociation("exampleGatewayAssociation",
            dx_gateway_id=example_gateway.id,
            associated_gateway_id=example_transit_gateway.id,
            allowed_prefixes=[
                "10.255.255.0/30",
                "10.255.255.8/30",
            ])
        ```
        ### Allowed Prefixes

        ```python
        import pulumi
        import pulumi_aws as aws

        example_gateway = aws.directconnect.Gateway("exampleGateway", amazon_side_asn="64512")
        example_vpc = aws.ec2.Vpc("exampleVpc", cidr_block="10.255.255.0/28")
        example_vpn_gateway = aws.ec2.VpnGateway("exampleVpnGateway", vpc_id=example_vpc.id)
        example_gateway_association = aws.directconnect.GatewayAssociation("exampleGatewayAssociation",
            dx_gateway_id=example_gateway.id,
            associated_gateway_id=example_vpn_gateway.id,
            allowed_prefixes=[
                "210.52.109.0/24",
                "175.45.176.0/22",
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] allowed_prefixes: VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
        :param pulumi.Input[str] associated_gateway_id: The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
               Used for single account Direct Connect gateway associations.
        :param pulumi.Input[str] associated_gateway_owner_account_id: The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
               Used for cross-account Direct Connect gateway associations.
        :param pulumi.Input[str] dx_gateway_id: The ID of the Direct Connect gateway.
        :param pulumi.Input[str] proposal_id: The ID of the Direct Connect gateway association proposal.
               Used for cross-account Direct Connect gateway associations.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['allowed_prefixes'] = allowed_prefixes
            __props__['associated_gateway_id'] = associated_gateway_id
            __props__['associated_gateway_owner_account_id'] = associated_gateway_owner_account_id
            if dx_gateway_id is None:
                raise TypeError("Missing required property 'dx_gateway_id'")
            __props__['dx_gateway_id'] = dx_gateway_id
            __props__['proposal_id'] = proposal_id
            __props__['associated_gateway_type'] = None
            __props__['dx_gateway_association_id'] = None
            __props__['dx_gateway_owner_account_id'] = None
        super(GatewayAssociation, __self__).__init__(
            'aws:directconnect/gatewayAssociation:GatewayAssociation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            allowed_prefixes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            associated_gateway_id: Optional[pulumi.Input[str]] = None,
            associated_gateway_owner_account_id: Optional[pulumi.Input[str]] = None,
            associated_gateway_type: Optional[pulumi.Input[str]] = None,
            dx_gateway_association_id: Optional[pulumi.Input[str]] = None,
            dx_gateway_id: Optional[pulumi.Input[str]] = None,
            dx_gateway_owner_account_id: Optional[pulumi.Input[str]] = None,
            proposal_id: Optional[pulumi.Input[str]] = None) -> 'GatewayAssociation':
        """
        Get an existing GatewayAssociation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] allowed_prefixes: VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
        :param pulumi.Input[str] associated_gateway_id: The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
               Used for single account Direct Connect gateway associations.
        :param pulumi.Input[str] associated_gateway_owner_account_id: The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
               Used for cross-account Direct Connect gateway associations.
        :param pulumi.Input[str] associated_gateway_type: The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
        :param pulumi.Input[str] dx_gateway_association_id: The ID of the Direct Connect gateway association.
        :param pulumi.Input[str] dx_gateway_id: The ID of the Direct Connect gateway.
        :param pulumi.Input[str] dx_gateway_owner_account_id: The ID of the AWS account that owns the Direct Connect gateway.
        :param pulumi.Input[str] proposal_id: The ID of the Direct Connect gateway association proposal.
               Used for cross-account Direct Connect gateway associations.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["allowed_prefixes"] = allowed_prefixes
        __props__["associated_gateway_id"] = associated_gateway_id
        __props__["associated_gateway_owner_account_id"] = associated_gateway_owner_account_id
        __props__["associated_gateway_type"] = associated_gateway_type
        __props__["dx_gateway_association_id"] = dx_gateway_association_id
        __props__["dx_gateway_id"] = dx_gateway_id
        __props__["dx_gateway_owner_account_id"] = dx_gateway_owner_account_id
        __props__["proposal_id"] = proposal_id
        return GatewayAssociation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allowedPrefixes")
    def allowed_prefixes(self) -> pulumi.Output[Sequence[str]]:
        """
        VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
        """
        return pulumi.get(self, "allowed_prefixes")

    @property
    @pulumi.getter(name="associatedGatewayId")
    def associated_gateway_id(self) -> pulumi.Output[str]:
        """
        The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
        Used for single account Direct Connect gateway associations.
        """
        return pulumi.get(self, "associated_gateway_id")

    @property
    @pulumi.getter(name="associatedGatewayOwnerAccountId")
    def associated_gateway_owner_account_id(self) -> pulumi.Output[str]:
        """
        The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
        Used for cross-account Direct Connect gateway associations.
        """
        return pulumi.get(self, "associated_gateway_owner_account_id")

    @property
    @pulumi.getter(name="associatedGatewayType")
    def associated_gateway_type(self) -> pulumi.Output[str]:
        """
        The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
        """
        return pulumi.get(self, "associated_gateway_type")

    @property
    @pulumi.getter(name="dxGatewayAssociationId")
    def dx_gateway_association_id(self) -> pulumi.Output[str]:
        """
        The ID of the Direct Connect gateway association.
        """
        return pulumi.get(self, "dx_gateway_association_id")

    @property
    @pulumi.getter(name="dxGatewayId")
    def dx_gateway_id(self) -> pulumi.Output[str]:
        """
        The ID of the Direct Connect gateway.
        """
        return pulumi.get(self, "dx_gateway_id")

    @property
    @pulumi.getter(name="dxGatewayOwnerAccountId")
    def dx_gateway_owner_account_id(self) -> pulumi.Output[str]:
        """
        The ID of the AWS account that owns the Direct Connect gateway.
        """
        return pulumi.get(self, "dx_gateway_owner_account_id")

    @property
    @pulumi.getter(name="proposalId")
    def proposal_id(self) -> pulumi.Output[Optional[str]]:
        """
        The ID of the Direct Connect gateway association proposal.
        Used for cross-account Direct Connect gateway associations.
        """
        return pulumi.get(self, "proposal_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

