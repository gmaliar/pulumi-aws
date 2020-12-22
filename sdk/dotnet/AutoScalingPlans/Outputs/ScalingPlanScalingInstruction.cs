// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AutoScalingPlans.Outputs
{

    [OutputType]
    public sealed class ScalingPlanScalingInstruction
    {
        /// <summary>
        /// The customized load metric to use for predictive scaling. You must specify either `customized_load_metric_specification` or `predefined_load_metric_specification` when configuring predictive scaling.
        /// More details can be found in the [AWS Auto Scaling API Reference](https://docs.aws.amazon.com/autoscaling/plans/APIReference/API_CustomizedLoadMetricSpecification.html).
        /// </summary>
        public readonly Outputs.ScalingPlanScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification;
        /// <summary>
        /// Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to `false`.
        /// </summary>
        public readonly bool? DisableDynamicScaling;
        /// <summary>
        /// The maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for `predictive_scaling_max_capacity_behavior`.
        /// </summary>
        public readonly int MaxCapacity;
        /// <summary>
        /// The minimum capacity of the resource.
        /// </summary>
        public readonly int MinCapacity;
        /// <summary>
        /// The predefined load metric to use for predictive scaling. You must specify either `predefined_load_metric_specification` or `customized_load_metric_specification` when configuring predictive scaling.
        /// More details can be found in the [AWS Auto Scaling API Reference](https://docs.aws.amazon.com/autoscaling/plans/APIReference/API_PredefinedLoadMetricSpecification.html).
        /// </summary>
        public readonly Outputs.ScalingPlanScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification;
        /// <summary>
        /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource.
        /// Valid values: `SetForecastCapacityToMaxCapacity`, `SetMaxCapacityAboveForecastCapacity`, `SetMaxCapacityToForecastCapacity`.
        /// </summary>
        public readonly string? PredictiveScalingMaxCapacityBehavior;
        /// <summary>
        /// The size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.
        /// </summary>
        public readonly int? PredictiveScalingMaxCapacityBuffer;
        /// <summary>
        /// The predictive scaling mode. Valid values: `ForecastAndScale`, `ForecastOnly`.
        /// </summary>
        public readonly string? PredictiveScalingMode;
        /// <summary>
        /// The ID of the resource. This string consists of the resource type and unique identifier.
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// The scalable dimension associated with the resource. Valid values: `autoscaling:autoScalingGroup:DesiredCapacity`, `dynamodb:index:ReadCapacityUnits`, `dynamodb:index:WriteCapacityUnits`, `dynamodb:table:ReadCapacityUnits`, `dynamodb:table:WriteCapacityUnits`, `ecs:service:DesiredCount`, `ec2:spot-fleet-request:TargetCapacity`, `rds:cluster:ReadReplicaCount`.
        /// </summary>
        public readonly string ScalableDimension;
        /// <summary>
        /// Controls whether a resource's externally created scaling policies are kept or replaced. Valid values: `KeepExternalPolicies`, `ReplaceExternalPolicies`. Defaults to `KeepExternalPolicies`.
        /// </summary>
        public readonly string? ScalingPolicyUpdateBehavior;
        /// <summary>
        /// The amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.
        /// </summary>
        public readonly int? ScheduledActionBufferTime;
        /// <summary>
        /// The namespace of the AWS service. Valid values: `autoscaling`, `dynamodb`, `ecs`, `ec2`, `rds`.
        /// </summary>
        public readonly string ServiceNamespace;
        /// <summary>
        /// The structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling.
        /// More details can be found in the [AWS Auto Scaling API Reference](https://docs.aws.amazon.com/autoscaling/plans/APIReference/API_TargetTrackingConfiguration.html).
        /// </summary>
        public readonly ImmutableArray<Outputs.ScalingPlanScalingInstructionTargetTrackingConfiguration> TargetTrackingConfigurations;

        [OutputConstructor]
        private ScalingPlanScalingInstruction(
            Outputs.ScalingPlanScalingInstructionCustomizedLoadMetricSpecification? customizedLoadMetricSpecification,

            bool? disableDynamicScaling,

            int maxCapacity,

            int minCapacity,

            Outputs.ScalingPlanScalingInstructionPredefinedLoadMetricSpecification? predefinedLoadMetricSpecification,

            string? predictiveScalingMaxCapacityBehavior,

            int? predictiveScalingMaxCapacityBuffer,

            string? predictiveScalingMode,

            string resourceId,

            string scalableDimension,

            string? scalingPolicyUpdateBehavior,

            int? scheduledActionBufferTime,

            string serviceNamespace,

            ImmutableArray<Outputs.ScalingPlanScalingInstructionTargetTrackingConfiguration> targetTrackingConfigurations)
        {
            CustomizedLoadMetricSpecification = customizedLoadMetricSpecification;
            DisableDynamicScaling = disableDynamicScaling;
            MaxCapacity = maxCapacity;
            MinCapacity = minCapacity;
            PredefinedLoadMetricSpecification = predefinedLoadMetricSpecification;
            PredictiveScalingMaxCapacityBehavior = predictiveScalingMaxCapacityBehavior;
            PredictiveScalingMaxCapacityBuffer = predictiveScalingMaxCapacityBuffer;
            PredictiveScalingMode = predictiveScalingMode;
            ResourceId = resourceId;
            ScalableDimension = scalableDimension;
            ScalingPolicyUpdateBehavior = scalingPolicyUpdateBehavior;
            ScheduledActionBufferTime = scheduledActionBufferTime;
            ServiceNamespace = serviceNamespace;
            TargetTrackingConfigurations = targetTrackingConfigurations;
        }
    }
}
