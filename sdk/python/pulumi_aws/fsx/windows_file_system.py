# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class WindowsFileSystem(pulumi.CustomResource):
    active_directory_id: pulumi.Output[str]
    """
    The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with `self_managed_active_directory`.
    """
    arn: pulumi.Output[str]
    """
    Amazon Resource Name of the file system.
    """
    automatic_backup_retention_days: pulumi.Output[float]
    """
    The number of days to retain automatic backups. Minimum of `0` and maximum of `35`. Defaults to `7`. Set to `0` to disable.
    """
    copy_tags_to_backups: pulumi.Output[bool]
    """
    A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to `false`.
    """
    daily_automatic_backup_start_time: pulumi.Output[str]
    """
    The preferred time (in `HH:MM` format) to take daily automatic backups, in the UTC time zone.
    """
    dns_name: pulumi.Output[str]
    """
    DNS name for the file system, e.g. `fs-12345678.corp.example.com` (domain name matching the Active Directory domain name)
    """
    kms_key_id: pulumi.Output[str]
    """
    ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.
    """
    network_interface_ids: pulumi.Output[list]
    """
    Set of Elastic Network Interface identifiers from which the file system is accessible.
    """
    owner_id: pulumi.Output[str]
    """
    AWS account identifier that created the file system.
    """
    security_group_ids: pulumi.Output[list]
    """
    A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
    """
    self_managed_active_directory: pulumi.Output[dict]
    """
    Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with `active_directory_id`. Detailed below.

      * `dns_ips` (`list`) - A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in [RFC 1918](https://tools.ietf.org/html/rfc1918).
      * `domain_name` (`str`) - The fully qualified domain name of the self-managed AD directory. For example, `corp.example.com`.
      * `fileSystemAdministratorsGroup` (`str`) - The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to `Domain Admins`.
      * `organizationalUnitDistinguishedName` (`str`) - The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, `OU=FSx,DC=yourdomain,DC=corp,DC=com`. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see [RFC 2253](https://tools.ietf.org/html/rfc2253).
      * `password` (`str`) - The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
      * `username` (`str`) - The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
    """
    skip_final_backup: pulumi.Output[bool]
    """
    When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to `false`.
    """
    storage_capacity: pulumi.Output[float]
    """
    Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536.
    """
    subnet_ids: pulumi.Output[str]
    """
    A list of IDs for the subnets that the file system will be accessible from. File systems support only one subnet. The file server is also launched in that subnet's Availability Zone.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the file system.
    """
    throughput_capacity: pulumi.Output[float]
    """
    Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of `8` and maximum of `2048`.
    """
    vpc_id: pulumi.Output[str]
    """
    Identifier of the Virtual Private Cloud for the file system.
    """
    weekly_maintenance_start_time: pulumi.Output[str]
    """
    The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.
    """
    def __init__(__self__, resource_name, opts=None, active_directory_id=None, automatic_backup_retention_days=None, copy_tags_to_backups=None, daily_automatic_backup_start_time=None, kms_key_id=None, security_group_ids=None, self_managed_active_directory=None, skip_final_backup=None, storage_capacity=None, subnet_ids=None, tags=None, throughput_capacity=None, weekly_maintenance_start_time=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a FSx Windows File System. See the [FSx Windows Guide](https://docs.aws.amazon.com/fsx/latest/WindowsGuide/what-is.html) for more information.

        > **NOTE:** Either the `active_directory_id` argument or `self_managed_active_directory` configuration block must be specified.

        ## Example Usage

        ### Using AWS Directory Service

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.fsx.WindowsFileSystem("example",
            active_directory_id=aws_directory_service_directory["example"]["id"],
            kms_key_id=aws_kms_key["example"]["arn"],
            storage_capacity=300,
            subnet_ids=aws_subnet["example"]["id"],
            throughput_capacity=1024)
        ```

        ### Using a Self-Managed Microsoft Active Directory

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.fsx.WindowsFileSystem("example",
            kms_key_id=aws_kms_key["example"]["arn"],
            self_managed_active_directory={
                "dns_ips": [
                    "10.0.0.111",
                    "10.0.0.222",
                ],
                "domain_name": "corp.example.com",
                "password": "avoid-plaintext-passwords",
                "username": "Admin",
            },
            storage_capacity=300,
            subnet_ids=aws_subnet["example"]["id"],
            throughput_capacity=1024)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] active_directory_id: The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with `self_managed_active_directory`.
        :param pulumi.Input[float] automatic_backup_retention_days: The number of days to retain automatic backups. Minimum of `0` and maximum of `35`. Defaults to `7`. Set to `0` to disable.
        :param pulumi.Input[bool] copy_tags_to_backups: A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to `false`.
        :param pulumi.Input[str] daily_automatic_backup_start_time: The preferred time (in `HH:MM` format) to take daily automatic backups, in the UTC time zone.
        :param pulumi.Input[str] kms_key_id: ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.
        :param pulumi.Input[list] security_group_ids: A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
        :param pulumi.Input[dict] self_managed_active_directory: Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with `active_directory_id`. Detailed below.
        :param pulumi.Input[bool] skip_final_backup: When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to `false`.
        :param pulumi.Input[float] storage_capacity: Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536.
        :param pulumi.Input[str] subnet_ids: A list of IDs for the subnets that the file system will be accessible from. File systems support only one subnet. The file server is also launched in that subnet's Availability Zone.
        :param pulumi.Input[dict] tags: A map of tags to assign to the file system.
        :param pulumi.Input[float] throughput_capacity: Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of `8` and maximum of `2048`.
        :param pulumi.Input[str] weekly_maintenance_start_time: The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.

        The **self_managed_active_directory** object supports the following:

          * `dns_ips` (`pulumi.Input[list]`) - A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in [RFC 1918](https://tools.ietf.org/html/rfc1918).
          * `domain_name` (`pulumi.Input[str]`) - The fully qualified domain name of the self-managed AD directory. For example, `corp.example.com`.
          * `fileSystemAdministratorsGroup` (`pulumi.Input[str]`) - The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to `Domain Admins`.
          * `organizationalUnitDistinguishedName` (`pulumi.Input[str]`) - The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, `OU=FSx,DC=yourdomain,DC=corp,DC=com`. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see [RFC 2253](https://tools.ietf.org/html/rfc2253).
          * `password` (`pulumi.Input[str]`) - The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
          * `username` (`pulumi.Input[str]`) - The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
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

            __props__['active_directory_id'] = active_directory_id
            __props__['automatic_backup_retention_days'] = automatic_backup_retention_days
            __props__['copy_tags_to_backups'] = copy_tags_to_backups
            __props__['daily_automatic_backup_start_time'] = daily_automatic_backup_start_time
            __props__['kms_key_id'] = kms_key_id
            __props__['security_group_ids'] = security_group_ids
            __props__['self_managed_active_directory'] = self_managed_active_directory
            __props__['skip_final_backup'] = skip_final_backup
            if storage_capacity is None:
                raise TypeError("Missing required property 'storage_capacity'")
            __props__['storage_capacity'] = storage_capacity
            if subnet_ids is None:
                raise TypeError("Missing required property 'subnet_ids'")
            __props__['subnet_ids'] = subnet_ids
            __props__['tags'] = tags
            if throughput_capacity is None:
                raise TypeError("Missing required property 'throughput_capacity'")
            __props__['throughput_capacity'] = throughput_capacity
            __props__['weekly_maintenance_start_time'] = weekly_maintenance_start_time
            __props__['arn'] = None
            __props__['dns_name'] = None
            __props__['network_interface_ids'] = None
            __props__['owner_id'] = None
            __props__['vpc_id'] = None
        super(WindowsFileSystem, __self__).__init__(
            'aws:fsx/windowsFileSystem:WindowsFileSystem',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, active_directory_id=None, arn=None, automatic_backup_retention_days=None, copy_tags_to_backups=None, daily_automatic_backup_start_time=None, dns_name=None, kms_key_id=None, network_interface_ids=None, owner_id=None, security_group_ids=None, self_managed_active_directory=None, skip_final_backup=None, storage_capacity=None, subnet_ids=None, tags=None, throughput_capacity=None, vpc_id=None, weekly_maintenance_start_time=None):
        """
        Get an existing WindowsFileSystem resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] active_directory_id: The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with `self_managed_active_directory`.
        :param pulumi.Input[str] arn: Amazon Resource Name of the file system.
        :param pulumi.Input[float] automatic_backup_retention_days: The number of days to retain automatic backups. Minimum of `0` and maximum of `35`. Defaults to `7`. Set to `0` to disable.
        :param pulumi.Input[bool] copy_tags_to_backups: A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to `false`.
        :param pulumi.Input[str] daily_automatic_backup_start_time: The preferred time (in `HH:MM` format) to take daily automatic backups, in the UTC time zone.
        :param pulumi.Input[str] dns_name: DNS name for the file system, e.g. `fs-12345678.corp.example.com` (domain name matching the Active Directory domain name)
        :param pulumi.Input[str] kms_key_id: ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.
        :param pulumi.Input[list] network_interface_ids: Set of Elastic Network Interface identifiers from which the file system is accessible.
        :param pulumi.Input[str] owner_id: AWS account identifier that created the file system.
        :param pulumi.Input[list] security_group_ids: A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
        :param pulumi.Input[dict] self_managed_active_directory: Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with `active_directory_id`. Detailed below.
        :param pulumi.Input[bool] skip_final_backup: When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to `false`.
        :param pulumi.Input[float] storage_capacity: Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536.
        :param pulumi.Input[str] subnet_ids: A list of IDs for the subnets that the file system will be accessible from. File systems support only one subnet. The file server is also launched in that subnet's Availability Zone.
        :param pulumi.Input[dict] tags: A map of tags to assign to the file system.
        :param pulumi.Input[float] throughput_capacity: Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of `8` and maximum of `2048`.
        :param pulumi.Input[str] vpc_id: Identifier of the Virtual Private Cloud for the file system.
        :param pulumi.Input[str] weekly_maintenance_start_time: The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.

        The **self_managed_active_directory** object supports the following:

          * `dns_ips` (`pulumi.Input[list]`) - A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in [RFC 1918](https://tools.ietf.org/html/rfc1918).
          * `domain_name` (`pulumi.Input[str]`) - The fully qualified domain name of the self-managed AD directory. For example, `corp.example.com`.
          * `fileSystemAdministratorsGroup` (`pulumi.Input[str]`) - The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to `Domain Admins`.
          * `organizationalUnitDistinguishedName` (`pulumi.Input[str]`) - The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, `OU=FSx,DC=yourdomain,DC=corp,DC=com`. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see [RFC 2253](https://tools.ietf.org/html/rfc2253).
          * `password` (`pulumi.Input[str]`) - The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
          * `username` (`pulumi.Input[str]`) - The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["active_directory_id"] = active_directory_id
        __props__["arn"] = arn
        __props__["automatic_backup_retention_days"] = automatic_backup_retention_days
        __props__["copy_tags_to_backups"] = copy_tags_to_backups
        __props__["daily_automatic_backup_start_time"] = daily_automatic_backup_start_time
        __props__["dns_name"] = dns_name
        __props__["kms_key_id"] = kms_key_id
        __props__["network_interface_ids"] = network_interface_ids
        __props__["owner_id"] = owner_id
        __props__["security_group_ids"] = security_group_ids
        __props__["self_managed_active_directory"] = self_managed_active_directory
        __props__["skip_final_backup"] = skip_final_backup
        __props__["storage_capacity"] = storage_capacity
        __props__["subnet_ids"] = subnet_ids
        __props__["tags"] = tags
        __props__["throughput_capacity"] = throughput_capacity
        __props__["vpc_id"] = vpc_id
        __props__["weekly_maintenance_start_time"] = weekly_maintenance_start_time
        return WindowsFileSystem(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

