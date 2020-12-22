# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['RepositoryPermissionsPolicy']


class RepositoryPermissionsPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 domain_owner: Optional[pulumi.Input[str]] = None,
                 policy_document: Optional[pulumi.Input[str]] = None,
                 policy_revision: Optional[pulumi.Input[str]] = None,
                 repository: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a CodeArtifact Repostory Permissions Policy Resource.

        ## Import

        CodeArtifact Repository Permissions Policies can be imported using the CodeArtifact Repository ARN, e.g.

        ```sh
         $ pulumi import aws:codeartifact/repositoryPermissionsPolicy:RepositoryPermissionsPolicy example arn:aws:codeartifact:us-west-2:012345678912:repository/tf-acc-test-6968272603913957763/tf-acc-test-6968272603913957763
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: The name of the domain on which to set the resource policy.
        :param pulumi.Input[str] domain_owner: The account number of the AWS account that owns the domain.
        :param pulumi.Input[str] policy_document: A JSON policy string to be set as the access control resource policy on the provided domain.
        :param pulumi.Input[str] policy_revision: The current revision of the resource policy to be set. This revision is used for optimistic locking, which prevents others from overwriting your changes to the domain's resource policy.
        :param pulumi.Input[str] repository: The name of the repository to set the resource policy on.
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
            __props__['domain_owner'] = domain_owner
            if policy_document is None and not opts.urn:
                raise TypeError("Missing required property 'policy_document'")
            __props__['policy_document'] = policy_document
            __props__['policy_revision'] = policy_revision
            if repository is None and not opts.urn:
                raise TypeError("Missing required property 'repository'")
            __props__['repository'] = repository
            __props__['resource_arn'] = None
        super(RepositoryPermissionsPolicy, __self__).__init__(
            'aws:codeartifact/repositoryPermissionsPolicy:RepositoryPermissionsPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            domain: Optional[pulumi.Input[str]] = None,
            domain_owner: Optional[pulumi.Input[str]] = None,
            policy_document: Optional[pulumi.Input[str]] = None,
            policy_revision: Optional[pulumi.Input[str]] = None,
            repository: Optional[pulumi.Input[str]] = None,
            resource_arn: Optional[pulumi.Input[str]] = None) -> 'RepositoryPermissionsPolicy':
        """
        Get an existing RepositoryPermissionsPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain: The name of the domain on which to set the resource policy.
        :param pulumi.Input[str] domain_owner: The account number of the AWS account that owns the domain.
        :param pulumi.Input[str] policy_document: A JSON policy string to be set as the access control resource policy on the provided domain.
        :param pulumi.Input[str] policy_revision: The current revision of the resource policy to be set. This revision is used for optimistic locking, which prevents others from overwriting your changes to the domain's resource policy.
        :param pulumi.Input[str] repository: The name of the repository to set the resource policy on.
        :param pulumi.Input[str] resource_arn: The ARN of the resource associated with the resource policy.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["domain"] = domain
        __props__["domain_owner"] = domain_owner
        __props__["policy_document"] = policy_document
        __props__["policy_revision"] = policy_revision
        __props__["repository"] = repository
        __props__["resource_arn"] = resource_arn
        return RepositoryPermissionsPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        The name of the domain on which to set the resource policy.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="domainOwner")
    def domain_owner(self) -> pulumi.Output[str]:
        """
        The account number of the AWS account that owns the domain.
        """
        return pulumi.get(self, "domain_owner")

    @property
    @pulumi.getter(name="policyDocument")
    def policy_document(self) -> pulumi.Output[str]:
        """
        A JSON policy string to be set as the access control resource policy on the provided domain.
        """
        return pulumi.get(self, "policy_document")

    @property
    @pulumi.getter(name="policyRevision")
    def policy_revision(self) -> pulumi.Output[str]:
        """
        The current revision of the resource policy to be set. This revision is used for optimistic locking, which prevents others from overwriting your changes to the domain's resource policy.
        """
        return pulumi.get(self, "policy_revision")

    @property
    @pulumi.getter
    def repository(self) -> pulumi.Output[str]:
        """
        The name of the repository to set the resource policy on.
        """
        return pulumi.get(self, "repository")

    @property
    @pulumi.getter(name="resourceArn")
    def resource_arn(self) -> pulumi.Output[str]:
        """
        The ARN of the resource associated with the resource policy.
        """
        return pulumi.get(self, "resource_arn")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
