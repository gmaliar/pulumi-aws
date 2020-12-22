// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AutoScaling
{
    /// <summary>
    /// ## Import
    /// 
    /// AutoScaling Groups can be imported using the `name`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import aws:autoscaling/group:Group web web-asg
    /// ```
    /// </summary>
    public partial class Group : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN for this AutoScaling Group
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        /// </summary>
        [Output("availabilityZones")]
        public Output<ImmutableArray<string>> AvailabilityZones { get; private set; } = null!;

        /// <summary>
        /// Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        /// </summary>
        [Output("capacityRebalance")]
        public Output<bool?> CapacityRebalance { get; private set; } = null!;

        /// <summary>
        /// The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        /// </summary>
        [Output("defaultCooldown")]
        public Output<int> DefaultCooldown { get; private set; } = null!;

        /// <summary>
        /// The number of Amazon EC2 instances that
        /// should be running in the group. (See also Waiting for
        /// Capacity below.)
        /// </summary>
        [Output("desiredCapacity")]
        public Output<int> DesiredCapacity { get; private set; } = null!;

        /// <summary>
        /// A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        /// </summary>
        [Output("enabledMetrics")]
        public Output<ImmutableArray<string>> EnabledMetrics { get; private set; } = null!;

        /// <summary>
        /// Allows deleting the autoscaling group without waiting
        /// for all instances in the pool to terminate.  You can force an autoscaling group to delete
        /// even if it's in the process of scaling a resource. Normally, this provider
        /// drains all the instances before deleting the group.  This bypasses that
        /// behavior and potentially leaves resources dangling.
        /// </summary>
        [Output("forceDelete")]
        public Output<bool?> ForceDelete { get; private set; } = null!;

        /// <summary>
        /// Time (in seconds) after instance comes into service before checking health.
        /// </summary>
        [Output("healthCheckGracePeriod")]
        public Output<int?> HealthCheckGracePeriod { get; private set; } = null!;

        /// <summary>
        /// "EC2" or "ELB". Controls how health checking is done.
        /// </summary>
        [Output("healthCheckType")]
        public Output<string> HealthCheckType { get; private set; } = null!;

        /// <summary>
        /// One or more
        /// [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
        /// to attach to the autoscaling group **before** instances are launched. The
        /// syntax is exactly the same as the separate
        /// `aws.autoscaling.LifecycleHook`
        /// resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
        /// a new autoscaling group. For all other use-cases, please use `aws.autoscaling.LifecycleHook` resource.
        /// </summary>
        [Output("initialLifecycleHooks")]
        public Output<ImmutableArray<Outputs.GroupInitialLifecycleHook>> InitialLifecycleHooks { get; private set; } = null!;

        /// <summary>
        /// The name of the launch configuration to use.
        /// </summary>
        [Output("launchConfiguration")]
        public Output<string?> LaunchConfiguration { get; private set; } = null!;

        /// <summary>
        /// Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        /// </summary>
        [Output("launchTemplate")]
        public Output<Outputs.GroupLaunchTemplate?> LaunchTemplate { get; private set; } = null!;

        /// <summary>
        /// A list of elastic load balancer names to add to the autoscaling
        /// group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        /// </summary>
        [Output("loadBalancers")]
        public Output<ImmutableArray<string>> LoadBalancers { get; private set; } = null!;

        /// <summary>
        /// The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        /// </summary>
        [Output("maxInstanceLifetime")]
        public Output<int?> MaxInstanceLifetime { get; private set; } = null!;

        /// <summary>
        /// The maximum size of the auto scale group.
        /// </summary>
        [Output("maxSize")]
        public Output<int> MaxSize { get; private set; } = null!;

        /// <summary>
        /// The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        /// </summary>
        [Output("metricsGranularity")]
        public Output<string?> MetricsGranularity { get; private set; } = null!;

        /// <summary>
        /// Setting this causes this provider to wait for
        /// this number of instances from this autoscaling group to show up healthy in the
        /// ELB only on creation. Updates will not wait on ELB instance number changes.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Output("minElbCapacity")]
        public Output<int?> MinElbCapacity { get; private set; } = null!;

        /// <summary>
        /// The minimum size of the auto scale group.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Output("minSize")]
        public Output<int> MinSize { get; private set; } = null!;

        /// <summary>
        /// Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        /// </summary>
        [Output("mixedInstancesPolicy")]
        public Output<Outputs.GroupMixedInstancesPolicy?> MixedInstancesPolicy { get; private set; } = null!;

        /// <summary>
        /// The name of the auto scaling group. By default generated by this provider.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Output("namePrefix")]
        public Output<string?> NamePrefix { get; private set; } = null!;

        /// <summary>
        /// The name of the placement group into which you'll launch your instances, if any.
        /// </summary>
        [Output("placementGroup")]
        public Output<string?> PlacementGroup { get; private set; } = null!;

        /// <summary>
        /// Allows setting instance protection. The
        /// autoscaling group will not select instances with this setting for termination
        /// during scale in events.
        /// </summary>
        [Output("protectFromScaleIn")]
        public Output<bool?> ProtectFromScaleIn { get; private set; } = null!;

        /// <summary>
        /// The ARN of the service-linked role that the ASG will use to call other AWS services
        /// </summary>
        [Output("serviceLinkedRoleArn")]
        public Output<string> ServiceLinkedRoleArn { get; private set; } = null!;

        /// <summary>
        /// A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
        /// Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        /// </summary>
        [Output("suspendedProcesses")]
        public Output<ImmutableArray<string>> SuspendedProcesses { get; private set; } = null!;

        /// <summary>
        /// Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.GroupTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        /// </summary>
        [Output("tagsCollection")]
        public Output<ImmutableArray<ImmutableDictionary<string, string>>> TagsCollection { get; private set; } = null!;

        /// <summary>
        /// A set of `aws.alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        /// </summary>
        [Output("targetGroupArns")]
        public Output<ImmutableArray<string>> TargetGroupArns { get; private set; } = null!;

        /// <summary>
        /// A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        /// </summary>
        [Output("terminationPolicies")]
        public Output<ImmutableArray<string>> TerminationPolicies { get; private set; } = null!;

        /// <summary>
        /// A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        /// </summary>
        [Output("vpcZoneIdentifiers")]
        public Output<ImmutableArray<string>> VpcZoneIdentifiers { get; private set; } = null!;

        /// <summary>
        /// A maximum
        /// [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
        /// wait for ASG instances to be healthy before timing out.  (See also Waiting
        /// for Capacity below.) Setting this to "0" causes
        /// this provider to skip all Capacity Waiting behavior.
        /// </summary>
        [Output("waitForCapacityTimeout")]
        public Output<string?> WaitForCapacityTimeout { get; private set; } = null!;

        /// <summary>
        /// Setting this will cause this provider to wait
        /// for exactly this number of healthy instances from this autoscaling group in
        /// all attached load balancers on both create and update operations. (Takes
        /// precedence over `min_elb_capacity` behavior.)
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Output("waitForElbCapacity")]
        public Output<int?> WaitForElbCapacity { get; private set; } = null!;


        /// <summary>
        /// Create a Group resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Group(string name, GroupArgs args, CustomResourceOptions? options = null)
            : base("aws:autoscaling/group:Group", name, args ?? new GroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Group(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:autoscaling/group:Group", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Group resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Group Get(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
        {
            return new Group(name, id, state, options);
        }
    }

    public sealed class GroupArgs : Pulumi.ResourceArgs
    {
        [Input("availabilityZones")]
        private InputList<string>? _availabilityZones;

        /// <summary>
        /// A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        /// </summary>
        public InputList<string> AvailabilityZones
        {
            get => _availabilityZones ?? (_availabilityZones = new InputList<string>());
            set => _availabilityZones = value;
        }

        /// <summary>
        /// Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        /// </summary>
        [Input("capacityRebalance")]
        public Input<bool>? CapacityRebalance { get; set; }

        /// <summary>
        /// The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        /// </summary>
        [Input("defaultCooldown")]
        public Input<int>? DefaultCooldown { get; set; }

        /// <summary>
        /// The number of Amazon EC2 instances that
        /// should be running in the group. (See also Waiting for
        /// Capacity below.)
        /// </summary>
        [Input("desiredCapacity")]
        public Input<int>? DesiredCapacity { get; set; }

        [Input("enabledMetrics")]
        private InputList<string>? _enabledMetrics;

        /// <summary>
        /// A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        /// </summary>
        public InputList<string> EnabledMetrics
        {
            get => _enabledMetrics ?? (_enabledMetrics = new InputList<string>());
            set => _enabledMetrics = value;
        }

        /// <summary>
        /// Allows deleting the autoscaling group without waiting
        /// for all instances in the pool to terminate.  You can force an autoscaling group to delete
        /// even if it's in the process of scaling a resource. Normally, this provider
        /// drains all the instances before deleting the group.  This bypasses that
        /// behavior and potentially leaves resources dangling.
        /// </summary>
        [Input("forceDelete")]
        public Input<bool>? ForceDelete { get; set; }

        /// <summary>
        /// Time (in seconds) after instance comes into service before checking health.
        /// </summary>
        [Input("healthCheckGracePeriod")]
        public Input<int>? HealthCheckGracePeriod { get; set; }

        /// <summary>
        /// "EC2" or "ELB". Controls how health checking is done.
        /// </summary>
        [Input("healthCheckType")]
        public Input<string>? HealthCheckType { get; set; }

        [Input("initialLifecycleHooks")]
        private InputList<Inputs.GroupInitialLifecycleHookArgs>? _initialLifecycleHooks;

        /// <summary>
        /// One or more
        /// [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
        /// to attach to the autoscaling group **before** instances are launched. The
        /// syntax is exactly the same as the separate
        /// `aws.autoscaling.LifecycleHook`
        /// resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
        /// a new autoscaling group. For all other use-cases, please use `aws.autoscaling.LifecycleHook` resource.
        /// </summary>
        public InputList<Inputs.GroupInitialLifecycleHookArgs> InitialLifecycleHooks
        {
            get => _initialLifecycleHooks ?? (_initialLifecycleHooks = new InputList<Inputs.GroupInitialLifecycleHookArgs>());
            set => _initialLifecycleHooks = value;
        }

        /// <summary>
        /// The name of the launch configuration to use.
        /// </summary>
        [Input("launchConfiguration")]
        public Input<string>? LaunchConfiguration { get; set; }

        /// <summary>
        /// Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        /// </summary>
        [Input("launchTemplate")]
        public Input<Inputs.GroupLaunchTemplateArgs>? LaunchTemplate { get; set; }

        [Input("loadBalancers")]
        private InputList<string>? _loadBalancers;

        /// <summary>
        /// A list of elastic load balancer names to add to the autoscaling
        /// group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        /// </summary>
        public InputList<string> LoadBalancers
        {
            get => _loadBalancers ?? (_loadBalancers = new InputList<string>());
            set => _loadBalancers = value;
        }

        /// <summary>
        /// The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        /// </summary>
        [Input("maxInstanceLifetime")]
        public Input<int>? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// The maximum size of the auto scale group.
        /// </summary>
        [Input("maxSize", required: true)]
        public Input<int> MaxSize { get; set; } = null!;

        /// <summary>
        /// The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        /// </summary>
        [Input("metricsGranularity")]
        public InputUnion<string, Pulumi.Aws.AutoScaling.MetricsGranularity>? MetricsGranularity { get; set; }

        /// <summary>
        /// Setting this causes this provider to wait for
        /// this number of instances from this autoscaling group to show up healthy in the
        /// ELB only on creation. Updates will not wait on ELB instance number changes.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("minElbCapacity")]
        public Input<int>? MinElbCapacity { get; set; }

        /// <summary>
        /// The minimum size of the auto scale group.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("minSize", required: true)]
        public Input<int> MinSize { get; set; } = null!;

        /// <summary>
        /// Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        /// </summary>
        [Input("mixedInstancesPolicy")]
        public Input<Inputs.GroupMixedInstancesPolicyArgs>? MixedInstancesPolicy { get; set; }

        /// <summary>
        /// The name of the auto scaling group. By default generated by this provider.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The name of the placement group into which you'll launch your instances, if any.
        /// </summary>
        [Input("placementGroup")]
        public Input<string>? PlacementGroup { get; set; }

        /// <summary>
        /// Allows setting instance protection. The
        /// autoscaling group will not select instances with this setting for termination
        /// during scale in events.
        /// </summary>
        [Input("protectFromScaleIn")]
        public Input<bool>? ProtectFromScaleIn { get; set; }

        /// <summary>
        /// The ARN of the service-linked role that the ASG will use to call other AWS services
        /// </summary>
        [Input("serviceLinkedRoleArn")]
        public Input<string>? ServiceLinkedRoleArn { get; set; }

        [Input("suspendedProcesses")]
        private InputList<string>? _suspendedProcesses;

        /// <summary>
        /// A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
        /// Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        /// </summary>
        public InputList<string> SuspendedProcesses
        {
            get => _suspendedProcesses ?? (_suspendedProcesses = new InputList<string>());
            set => _suspendedProcesses = value;
        }

        [Input("tags")]
        private InputList<Inputs.GroupTagArgs>? _tags;

        /// <summary>
        /// Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        /// </summary>
        public InputList<Inputs.GroupTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.GroupTagArgs>());
            set => _tags = value;
        }

        [Input("tagsCollection")]
        private InputList<ImmutableDictionary<string, string>>? _tagsCollection;

        /// <summary>
        /// Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        /// </summary>
        public InputList<ImmutableDictionary<string, string>> TagsCollection
        {
            get => _tagsCollection ?? (_tagsCollection = new InputList<ImmutableDictionary<string, string>>());
            set => _tagsCollection = value;
        }

        [Input("targetGroupArns")]
        private InputList<string>? _targetGroupArns;

        /// <summary>
        /// A set of `aws.alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        /// </summary>
        public InputList<string> TargetGroupArns
        {
            get => _targetGroupArns ?? (_targetGroupArns = new InputList<string>());
            set => _targetGroupArns = value;
        }

        [Input("terminationPolicies")]
        private InputList<string>? _terminationPolicies;

        /// <summary>
        /// A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        /// </summary>
        public InputList<string> TerminationPolicies
        {
            get => _terminationPolicies ?? (_terminationPolicies = new InputList<string>());
            set => _terminationPolicies = value;
        }

        [Input("vpcZoneIdentifiers")]
        private InputList<string>? _vpcZoneIdentifiers;

        /// <summary>
        /// A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        /// </summary>
        public InputList<string> VpcZoneIdentifiers
        {
            get => _vpcZoneIdentifiers ?? (_vpcZoneIdentifiers = new InputList<string>());
            set => _vpcZoneIdentifiers = value;
        }

        /// <summary>
        /// A maximum
        /// [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
        /// wait for ASG instances to be healthy before timing out.  (See also Waiting
        /// for Capacity below.) Setting this to "0" causes
        /// this provider to skip all Capacity Waiting behavior.
        /// </summary>
        [Input("waitForCapacityTimeout")]
        public Input<string>? WaitForCapacityTimeout { get; set; }

        /// <summary>
        /// Setting this will cause this provider to wait
        /// for exactly this number of healthy instances from this autoscaling group in
        /// all attached load balancers on both create and update operations. (Takes
        /// precedence over `min_elb_capacity` behavior.)
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("waitForElbCapacity")]
        public Input<int>? WaitForElbCapacity { get; set; }

        public GroupArgs()
        {
        }
    }

    public sealed class GroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN for this AutoScaling Group
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("availabilityZones")]
        private InputList<string>? _availabilityZones;

        /// <summary>
        /// A list of one or more availability zones for the group. Used for EC2-Classic and default subnets when not specified with `vpc_zone_identifier` argument. Conflicts with `vpc_zone_identifier`.
        /// </summary>
        public InputList<string> AvailabilityZones
        {
            get => _availabilityZones ?? (_availabilityZones = new InputList<string>());
            set => _availabilityZones = value;
        }

        /// <summary>
        /// Indicates whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.
        /// </summary>
        [Input("capacityRebalance")]
        public Input<bool>? CapacityRebalance { get; set; }

        /// <summary>
        /// The amount of time, in seconds, after a scaling activity completes before another scaling activity can start.
        /// </summary>
        [Input("defaultCooldown")]
        public Input<int>? DefaultCooldown { get; set; }

        /// <summary>
        /// The number of Amazon EC2 instances that
        /// should be running in the group. (See also Waiting for
        /// Capacity below.)
        /// </summary>
        [Input("desiredCapacity")]
        public Input<int>? DesiredCapacity { get; set; }

        [Input("enabledMetrics")]
        private InputList<string>? _enabledMetrics;

        /// <summary>
        /// A list of metrics to collect. The allowed values are `GroupDesiredCapacity`, `GroupInServiceCapacity`, `GroupPendingCapacity`, `GroupMinSize`, `GroupMaxSize`, `GroupInServiceInstances`, `GroupPendingInstances`, `GroupStandbyInstances`, `GroupStandbyCapacity`, `GroupTerminatingCapacity`, `GroupTerminatingInstances`, `GroupTotalCapacity`, `GroupTotalInstances`.
        /// </summary>
        public InputList<string> EnabledMetrics
        {
            get => _enabledMetrics ?? (_enabledMetrics = new InputList<string>());
            set => _enabledMetrics = value;
        }

        /// <summary>
        /// Allows deleting the autoscaling group without waiting
        /// for all instances in the pool to terminate.  You can force an autoscaling group to delete
        /// even if it's in the process of scaling a resource. Normally, this provider
        /// drains all the instances before deleting the group.  This bypasses that
        /// behavior and potentially leaves resources dangling.
        /// </summary>
        [Input("forceDelete")]
        public Input<bool>? ForceDelete { get; set; }

        /// <summary>
        /// Time (in seconds) after instance comes into service before checking health.
        /// </summary>
        [Input("healthCheckGracePeriod")]
        public Input<int>? HealthCheckGracePeriod { get; set; }

        /// <summary>
        /// "EC2" or "ELB". Controls how health checking is done.
        /// </summary>
        [Input("healthCheckType")]
        public Input<string>? HealthCheckType { get; set; }

        [Input("initialLifecycleHooks")]
        private InputList<Inputs.GroupInitialLifecycleHookGetArgs>? _initialLifecycleHooks;

        /// <summary>
        /// One or more
        /// [Lifecycle Hooks](http://docs.aws.amazon.com/autoscaling/latest/userguide/lifecycle-hooks.html)
        /// to attach to the autoscaling group **before** instances are launched. The
        /// syntax is exactly the same as the separate
        /// `aws.autoscaling.LifecycleHook`
        /// resource, without the `autoscaling_group_name` attribute. Please note that this will only work when creating
        /// a new autoscaling group. For all other use-cases, please use `aws.autoscaling.LifecycleHook` resource.
        /// </summary>
        public InputList<Inputs.GroupInitialLifecycleHookGetArgs> InitialLifecycleHooks
        {
            get => _initialLifecycleHooks ?? (_initialLifecycleHooks = new InputList<Inputs.GroupInitialLifecycleHookGetArgs>());
            set => _initialLifecycleHooks = value;
        }

        /// <summary>
        /// The name of the launch configuration to use.
        /// </summary>
        [Input("launchConfiguration")]
        public Input<string>? LaunchConfiguration { get; set; }

        /// <summary>
        /// Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.
        /// </summary>
        [Input("launchTemplate")]
        public Input<Inputs.GroupLaunchTemplateGetArgs>? LaunchTemplate { get; set; }

        [Input("loadBalancers")]
        private InputList<string>? _loadBalancers;

        /// <summary>
        /// A list of elastic load balancer names to add to the autoscaling
        /// group names. Only valid for classic load balancers. For ALBs, use `target_group_arns` instead.
        /// </summary>
        public InputList<string> LoadBalancers
        {
            get => _loadBalancers ?? (_loadBalancers = new InputList<string>());
            set => _loadBalancers = value;
        }

        /// <summary>
        /// The maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 604800 and 31536000 seconds.
        /// </summary>
        [Input("maxInstanceLifetime")]
        public Input<int>? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// The maximum size of the auto scale group.
        /// </summary>
        [Input("maxSize")]
        public Input<int>? MaxSize { get; set; }

        /// <summary>
        /// The granularity to associate with the metrics to collect. The only valid value is `1Minute`. Default is `1Minute`.
        /// </summary>
        [Input("metricsGranularity")]
        public InputUnion<string, Pulumi.Aws.AutoScaling.MetricsGranularity>? MetricsGranularity { get; set; }

        /// <summary>
        /// Setting this causes this provider to wait for
        /// this number of instances from this autoscaling group to show up healthy in the
        /// ELB only on creation. Updates will not wait on ELB instance number changes.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("minElbCapacity")]
        public Input<int>? MinElbCapacity { get; set; }

        /// <summary>
        /// The minimum size of the auto scale group.
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("minSize")]
        public Input<int>? MinSize { get; set; }

        /// <summary>
        /// Configuration block containing settings to define launch targets for Auto Scaling groups. Defined below.
        /// </summary>
        [Input("mixedInstancesPolicy")]
        public Input<Inputs.GroupMixedInstancesPolicyGetArgs>? MixedInstancesPolicy { get; set; }

        /// <summary>
        /// The name of the auto scaling group. By default generated by this provider.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The name of the placement group into which you'll launch your instances, if any.
        /// </summary>
        [Input("placementGroup")]
        public Input<string>? PlacementGroup { get; set; }

        /// <summary>
        /// Allows setting instance protection. The
        /// autoscaling group will not select instances with this setting for termination
        /// during scale in events.
        /// </summary>
        [Input("protectFromScaleIn")]
        public Input<bool>? ProtectFromScaleIn { get; set; }

        /// <summary>
        /// The ARN of the service-linked role that the ASG will use to call other AWS services
        /// </summary>
        [Input("serviceLinkedRoleArn")]
        public Input<string>? ServiceLinkedRoleArn { get; set; }

        [Input("suspendedProcesses")]
        private InputList<string>? _suspendedProcesses;

        /// <summary>
        /// A list of processes to suspend for the AutoScaling Group. The allowed values are `Launch`, `Terminate`, `HealthCheck`, `ReplaceUnhealthy`, `AZRebalance`, `AlarmNotification`, `ScheduledActions`, `AddToLoadBalancer`.
        /// Note that if you suspend either the `Launch` or `Terminate` process types, it can prevent your autoscaling group from functioning properly.
        /// </summary>
        public InputList<string> SuspendedProcesses
        {
            get => _suspendedProcesses ?? (_suspendedProcesses = new InputList<string>());
            set => _suspendedProcesses = value;
        }

        [Input("tags")]
        private InputList<Inputs.GroupTagGetArgs>? _tags;

        /// <summary>
        /// Configuration block(s) containing resource tags. Conflicts with `tags`. Documented below.
        /// </summary>
        public InputList<Inputs.GroupTagGetArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.GroupTagGetArgs>());
            set => _tags = value;
        }

        [Input("tagsCollection")]
        private InputList<ImmutableDictionary<string, string>>? _tagsCollection;

        /// <summary>
        /// Set of maps containing resource tags. Conflicts with `tag`. Documented below.
        /// </summary>
        public InputList<ImmutableDictionary<string, string>> TagsCollection
        {
            get => _tagsCollection ?? (_tagsCollection = new InputList<ImmutableDictionary<string, string>>());
            set => _tagsCollection = value;
        }

        [Input("targetGroupArns")]
        private InputList<string>? _targetGroupArns;

        /// <summary>
        /// A set of `aws.alb.TargetGroup` ARNs, for use with Application or Network Load Balancing.
        /// </summary>
        public InputList<string> TargetGroupArns
        {
            get => _targetGroupArns ?? (_targetGroupArns = new InputList<string>());
            set => _targetGroupArns = value;
        }

        [Input("terminationPolicies")]
        private InputList<string>? _terminationPolicies;

        /// <summary>
        /// A list of policies to decide how the instances in the auto scale group should be terminated. The allowed values are `OldestInstance`, `NewestInstance`, `OldestLaunchConfiguration`, `ClosestToNextInstanceHour`, `OldestLaunchTemplate`, `AllocationStrategy`, `Default`.
        /// </summary>
        public InputList<string> TerminationPolicies
        {
            get => _terminationPolicies ?? (_terminationPolicies = new InputList<string>());
            set => _terminationPolicies = value;
        }

        [Input("vpcZoneIdentifiers")]
        private InputList<string>? _vpcZoneIdentifiers;

        /// <summary>
        /// A list of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with `availability_zones`.
        /// </summary>
        public InputList<string> VpcZoneIdentifiers
        {
            get => _vpcZoneIdentifiers ?? (_vpcZoneIdentifiers = new InputList<string>());
            set => _vpcZoneIdentifiers = value;
        }

        /// <summary>
        /// A maximum
        /// [duration](https://golang.org/pkg/time/#ParseDuration) that this provider should
        /// wait for ASG instances to be healthy before timing out.  (See also Waiting
        /// for Capacity below.) Setting this to "0" causes
        /// this provider to skip all Capacity Waiting behavior.
        /// </summary>
        [Input("waitForCapacityTimeout")]
        public Input<string>? WaitForCapacityTimeout { get; set; }

        /// <summary>
        /// Setting this will cause this provider to wait
        /// for exactly this number of healthy instances from this autoscaling group in
        /// all attached load balancers on both create and update operations. (Takes
        /// precedence over `min_elb_capacity` behavior.)
        /// (See also Waiting for Capacity below.)
        /// </summary>
        [Input("waitForElbCapacity")]
        public Input<int>? WaitForElbCapacity { get; set; }

        public GroupState()
        {
        }
    }
}
