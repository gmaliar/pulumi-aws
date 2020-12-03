# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['Group']


class Group(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 capacity_rebalance: Optional[pulumi.Input[bool]] = None,
                 default_cooldown: Optional[pulumi.Input[int]] = None,
                 desired_capacity: Optional[pulumi.Input[int]] = None,
                 enabled_metrics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 force_delete: Optional[pulumi.Input[bool]] = None,
                 health_check_grace_period: Optional[pulumi.Input[int]] = None,
                 health_check_type: Optional[pulumi.Input[str]] = None,
                 initial_lifecycle_hooks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupInitialLifecycleHookArgs']]]]] = None,
                 launch_configuration: Optional[pulumi.Input[str]] = None,
                 launch_template: Optional[pulumi.Input[pulumi.InputType['GroupLaunchTemplateArgs']]] = None,
                 load_balancers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 max_instance_lifetime: Optional[pulumi.Input[int]] = None,
                 max_size: Optional[pulumi.Input[int]] = None,
                 metrics_granularity: Optional[pulumi.Input[Union[str, 'MetricsGranularity']]] = None,
                 min_elb_capacity: Optional[pulumi.Input[int]] = None,
                 min_size: Optional[pulumi.Input[int]] = None,
                 mixed_instances_policy: Optional[pulumi.Input[pulumi.InputType['GroupMixedInstancesPolicyArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 name_prefix: Optional[pulumi.Input[str]] = None,
                 placement_group: Optional[pulumi.Input[str]] = None,
                 protect_from_scale_in: Optional[pulumi.Input[bool]] = None,
                 service_linked_role_arn: Optional[pulumi.Input[str]] = None,
                 suspended_processes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupTagArgs']]]]] = None,
                 tags_collection: Optional[pulumi.Input[Sequence[pulumi.Input[Mapping[str, pulumi.Input[str]]]]]] = None,
                 target_group_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 termination_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_zone_identifiers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 wait_for_capacity_timeout: Optional[pulumi.Input[str]] = None,
                 wait_for_elb_capacity: Optional[pulumi.Input[int]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        ## Import

        AutoScaling Groups can be imported using the `name`, e.g.

        ```sh
         $ pulumi import aws:autoscaling/group:Group web web-asg
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] availability_zones: A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        :param pulumi.Input[bool] capacity_rebalance: Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        :param pulumi.Input[int] default_cooldown: The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        :param pulumi.Input[int] desired_capacity: The number of Amazon EC2 instances that
               should be running in the group. (See also Waiting for
               Capacity below.)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] enabled_metrics: A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        :param pulumi.Input[bool] force_delete: Allows deleting the autoscaling group without waiting
               for all instances in the pool to terminate.  You can force an autoscaling group to delete
               even if it's in the process of scaling a resource. Normally, this provider
               drains all the instances before deleting the group.  This bypasses that
               behavior and potentially leaves resources dangling.
        :param pulumi.Input[int] health_check_grace_period: Time (in seconds) after instance comes into service before checking health.
        :param pulumi.Input[str] health_check_type: "EC2" or "ELB". Controls how health checking is done.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupInitialLifecycleHookArgs']]]] initial_lifecycle_hooks: One or more
               [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
               to attach to the autoscaling group **before** instances are launched. The
               syntax is exactly the same as the separate
               `autoscaling.LifecycleHook`
               resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
               a new autoscaling group. For all other use-cases, please use `autoscaling.LifecycleHook` resource.
        :param pulumi.Input[str] launch_configuration: The name of the launch configuration to use.
        :param pulumi.Input[pulumi.InputType['GroupLaunchTemplateArgs']] launch_template: Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] load_balancers: A list of elastic load balancer names to add to the autoscaling
               group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        :param pulumi.Input[int] max_instance_lifetime: The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        :param pulumi.Input[int] max_size: The maximum size of the auto scale group.
        :param pulumi.Input[Union[str, 'MetricsGranularity']] metrics_granularity: The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        :param pulumi.Input[int] min_elb_capacity: Setting this causes this provider to wait for
               this number of instances from this autoscaling group to show up healthy in the
               ELB only on creation. Updates will not wait on ELB instance number changes.
               (See also Waiting for Capacity below.)
        :param pulumi.Input[int] min_size: The minimum size of the auto scale group.
               (See also Waiting for Capacity below.)
        :param pulumi.Input[pulumi.InputType['GroupMixedInstancesPolicyArgs']] mixed_instances_policy: Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        :param pulumi.Input[str] name: The name of the auto scaling group. By default generated by this provider.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified
               prefix. Conflicts with `name`.
        :param pulumi.Input[str] placement_group: The name of the placement group into which you'll launch your instances, if any.
        :param pulumi.Input[bool] protect_from_scale_in: Allows setting instance protection. The
               autoscaling group will not select instances with this setting for termination
               during scale in events.
        :param pulumi.Input[str] service_linked_role_arn: The ARN of the service-linked role that the ASG will use to call other AWS services
        :param pulumi.Input[Sequence[pulumi.Input[str]]] suspended_processes: A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
               Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupTagArgs']]]] tags: Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        :param pulumi.Input[Sequence[pulumi.Input[Mapping[str, pulumi.Input[str]]]]] tags_collection: Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] target_group_arns: A set of `alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] termination_policies: A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_zone_identifiers: A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        :param pulumi.Input[str] wait_for_capacity_timeout: A maximum
               [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
               wait for ASG instances to be healthy before timing out.  (See also Waiting
               for Capacity below.) Setting this to "0" causes
               this provider to skip all Capacity Waiting behavior.
        :param pulumi.Input[int] wait_for_elb_capacity: Setting this will cause this provider to wait
               for exactly this number of healthy instances from this autoscaling group in
               all attached load balancers on both create and update operations. (Takes
               precedence over `min_elb_capacity` behavior.)
               (See also Waiting for Capacity below.)
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

            __props__['availability_zones'] = availability_zones
            __props__['capacity_rebalance'] = capacity_rebalance
            __props__['default_cooldown'] = default_cooldown
            __props__['desired_capacity'] = desired_capacity
            __props__['enabled_metrics'] = enabled_metrics
            __props__['force_delete'] = force_delete
            __props__['health_check_grace_period'] = health_check_grace_period
            __props__['health_check_type'] = health_check_type
            __props__['initial_lifecycle_hooks'] = initial_lifecycle_hooks
            __props__['launch_configuration'] = launch_configuration
            __props__['launch_template'] = launch_template
            __props__['load_balancers'] = load_balancers
            __props__['max_instance_lifetime'] = max_instance_lifetime
            if max_size is None and not opts.urn:
                raise TypeError("Missing required property 'max_size'")
            __props__['max_size'] = max_size
            __props__['metrics_granularity'] = metrics_granularity
            __props__['min_elb_capacity'] = min_elb_capacity
            if min_size is None and not opts.urn:
                raise TypeError("Missing required property 'min_size'")
            __props__['min_size'] = min_size
            __props__['mixed_instances_policy'] = mixed_instances_policy
            __props__['name'] = name
            __props__['name_prefix'] = name_prefix
            __props__['placement_group'] = placement_group
            __props__['protect_from_scale_in'] = protect_from_scale_in
            __props__['service_linked_role_arn'] = service_linked_role_arn
            __props__['suspended_processes'] = suspended_processes
            __props__['tags'] = tags
            __props__['tags_collection'] = tags_collection
            __props__['target_group_arns'] = target_group_arns
            __props__['termination_policies'] = termination_policies
            __props__['vpc_zone_identifiers'] = vpc_zone_identifiers
            __props__['wait_for_capacity_timeout'] = wait_for_capacity_timeout
            __props__['wait_for_elb_capacity'] = wait_for_elb_capacity
            __props__['arn'] = None
        super(Group, __self__).__init__(
            'aws:autoscaling/group:Group',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            capacity_rebalance: Optional[pulumi.Input[bool]] = None,
            default_cooldown: Optional[pulumi.Input[int]] = None,
            desired_capacity: Optional[pulumi.Input[int]] = None,
            enabled_metrics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            force_delete: Optional[pulumi.Input[bool]] = None,
            health_check_grace_period: Optional[pulumi.Input[int]] = None,
            health_check_type: Optional[pulumi.Input[str]] = None,
            initial_lifecycle_hooks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupInitialLifecycleHookArgs']]]]] = None,
            launch_configuration: Optional[pulumi.Input[str]] = None,
            launch_template: Optional[pulumi.Input[pulumi.InputType['GroupLaunchTemplateArgs']]] = None,
            load_balancers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            max_instance_lifetime: Optional[pulumi.Input[int]] = None,
            max_size: Optional[pulumi.Input[int]] = None,
            metrics_granularity: Optional[pulumi.Input[Union[str, 'MetricsGranularity']]] = None,
            min_elb_capacity: Optional[pulumi.Input[int]] = None,
            min_size: Optional[pulumi.Input[int]] = None,
            mixed_instances_policy: Optional[pulumi.Input[pulumi.InputType['GroupMixedInstancesPolicyArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            name_prefix: Optional[pulumi.Input[str]] = None,
            placement_group: Optional[pulumi.Input[str]] = None,
            protect_from_scale_in: Optional[pulumi.Input[bool]] = None,
            service_linked_role_arn: Optional[pulumi.Input[str]] = None,
            suspended_processes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupTagArgs']]]]] = None,
            tags_collection: Optional[pulumi.Input[Sequence[pulumi.Input[Mapping[str, pulumi.Input[str]]]]]] = None,
            target_group_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            termination_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            vpc_zone_identifiers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            wait_for_capacity_timeout: Optional[pulumi.Input[str]] = None,
            wait_for_elb_capacity: Optional[pulumi.Input[int]] = None) -> 'Group':
        """
        Get an existing Group resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN for this AutoScaling Group
        :param pulumi.Input[Sequence[pulumi.Input[str]]] availability_zones: A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        :param pulumi.Input[bool] capacity_rebalance: Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        :param pulumi.Input[int] default_cooldown: The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        :param pulumi.Input[int] desired_capacity: The number of Amazon EC2 instances that
               should be running in the group. (See also Waiting for
               Capacity below.)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] enabled_metrics: A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        :param pulumi.Input[bool] force_delete: Allows deleting the autoscaling group without waiting
               for all instances in the pool to terminate.  You can force an autoscaling group to delete
               even if it's in the process of scaling a resource. Normally, this provider
               drains all the instances before deleting the group.  This bypasses that
               behavior and potentially leaves resources dangling.
        :param pulumi.Input[int] health_check_grace_period: Time (in seconds) after instance comes into service before checking health.
        :param pulumi.Input[str] health_check_type: "EC2" or "ELB". Controls how health checking is done.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupInitialLifecycleHookArgs']]]] initial_lifecycle_hooks: One or more
               [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
               to attach to the autoscaling group **before** instances are launched. The
               syntax is exactly the same as the separate
               `autoscaling.LifecycleHook`
               resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
               a new autoscaling group. For all other use-cases, please use `autoscaling.LifecycleHook` resource.
        :param pulumi.Input[str] launch_configuration: The name of the launch configuration to use.
        :param pulumi.Input[pulumi.InputType['GroupLaunchTemplateArgs']] launch_template: Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] load_balancers: A list of elastic load balancer names to add to the autoscaling
               group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        :param pulumi.Input[int] max_instance_lifetime: The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        :param pulumi.Input[int] max_size: The maximum size of the auto scale group.
        :param pulumi.Input[Union[str, 'MetricsGranularity']] metrics_granularity: The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        :param pulumi.Input[int] min_elb_capacity: Setting this causes this provider to wait for
               this number of instances from this autoscaling group to show up healthy in the
               ELB only on creation. Updates will not wait on ELB instance number changes.
               (See also Waiting for Capacity below.)
        :param pulumi.Input[int] min_size: The minimum size of the auto scale group.
               (See also Waiting for Capacity below.)
        :param pulumi.Input[pulumi.InputType['GroupMixedInstancesPolicyArgs']] mixed_instances_policy: Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        :param pulumi.Input[str] name: The name of the auto scaling group. By default generated by this provider.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified
               prefix. Conflicts with `name`.
        :param pulumi.Input[str] placement_group: The name of the placement group into which you'll launch your instances, if any.
        :param pulumi.Input[bool] protect_from_scale_in: Allows setting instance protection. The
               autoscaling group will not select instances with this setting for termination
               during scale in events.
        :param pulumi.Input[str] service_linked_role_arn: The ARN of the service-linked role that the ASG will use to call other AWS services
        :param pulumi.Input[Sequence[pulumi.Input[str]]] suspended_processes: A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
               Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GroupTagArgs']]]] tags: Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        :param pulumi.Input[Sequence[pulumi.Input[Mapping[str, pulumi.Input[str]]]]] tags_collection: Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] target_group_arns: A set of `alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] termination_policies: A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_zone_identifiers: A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        :param pulumi.Input[str] wait_for_capacity_timeout: A maximum
               [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
               wait for ASG instances to be healthy before timing out.  (See also Waiting
               for Capacity below.) Setting this to "0" causes
               this provider to skip all Capacity Waiting behavior.
        :param pulumi.Input[int] wait_for_elb_capacity: Setting this will cause this provider to wait
               for exactly this number of healthy instances from this autoscaling group in
               all attached load balancers on both create and update operations. (Takes
               precedence over `min_elb_capacity` behavior.)
               (See also Waiting for Capacity below.)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["availability_zones"] = availability_zones
        __props__["capacity_rebalance"] = capacity_rebalance
        __props__["default_cooldown"] = default_cooldown
        __props__["desired_capacity"] = desired_capacity
        __props__["enabled_metrics"] = enabled_metrics
        __props__["force_delete"] = force_delete
        __props__["health_check_grace_period"] = health_check_grace_period
        __props__["health_check_type"] = health_check_type
        __props__["initial_lifecycle_hooks"] = initial_lifecycle_hooks
        __props__["launch_configuration"] = launch_configuration
        __props__["launch_template"] = launch_template
        __props__["load_balancers"] = load_balancers
        __props__["max_instance_lifetime"] = max_instance_lifetime
        __props__["max_size"] = max_size
        __props__["metrics_granularity"] = metrics_granularity
        __props__["min_elb_capacity"] = min_elb_capacity
        __props__["min_size"] = min_size
        __props__["mixed_instances_policy"] = mixed_instances_policy
        __props__["name"] = name
        __props__["name_prefix"] = name_prefix
        __props__["placement_group"] = placement_group
        __props__["protect_from_scale_in"] = protect_from_scale_in
        __props__["service_linked_role_arn"] = service_linked_role_arn
        __props__["suspended_processes"] = suspended_processes
        __props__["tags"] = tags
        __props__["tags_collection"] = tags_collection
        __props__["target_group_arns"] = target_group_arns
        __props__["termination_policies"] = termination_policies
        __props__["vpc_zone_identifiers"] = vpc_zone_identifiers
        __props__["wait_for_capacity_timeout"] = wait_for_capacity_timeout
        __props__["wait_for_elb_capacity"] = wait_for_elb_capacity
        return Group(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The ARN for this AutoScaling Group
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="availabilityZones")
    def availability_zones(self) -> pulumi.Output[Sequence[str]]:
        """
        A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        """
        return pulumi.get(self, "availability_zones")

    @property
    @pulumi.getter(name="capacityRebalance")
    def capacity_rebalance(self) -> pulumi.Output[Optional[bool]]:
        """
        Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        """
        return pulumi.get(self, "capacity_rebalance")

    @property
    @pulumi.getter(name="defaultCooldown")
    def default_cooldown(self) -> pulumi.Output[int]:
        """
        The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        """
        return pulumi.get(self, "default_cooldown")

    @property
    @pulumi.getter(name="desiredCapacity")
    def desired_capacity(self) -> pulumi.Output[int]:
        """
        The number of Amazon EC2 instances that
        should be running in the group. (See also Waiting for
        Capacity below.)
        """
        return pulumi.get(self, "desired_capacity")

    @property
    @pulumi.getter(name="enabledMetrics")
    def enabled_metrics(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        """
        return pulumi.get(self, "enabled_metrics")

    @property
    @pulumi.getter(name="forceDelete")
    def force_delete(self) -> pulumi.Output[Optional[bool]]:
        """
        Allows deleting the autoscaling group without waiting
        for all instances in the pool to terminate.  You can force an autoscaling group to delete
        even if it's in the process of scaling a resource. Normally, this provider
        drains all the instances before deleting the group.  This bypasses that
        behavior and potentially leaves resources dangling.
        """
        return pulumi.get(self, "force_delete")

    @property
    @pulumi.getter(name="healthCheckGracePeriod")
    def health_check_grace_period(self) -> pulumi.Output[Optional[int]]:
        """
        Time (in seconds) after instance comes into service before checking health.
        """
        return pulumi.get(self, "health_check_grace_period")

    @property
    @pulumi.getter(name="healthCheckType")
    def health_check_type(self) -> pulumi.Output[str]:
        """
        "EC2" or "ELB". Controls how health checking is done.
        """
        return pulumi.get(self, "health_check_type")

    @property
    @pulumi.getter(name="initialLifecycleHooks")
    def initial_lifecycle_hooks(self) -> pulumi.Output[Optional[Sequence['outputs.GroupInitialLifecycleHook']]]:
        """
        One or more
        [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
        to attach to the autoscaling group **before** instances are launched. The
        syntax is exactly the same as the separate
        `autoscaling.LifecycleHook`
        resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
        a new autoscaling group. For all other use-cases, please use `autoscaling.LifecycleHook` resource.
        """
        return pulumi.get(self, "initial_lifecycle_hooks")

    @property
    @pulumi.getter(name="launchConfiguration")
    def launch_configuration(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the launch configuration to use.
        """
        return pulumi.get(self, "launch_configuration")

    @property
    @pulumi.getter(name="launchTemplate")
    def launch_template(self) -> pulumi.Output[Optional['outputs.GroupLaunchTemplate']]:
        """
        Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        """
        return pulumi.get(self, "launch_template")

    @property
    @pulumi.getter(name="loadBalancers")
    def load_balancers(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of elastic load balancer names to add to the autoscaling
        group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        """
        return pulumi.get(self, "load_balancers")

    @property
    @pulumi.getter(name="maxInstanceLifetime")
    def max_instance_lifetime(self) -> pulumi.Output[Optional[int]]:
        """
        The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        """
        return pulumi.get(self, "max_instance_lifetime")

    @property
    @pulumi.getter(name="maxSize")
    def max_size(self) -> pulumi.Output[int]:
        """
        The maximum size of the auto scale group.
        """
        return pulumi.get(self, "max_size")

    @property
    @pulumi.getter(name="metricsGranularity")
    def metrics_granularity(self) -> pulumi.Output[Optional[str]]:
        """
        The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        """
        return pulumi.get(self, "metrics_granularity")

    @property
    @pulumi.getter(name="minElbCapacity")
    def min_elb_capacity(self) -> pulumi.Output[Optional[int]]:
        """
        Setting this causes this provider to wait for
        this number of instances from this autoscaling group to show up healthy in the
        ELB only on creation. Updates will not wait on ELB instance number changes.
        (See also Waiting for Capacity below.)
        """
        return pulumi.get(self, "min_elb_capacity")

    @property
    @pulumi.getter(name="minSize")
    def min_size(self) -> pulumi.Output[int]:
        """
        The minimum size of the auto scale group.
        (See also Waiting for Capacity below.)
        """
        return pulumi.get(self, "min_size")

    @property
    @pulumi.getter(name="mixedInstancesPolicy")
    def mixed_instances_policy(self) -> pulumi.Output[Optional['outputs.GroupMixedInstancesPolicy']]:
        """
        Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        """
        return pulumi.get(self, "mixed_instances_policy")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the auto scaling group. By default generated by this provider.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namePrefix")
    def name_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Creates a unique name beginning with the specified
        prefix. Conflicts with `name`.
        """
        return pulumi.get(self, "name_prefix")

    @property
    @pulumi.getter(name="placementGroup")
    def placement_group(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the placement group into which you'll launch your instances, if any.
        """
        return pulumi.get(self, "placement_group")

    @property
    @pulumi.getter(name="protectFromScaleIn")
    def protect_from_scale_in(self) -> pulumi.Output[Optional[bool]]:
        """
        Allows setting instance protection. The
        autoscaling group will not select instances with this setting for termination
        during scale in events.
        """
        return pulumi.get(self, "protect_from_scale_in")

    @property
    @pulumi.getter(name="serviceLinkedRoleArn")
    def service_linked_role_arn(self) -> pulumi.Output[str]:
        """
        The ARN of the service-linked role that the ASG will use to call other AWS services
        """
        return pulumi.get(self, "service_linked_role_arn")

    @property
    @pulumi.getter(name="suspendedProcesses")
    def suspended_processes(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
        Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        """
        return pulumi.get(self, "suspended_processes")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.GroupTag']]]:
        """
        Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tagsCollection")
    def tags_collection(self) -> pulumi.Output[Optional[Sequence[Mapping[str, str]]]]:
        """
        Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        """
        return pulumi.get(self, "tags_collection")

    @property
    @pulumi.getter(name="targetGroupArns")
    def target_group_arns(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A set of `alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        """
        return pulumi.get(self, "target_group_arns")

    @property
    @pulumi.getter(name="terminationPolicies")
    def termination_policies(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        """
        return pulumi.get(self, "termination_policies")

    @property
    @pulumi.getter(name="vpcZoneIdentifiers")
    def vpc_zone_identifiers(self) -> pulumi.Output[Sequence[str]]:
        """
        A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        """
        return pulumi.get(self, "vpc_zone_identifiers")

    @property
    @pulumi.getter(name="waitForCapacityTimeout")
    def wait_for_capacity_timeout(self) -> pulumi.Output[Optional[str]]:
        """
        A maximum
        [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
        wait for ASG instances to be healthy before timing out.  (See also Waiting
        for Capacity below.) Setting this to "0" causes
        this provider to skip all Capacity Waiting behavior.
        """
        return pulumi.get(self, "wait_for_capacity_timeout")

    @property
    @pulumi.getter(name="waitForElbCapacity")
    def wait_for_elb_capacity(self) -> pulumi.Output[Optional[int]]:
        """
        Setting this will cause this provider to wait
        for exactly this number of healthy instances from this autoscaling group in
        all attached load balancers on both create and update operations. (Takes
        precedence over `min_elb_capacity` behavior.)
        (See also Waiting for Capacity below.)
        """
        return pulumi.get(self, "wait_for_elb_capacity")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

