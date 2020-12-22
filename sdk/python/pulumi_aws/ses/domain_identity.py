# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['DomainIdentity']


class DomainIdentity(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides an SES domain identity resource

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.ses.DomainIdentity("example", domain="example.com")
        example_amazonses_verification_record = aws.route53.Record("exampleAmazonsesVerificationRecord",
            zone_id="ABCDEFGHIJ123",
            name="_amazonses.example.com",
            type="TXT",
            ttl=600,
            records=[example.verification_token])
        ```

        ## Import

        SES domain identities can be imported using the domain name.

        ```sh
         $ pulumi import aws:ses/domainIdentity:DomainIdentity example example.com
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: The domain name to assign to SES
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

            if domain is None and not opts.urn:
                raise TypeError("Missing required property 'domain'")
            __props__['domain'] = domain
            __props__['arn'] = None
            __props__['verification_token'] = None
        super(DomainIdentity, __self__).__init__(
            'aws:ses/domainIdentity:DomainIdentity',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            domain: Optional[pulumi.Input[str]] = None,
            verification_token: Optional[pulumi.Input[str]] = None) -> 'DomainIdentity':
        """
        Get an existing DomainIdentity resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN of the domain identity.
        :param pulumi.Input[str] domain: The domain name to assign to SES
        :param pulumi.Input[str] verification_token: A code which when added to the domain as a TXT record
               will signal to SES that the owner of the domain has authorised SES to act on
               their behalf. The domain identity will be in state "verification pending"
               until this is done. See below for an example of how this might be achieved
               when the domain is hosted in Route 53 and managed by this provider.  Find out
               more about verifying domains in Amazon SES in the [AWS SES
               docs](http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-domains.html).
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["domain"] = domain
        __props__["verification_token"] = verification_token
        return DomainIdentity(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The ARN of the domain identity.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        The domain name to assign to SES
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="verificationToken")
    def verification_token(self) -> pulumi.Output[str]:
        """
        A code which when added to the domain as a TXT record
        will signal to SES that the owner of the domain has authorised SES to act on
        their behalf. The domain identity will be in state "verification pending"
        until this is done. See below for an example of how this might be achieved
        when the domain is hosted in Route 53 and managed by this provider.  Find out
        more about verifying domains in Amazon SES in the [AWS SES
        docs](http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-domains.html).
        """
        return pulumi.get(self, "verification_token")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

