# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Zone(pulumi.CustomResource):
    comment: pulumi.Output[str]
    """
    A comment for the hosted zone. Defaults to 'Managed by Pulumi'.
    """
    delegation_set_id: pulumi.Output[str]
    """
    The ID of the reusable delegation set whose NS records you want to assign to the hosted zone. Conflicts with `vpc` as delegation sets can only be used for public zones.
    """
    force_destroy: pulumi.Output[bool]
    """
    Whether to destroy all records (possibly managed outside of this provider) in the zone when destroying the zone.
    """
    name: pulumi.Output[str]
    """
    This is the name of the hosted zone.
    """
    name_servers: pulumi.Output[list]
    """
    A list of name servers in associated (or default) delegation set.
    Find more about delegation sets in [AWS docs](https://docs.aws.amazon.com/Route53/latest/APIReference/actions-on-reusable-delegation-sets.html).
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the zone.
    """
    vpcs: pulumi.Output[list]
    """
    Configuration block(s) specifying VPC(s) to associate with a private hosted zone. Conflicts with the `delegation_set_id` argument in this resource and any `route53.ZoneAssociation` resource specifying the same zone ID. Detailed below.

      * `vpc_id` (`str`) - ID of the VPC to associate.
      * `vpc_region` (`str`) - Region of the VPC to associate. Defaults to AWS provider region.
    """
    zone_id: pulumi.Output[str]
    """
    The Hosted Zone ID. This can be referenced by zone records.
    """
    def __init__(__self__, resource_name, opts=None, comment=None, delegation_set_id=None, force_destroy=None, name=None, tags=None, vpcs=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Route53 Hosted Zone.

        ## Example Usage
        ### Public Zone

        ```python
        import pulumi
        import pulumi_aws as aws

        primary = aws.route53.Zone("primary")
        ```
        ### Public Subdomain Zone

        For use in subdomains, note that you need to create a
        `route53.Record` of type `NS` as well as the subdomain
        zone.

        ```python
        import pulumi
        import pulumi_aws as aws

        main = aws.route53.Zone("main")
        dev = aws.route53.Zone("dev", tags={
            "Environment": "dev",
        })
        dev_ns = aws.route53.Record("dev-ns",
            name="dev.example.com",
            records=[
                dev.name_servers[0],
                dev.name_servers[1],
                dev.name_servers[2],
                dev.name_servers[3],
            ],
            ttl="30",
            type="NS",
            zone_id=main.zone_id)
        ```
        ### Private Zone

        > **NOTE:** This provider provides both exclusive VPC associations defined in-line in this resource via `vpc` configuration blocks and a separate ` Zone VPC Association resource. At this time, you cannot use in-line VPC associations in conjunction with any  `route53.ZoneAssociation`  resources with the same zone ID otherwise it will cause a perpetual difference in plan output. You can optionally use [ `ignoreChanges` ](https://www.pulumi.com/docs/intro/concepts/programming-model/#ignorechanges) to manage additional associations via the  `route53.ZoneAssociation` resource.

        > **NOTE:** Private zones require at least one VPC association at all times.

        ```python
        import pulumi
        import pulumi_aws as aws

        private = aws.route53.Zone("private", vpcs=[{
            "vpc_id": aws_vpc["example"]["id"],
        }])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] comment: A comment for the hosted zone. Defaults to 'Managed by Pulumi'.
        :param pulumi.Input[str] delegation_set_id: The ID of the reusable delegation set whose NS records you want to assign to the hosted zone. Conflicts with `vpc` as delegation sets can only be used for public zones.
        :param pulumi.Input[bool] force_destroy: Whether to destroy all records (possibly managed outside of this provider) in the zone when destroying the zone.
        :param pulumi.Input[str] name: This is the name of the hosted zone.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the zone.
        :param pulumi.Input[list] vpcs: Configuration block(s) specifying VPC(s) to associate with a private hosted zone. Conflicts with the `delegation_set_id` argument in this resource and any `route53.ZoneAssociation` resource specifying the same zone ID. Detailed below.

        The **vpcs** object supports the following:

          * `vpc_id` (`pulumi.Input[str]`) - ID of the VPC to associate.
          * `vpc_region` (`pulumi.Input[str]`) - Region of the VPC to associate. Defaults to AWS provider region.
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
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if comment is None:
                comment = 'Managed by Pulumi'
            __props__['comment'] = comment
            __props__['delegation_set_id'] = delegation_set_id
            __props__['force_destroy'] = force_destroy
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['vpcs'] = vpcs
            __props__['name_servers'] = None
            __props__['zone_id'] = None
        super(Zone, __self__).__init__(
            'aws:route53/zone:Zone',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, comment=None, delegation_set_id=None, force_destroy=None, name=None, name_servers=None, tags=None, vpcs=None, zone_id=None):
        """
        Get an existing Zone resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] comment: A comment for the hosted zone. Defaults to 'Managed by Pulumi'.
        :param pulumi.Input[str] delegation_set_id: The ID of the reusable delegation set whose NS records you want to assign to the hosted zone. Conflicts with `vpc` as delegation sets can only be used for public zones.
        :param pulumi.Input[bool] force_destroy: Whether to destroy all records (possibly managed outside of this provider) in the zone when destroying the zone.
        :param pulumi.Input[str] name: This is the name of the hosted zone.
        :param pulumi.Input[list] name_servers: A list of name servers in associated (or default) delegation set.
               Find more about delegation sets in [AWS docs](https://docs.aws.amazon.com/Route53/latest/APIReference/actions-on-reusable-delegation-sets.html).
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the zone.
        :param pulumi.Input[list] vpcs: Configuration block(s) specifying VPC(s) to associate with a private hosted zone. Conflicts with the `delegation_set_id` argument in this resource and any `route53.ZoneAssociation` resource specifying the same zone ID. Detailed below.
        :param pulumi.Input[str] zone_id: The Hosted Zone ID. This can be referenced by zone records.

        The **vpcs** object supports the following:

          * `vpc_id` (`pulumi.Input[str]`) - ID of the VPC to associate.
          * `vpc_region` (`pulumi.Input[str]`) - Region of the VPC to associate. Defaults to AWS provider region.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["comment"] = comment
        __props__["delegation_set_id"] = delegation_set_id
        __props__["force_destroy"] = force_destroy
        __props__["name"] = name
        __props__["name_servers"] = name_servers
        __props__["tags"] = tags
        __props__["vpcs"] = vpcs
        __props__["zone_id"] = zone_id
        return Zone(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
