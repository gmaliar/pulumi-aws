# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LaunchTemplate(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    Amazon Resource Name (ARN) of the launch template.
    """
    block_device_mappings: pulumi.Output[list]
    """
    Specify volumes to attach to the instance besides the volumes specified by the AMI.
    See Block Devices below for details.
    
      * `device_name` (`str`) - The name of the device to mount.
      * `ebs` (`dict`) - Configure EBS volume properties.
    
        * `deleteOnTermination` (`str`)
        * `encrypted` (`str`)
        * `iops` (`float`)
        * `kms_key_id` (`str`)
        * `snapshot_id` (`str`)
        * `volume_size` (`float`)
        * `volumeType` (`str`)
    
      * `noDevice` (`str`) - Suppresses the specified device included in the AMI's block device mapping.
      * `virtualName` (`str`) - The [Instance Store Device
        Name](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#InstanceStoreDeviceNames)
        (e.g. `"ephemeral0"`).
    """
    capacity_reservation_specification: pulumi.Output[dict]
    """
    Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.
    
      * `capacityReservationPreference` (`str`)
      * `capacityReservationTarget` (`dict`)
    
        * `capacityReservationId` (`str`)
    """
    credit_specification: pulumi.Output[dict]
    """
    Customize the credit specification of the instance. See Credit
    Specification below for more details.
    
      * `cpuCredits` (`str`)
    """
    default_version: pulumi.Output[float]
    """
    The default version of the launch template.
    """
    description: pulumi.Output[str]
    """
    Description of the launch template.
    """
    disable_api_termination: pulumi.Output[bool]
    """
    If `true`, enables [EC2 Instance
    Termination Protection](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html#Using_ChangingDisableAPITermination)
    """
    ebs_optimized: pulumi.Output[str]
    """
    If `true`, the launched EC2 instance will be EBS-optimized.
    """
    elastic_gpu_specifications: pulumi.Output[list]
    """
    The elastic GPU to attach to the instance. See Elastic GPU
    below for more details.
    
      * `type` (`str`) - Accelerator type.
    """
    elastic_inference_accelerator: pulumi.Output[dict]
    """
    Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.
    
      * `type` (`str`) - Accelerator type.
    """
    iam_instance_profile: pulumi.Output[dict]
    """
    The IAM Instance Profile to launch the instance with. See Instance Profile
    below for more details.
    
      * `arn` (`str`) - Amazon Resource Name (ARN) of the launch template.
      * `name` (`str`) - The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
    """
    image_id: pulumi.Output[str]
    """
    The AMI from which to launch the instance.
    """
    instance_initiated_shutdown_behavior: pulumi.Output[str]
    """
    Shutdown behavior for the instance. Can be `stop` or `terminate`.
    (Default: `stop`).
    """
    instance_market_options: pulumi.Output[dict]
    """
    The market (purchasing) option for the instance. See Market Options
    below for details.
    
      * `marketType` (`str`)
      * `spot_options` (`dict`)
    
        * `block_duration_minutes` (`float`)
        * `instanceInterruptionBehavior` (`str`)
        * `maxPrice` (`str`)
        * `spotInstanceType` (`str`)
        * `valid_until` (`str`)
    """
    instance_type: pulumi.Output[str]
    """
    The type of the instance.
    """
    kernel_id: pulumi.Output[str]
    """
    The kernel ID.
    """
    key_name: pulumi.Output[str]
    """
    The key name to use for the instance.
    """
    latest_version: pulumi.Output[float]
    """
    The latest version of the launch template.
    """
    license_specifications: pulumi.Output[list]
    """
    A list of license specifications to associate with. See License Specification below for more details.
    
      * `licenseConfigurationArn` (`str`)
    """
    monitoring: pulumi.Output[dict]
    """
    The monitoring option for the instance. See Monitoring below for more details.
    
      * `enabled` (`bool`)
    """
    name: pulumi.Output[str]
    """
    The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
    """
    name_prefix: pulumi.Output[str]
    """
    Creates a unique name beginning with the specified prefix. Conflicts with `name`.
    """
    network_interfaces: pulumi.Output[list]
    """
    Customize network interfaces to be attached at instance boot time. See Network
    Interfaces below for more details.
    
      * `associate_public_ip_address` (`str`)
      * `deleteOnTermination` (`bool`)
      * `description` (`str`) - Description of the launch template.
      * `device_index` (`float`)
      * `ipv4AddressCount` (`float`)
      * `ipv4Addresses` (`list`)
      * `ipv6_address_count` (`float`)
      * `ipv6_addresses` (`list`)
      * `network_interface_id` (`str`)
      * `private_ip_address` (`str`)
      * `security_groups` (`list`)
      * `subnet_id` (`str`)
    """
    placement: pulumi.Output[dict]
    """
    The placement of the instance. See Placement below for more details.
    
      * `affinity` (`str`)
      * `availability_zone` (`str`)
      * `groupName` (`str`)
      * `host_id` (`str`)
      * `spreadDomain` (`str`)
      * `tenancy` (`str`)
    """
    ram_disk_id: pulumi.Output[str]
    """
    The ID of the RAM disk.
    """
    security_group_names: pulumi.Output[list]
    """
    A list of security group names to associate with. If you are creating Instances in a VPC, use
    `vpc_security_group_ids` instead.
    """
    tag_specifications: pulumi.Output[list]
    """
    The tags to apply to the resources during launch. See Tag Specifications below for more details.
    
      * `resourceType` (`str`)
      * `tags` (`dict`) - A mapping of tags to assign to the launch template.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the launch template.
    """
    user_data: pulumi.Output[str]
    """
    The Base64-encoded user data to provide when launching the instance.
    """
    vpc_security_group_ids: pulumi.Output[list]
    """
    A list of security group IDs to associate with.
    """
    def __init__(__self__, resource_name, opts=None, block_device_mappings=None, capacity_reservation_specification=None, credit_specification=None, description=None, disable_api_termination=None, ebs_optimized=None, elastic_gpu_specifications=None, elastic_inference_accelerator=None, iam_instance_profile=None, image_id=None, instance_initiated_shutdown_behavior=None, instance_market_options=None, instance_type=None, kernel_id=None, key_name=None, license_specifications=None, monitoring=None, name=None, name_prefix=None, network_interfaces=None, placement=None, ram_disk_id=None, security_group_names=None, tag_specifications=None, tags=None, user_data=None, vpc_security_group_ids=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an EC2 launch template resource. Can be used to create instances or auto scaling groups.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] block_device_mappings: Specify volumes to attach to the instance besides the volumes specified by the AMI.
               See Block Devices below for details.
        :param pulumi.Input[dict] capacity_reservation_specification: Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.
        :param pulumi.Input[dict] credit_specification: Customize the credit specification of the instance. See Credit
               Specification below for more details.
        :param pulumi.Input[str] description: Description of the launch template.
        :param pulumi.Input[bool] disable_api_termination: If `true`, enables [EC2 Instance
               Termination Protection](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html#Using_ChangingDisableAPITermination)
        :param pulumi.Input[str] ebs_optimized: If `true`, the launched EC2 instance will be EBS-optimized.
        :param pulumi.Input[list] elastic_gpu_specifications: The elastic GPU to attach to the instance. See Elastic GPU
               below for more details.
        :param pulumi.Input[dict] elastic_inference_accelerator: Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.
        :param pulumi.Input[dict] iam_instance_profile: The IAM Instance Profile to launch the instance with. See Instance Profile
               below for more details.
        :param pulumi.Input[str] image_id: The AMI from which to launch the instance.
        :param pulumi.Input[str] instance_initiated_shutdown_behavior: Shutdown behavior for the instance. Can be `stop` or `terminate`.
               (Default: `stop`).
        :param pulumi.Input[dict] instance_market_options: The market (purchasing) option for the instance. See Market Options
               below for details.
        :param pulumi.Input[str] instance_type: The type of the instance.
        :param pulumi.Input[str] kernel_id: The kernel ID.
        :param pulumi.Input[str] key_name: The key name to use for the instance.
        :param pulumi.Input[list] license_specifications: A list of license specifications to associate with. See License Specification below for more details.
        :param pulumi.Input[dict] monitoring: The monitoring option for the instance. See Monitoring below for more details.
        :param pulumi.Input[str] name: The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified prefix. Conflicts with `name`.
        :param pulumi.Input[list] network_interfaces: Customize network interfaces to be attached at instance boot time. See Network
               Interfaces below for more details.
        :param pulumi.Input[dict] placement: The placement of the instance. See Placement below for more details.
        :param pulumi.Input[str] ram_disk_id: The ID of the RAM disk.
        :param pulumi.Input[list] security_group_names: A list of security group names to associate with. If you are creating Instances in a VPC, use
               `vpc_security_group_ids` instead.
        :param pulumi.Input[list] tag_specifications: The tags to apply to the resources during launch. See Tag Specifications below for more details.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the launch template.
        :param pulumi.Input[str] user_data: The Base64-encoded user data to provide when launching the instance.
        :param pulumi.Input[list] vpc_security_group_ids: A list of security group IDs to associate with.
        
        The **block_device_mappings** object supports the following:
        
          * `device_name` (`pulumi.Input[str]`) - The name of the device to mount.
          * `ebs` (`pulumi.Input[dict]`) - Configure EBS volume properties.
        
            * `deleteOnTermination` (`pulumi.Input[str]`)
            * `encrypted` (`pulumi.Input[str]`)
            * `iops` (`pulumi.Input[float]`)
            * `kms_key_id` (`pulumi.Input[str]`)
            * `snapshot_id` (`pulumi.Input[str]`)
            * `volume_size` (`pulumi.Input[float]`)
            * `volumeType` (`pulumi.Input[str]`)
        
          * `noDevice` (`pulumi.Input[str]`) - Suppresses the specified device included in the AMI's block device mapping.
          * `virtualName` (`pulumi.Input[str]`) - The [Instance Store Device
            Name](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#InstanceStoreDeviceNames)
            (e.g. `"ephemeral0"`).
        
        The **capacity_reservation_specification** object supports the following:
        
          * `capacityReservationPreference` (`pulumi.Input[str]`)
          * `capacityReservationTarget` (`pulumi.Input[dict]`)
        
            * `capacityReservationId` (`pulumi.Input[str]`)
        
        The **credit_specification** object supports the following:
        
          * `cpuCredits` (`pulumi.Input[str]`)
        
        The **elastic_gpu_specifications** object supports the following:
        
          * `type` (`pulumi.Input[str]`) - Accelerator type.
        
        The **elastic_inference_accelerator** object supports the following:
        
          * `type` (`pulumi.Input[str]`) - Accelerator type.
        
        The **iam_instance_profile** object supports the following:
        
          * `arn` (`pulumi.Input[str]`) - Amazon Resource Name (ARN) of the launch template.
          * `name` (`pulumi.Input[str]`) - The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
        
        The **instance_market_options** object supports the following:
        
          * `marketType` (`pulumi.Input[str]`)
          * `spot_options` (`pulumi.Input[dict]`)
        
            * `block_duration_minutes` (`pulumi.Input[float]`)
            * `instanceInterruptionBehavior` (`pulumi.Input[str]`)
            * `maxPrice` (`pulumi.Input[str]`)
            * `spotInstanceType` (`pulumi.Input[str]`)
            * `valid_until` (`pulumi.Input[str]`)
        
        The **license_specifications** object supports the following:
        
          * `licenseConfigurationArn` (`pulumi.Input[str]`)
        
        The **monitoring** object supports the following:
        
          * `enabled` (`pulumi.Input[bool]`)
        
        The **network_interfaces** object supports the following:
        
          * `associate_public_ip_address` (`pulumi.Input[str]`)
          * `deleteOnTermination` (`pulumi.Input[bool]`)
          * `description` (`pulumi.Input[str]`) - Description of the launch template.
          * `device_index` (`pulumi.Input[float]`)
          * `ipv4AddressCount` (`pulumi.Input[float]`)
          * `ipv4Addresses` (`pulumi.Input[list]`)
          * `ipv6_address_count` (`pulumi.Input[float]`)
          * `ipv6_addresses` (`pulumi.Input[list]`)
          * `network_interface_id` (`pulumi.Input[str]`)
          * `private_ip_address` (`pulumi.Input[str]`)
          * `security_groups` (`pulumi.Input[list]`)
          * `subnet_id` (`pulumi.Input[str]`)
        
        The **placement** object supports the following:
        
          * `affinity` (`pulumi.Input[str]`)
          * `availability_zone` (`pulumi.Input[str]`)
          * `groupName` (`pulumi.Input[str]`)
          * `host_id` (`pulumi.Input[str]`)
          * `spreadDomain` (`pulumi.Input[str]`)
          * `tenancy` (`pulumi.Input[str]`)
        
        The **tag_specifications** object supports the following:
        
          * `resourceType` (`pulumi.Input[str]`)
          * `tags` (`pulumi.Input[dict]`) - A mapping of tags to assign to the launch template.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/launch_template.html.markdown.
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

            __props__['block_device_mappings'] = block_device_mappings
            __props__['capacity_reservation_specification'] = capacity_reservation_specification
            __props__['credit_specification'] = credit_specification
            __props__['description'] = description
            __props__['disable_api_termination'] = disable_api_termination
            __props__['ebs_optimized'] = ebs_optimized
            __props__['elastic_gpu_specifications'] = elastic_gpu_specifications
            __props__['elastic_inference_accelerator'] = elastic_inference_accelerator
            __props__['iam_instance_profile'] = iam_instance_profile
            __props__['image_id'] = image_id
            __props__['instance_initiated_shutdown_behavior'] = instance_initiated_shutdown_behavior
            __props__['instance_market_options'] = instance_market_options
            __props__['instance_type'] = instance_type
            __props__['kernel_id'] = kernel_id
            __props__['key_name'] = key_name
            __props__['license_specifications'] = license_specifications
            __props__['monitoring'] = monitoring
            __props__['name'] = name
            __props__['name_prefix'] = name_prefix
            __props__['network_interfaces'] = network_interfaces
            __props__['placement'] = placement
            __props__['ram_disk_id'] = ram_disk_id
            __props__['security_group_names'] = security_group_names
            __props__['tag_specifications'] = tag_specifications
            __props__['tags'] = tags
            __props__['user_data'] = user_data
            __props__['vpc_security_group_ids'] = vpc_security_group_ids
            __props__['arn'] = None
            __props__['default_version'] = None
            __props__['latest_version'] = None
        super(LaunchTemplate, __self__).__init__(
            'aws:ec2/launchTemplate:LaunchTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, block_device_mappings=None, capacity_reservation_specification=None, credit_specification=None, default_version=None, description=None, disable_api_termination=None, ebs_optimized=None, elastic_gpu_specifications=None, elastic_inference_accelerator=None, iam_instance_profile=None, image_id=None, instance_initiated_shutdown_behavior=None, instance_market_options=None, instance_type=None, kernel_id=None, key_name=None, latest_version=None, license_specifications=None, monitoring=None, name=None, name_prefix=None, network_interfaces=None, placement=None, ram_disk_id=None, security_group_names=None, tag_specifications=None, tags=None, user_data=None, vpc_security_group_ids=None):
        """
        Get an existing LaunchTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: Amazon Resource Name (ARN) of the launch template.
        :param pulumi.Input[list] block_device_mappings: Specify volumes to attach to the instance besides the volumes specified by the AMI.
               See Block Devices below for details.
        :param pulumi.Input[dict] capacity_reservation_specification: Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.
        :param pulumi.Input[dict] credit_specification: Customize the credit specification of the instance. See Credit
               Specification below for more details.
        :param pulumi.Input[float] default_version: The default version of the launch template.
        :param pulumi.Input[str] description: Description of the launch template.
        :param pulumi.Input[bool] disable_api_termination: If `true`, enables [EC2 Instance
               Termination Protection](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html#Using_ChangingDisableAPITermination)
        :param pulumi.Input[str] ebs_optimized: If `true`, the launched EC2 instance will be EBS-optimized.
        :param pulumi.Input[list] elastic_gpu_specifications: The elastic GPU to attach to the instance. See Elastic GPU
               below for more details.
        :param pulumi.Input[dict] elastic_inference_accelerator: Configuration block containing an Elastic Inference Accelerator to attach to the instance. See Elastic Inference Accelerator below for more details.
        :param pulumi.Input[dict] iam_instance_profile: The IAM Instance Profile to launch the instance with. See Instance Profile
               below for more details.
        :param pulumi.Input[str] image_id: The AMI from which to launch the instance.
        :param pulumi.Input[str] instance_initiated_shutdown_behavior: Shutdown behavior for the instance. Can be `stop` or `terminate`.
               (Default: `stop`).
        :param pulumi.Input[dict] instance_market_options: The market (purchasing) option for the instance. See Market Options
               below for details.
        :param pulumi.Input[str] instance_type: The type of the instance.
        :param pulumi.Input[str] kernel_id: The kernel ID.
        :param pulumi.Input[str] key_name: The key name to use for the instance.
        :param pulumi.Input[float] latest_version: The latest version of the launch template.
        :param pulumi.Input[list] license_specifications: A list of license specifications to associate with. See License Specification below for more details.
        :param pulumi.Input[dict] monitoring: The monitoring option for the instance. See Monitoring below for more details.
        :param pulumi.Input[str] name: The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified prefix. Conflicts with `name`.
        :param pulumi.Input[list] network_interfaces: Customize network interfaces to be attached at instance boot time. See Network
               Interfaces below for more details.
        :param pulumi.Input[dict] placement: The placement of the instance. See Placement below for more details.
        :param pulumi.Input[str] ram_disk_id: The ID of the RAM disk.
        :param pulumi.Input[list] security_group_names: A list of security group names to associate with. If you are creating Instances in a VPC, use
               `vpc_security_group_ids` instead.
        :param pulumi.Input[list] tag_specifications: The tags to apply to the resources during launch. See Tag Specifications below for more details.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the launch template.
        :param pulumi.Input[str] user_data: The Base64-encoded user data to provide when launching the instance.
        :param pulumi.Input[list] vpc_security_group_ids: A list of security group IDs to associate with.
        
        The **block_device_mappings** object supports the following:
        
          * `device_name` (`pulumi.Input[str]`) - The name of the device to mount.
          * `ebs` (`pulumi.Input[dict]`) - Configure EBS volume properties.
        
            * `deleteOnTermination` (`pulumi.Input[str]`)
            * `encrypted` (`pulumi.Input[str]`)
            * `iops` (`pulumi.Input[float]`)
            * `kms_key_id` (`pulumi.Input[str]`)
            * `snapshot_id` (`pulumi.Input[str]`)
            * `volume_size` (`pulumi.Input[float]`)
            * `volumeType` (`pulumi.Input[str]`)
        
          * `noDevice` (`pulumi.Input[str]`) - Suppresses the specified device included in the AMI's block device mapping.
          * `virtualName` (`pulumi.Input[str]`) - The [Instance Store Device
            Name](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#InstanceStoreDeviceNames)
            (e.g. `"ephemeral0"`).
        
        The **capacity_reservation_specification** object supports the following:
        
          * `capacityReservationPreference` (`pulumi.Input[str]`)
          * `capacityReservationTarget` (`pulumi.Input[dict]`)
        
            * `capacityReservationId` (`pulumi.Input[str]`)
        
        The **credit_specification** object supports the following:
        
          * `cpuCredits` (`pulumi.Input[str]`)
        
        The **elastic_gpu_specifications** object supports the following:
        
          * `type` (`pulumi.Input[str]`) - Accelerator type.
        
        The **elastic_inference_accelerator** object supports the following:
        
          * `type` (`pulumi.Input[str]`) - Accelerator type.
        
        The **iam_instance_profile** object supports the following:
        
          * `arn` (`pulumi.Input[str]`) - Amazon Resource Name (ARN) of the launch template.
          * `name` (`pulumi.Input[str]`) - The name of the launch template. If you leave this blank, this provider will auto-generate a unique name.
        
        The **instance_market_options** object supports the following:
        
          * `marketType` (`pulumi.Input[str]`)
          * `spot_options` (`pulumi.Input[dict]`)
        
            * `block_duration_minutes` (`pulumi.Input[float]`)
            * `instanceInterruptionBehavior` (`pulumi.Input[str]`)
            * `maxPrice` (`pulumi.Input[str]`)
            * `spotInstanceType` (`pulumi.Input[str]`)
            * `valid_until` (`pulumi.Input[str]`)
        
        The **license_specifications** object supports the following:
        
          * `licenseConfigurationArn` (`pulumi.Input[str]`)
        
        The **monitoring** object supports the following:
        
          * `enabled` (`pulumi.Input[bool]`)
        
        The **network_interfaces** object supports the following:
        
          * `associate_public_ip_address` (`pulumi.Input[str]`)
          * `deleteOnTermination` (`pulumi.Input[bool]`)
          * `description` (`pulumi.Input[str]`) - Description of the launch template.
          * `device_index` (`pulumi.Input[float]`)
          * `ipv4AddressCount` (`pulumi.Input[float]`)
          * `ipv4Addresses` (`pulumi.Input[list]`)
          * `ipv6_address_count` (`pulumi.Input[float]`)
          * `ipv6_addresses` (`pulumi.Input[list]`)
          * `network_interface_id` (`pulumi.Input[str]`)
          * `private_ip_address` (`pulumi.Input[str]`)
          * `security_groups` (`pulumi.Input[list]`)
          * `subnet_id` (`pulumi.Input[str]`)
        
        The **placement** object supports the following:
        
          * `affinity` (`pulumi.Input[str]`)
          * `availability_zone` (`pulumi.Input[str]`)
          * `groupName` (`pulumi.Input[str]`)
          * `host_id` (`pulumi.Input[str]`)
          * `spreadDomain` (`pulumi.Input[str]`)
          * `tenancy` (`pulumi.Input[str]`)
        
        The **tag_specifications** object supports the following:
        
          * `resourceType` (`pulumi.Input[str]`)
          * `tags` (`pulumi.Input[dict]`) - A mapping of tags to assign to the launch template.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/launch_template.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["arn"] = arn
        __props__["block_device_mappings"] = block_device_mappings
        __props__["capacity_reservation_specification"] = capacity_reservation_specification
        __props__["credit_specification"] = credit_specification
        __props__["default_version"] = default_version
        __props__["description"] = description
        __props__["disable_api_termination"] = disable_api_termination
        __props__["ebs_optimized"] = ebs_optimized
        __props__["elastic_gpu_specifications"] = elastic_gpu_specifications
        __props__["elastic_inference_accelerator"] = elastic_inference_accelerator
        __props__["iam_instance_profile"] = iam_instance_profile
        __props__["image_id"] = image_id
        __props__["instance_initiated_shutdown_behavior"] = instance_initiated_shutdown_behavior
        __props__["instance_market_options"] = instance_market_options
        __props__["instance_type"] = instance_type
        __props__["kernel_id"] = kernel_id
        __props__["key_name"] = key_name
        __props__["latest_version"] = latest_version
        __props__["license_specifications"] = license_specifications
        __props__["monitoring"] = monitoring
        __props__["name"] = name
        __props__["name_prefix"] = name_prefix
        __props__["network_interfaces"] = network_interfaces
        __props__["placement"] = placement
        __props__["ram_disk_id"] = ram_disk_id
        __props__["security_group_names"] = security_group_names
        __props__["tag_specifications"] = tag_specifications
        __props__["tags"] = tags
        __props__["user_data"] = user_data
        __props__["vpc_security_group_ids"] = vpc_security_group_ids
        return LaunchTemplate(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

