# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'ConfigurationAggregatorAccountAggregationSource',
    'ConfigurationAggregatorOrganizationAggregationSource',
    'DeliveryChannelSnapshotDeliveryProperties',
    'RecorderRecordingGroup',
    'RemediationConfigurationParameter',
    'RuleScope',
    'RuleSource',
    'RuleSourceSourceDetail',
]

@pulumi.output_type
class ConfigurationAggregatorAccountAggregationSource(dict):
    def __init__(__self__, *,
                 account_ids: Sequence[str],
                 all_regions: Optional[bool] = None,
                 regions: Optional[Sequence[str]] = None):
        """
        :param Sequence[str] account_ids: List of 12-digit account IDs of the account(s) being aggregated.
        :param bool all_regions: If true, aggregate existing AWS Config regions and future regions.
        :param Sequence[str] regions: List of source regions being aggregated.
        """
        pulumi.set(__self__, "account_ids", account_ids)
        if all_regions is not None:
            pulumi.set(__self__, "all_regions", all_regions)
        if regions is not None:
            pulumi.set(__self__, "regions", regions)

    @property
    @pulumi.getter(name="accountIds")
    def account_ids(self) -> Sequence[str]:
        """
        List of 12-digit account IDs of the account(s) being aggregated.
        """
        return pulumi.get(self, "account_ids")

    @property
    @pulumi.getter(name="allRegions")
    def all_regions(self) -> Optional[bool]:
        """
        If true, aggregate existing AWS Config regions and future regions.
        """
        return pulumi.get(self, "all_regions")

    @property
    @pulumi.getter
    def regions(self) -> Optional[Sequence[str]]:
        """
        List of source regions being aggregated.
        """
        return pulumi.get(self, "regions")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConfigurationAggregatorOrganizationAggregationSource(dict):
    def __init__(__self__, *,
                 role_arn: str,
                 all_regions: Optional[bool] = None,
                 regions: Optional[Sequence[str]] = None):
        """
        :param str role_arn: ARN of the IAM role used to retrieve AWS Organization details associated with the aggregator account.
        :param bool all_regions: If true, aggregate existing AWS Config regions and future regions.
        :param Sequence[str] regions: List of source regions being aggregated.
        """
        pulumi.set(__self__, "role_arn", role_arn)
        if all_regions is not None:
            pulumi.set(__self__, "all_regions", all_regions)
        if regions is not None:
            pulumi.set(__self__, "regions", regions)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> str:
        """
        ARN of the IAM role used to retrieve AWS Organization details associated with the aggregator account.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="allRegions")
    def all_regions(self) -> Optional[bool]:
        """
        If true, aggregate existing AWS Config regions and future regions.
        """
        return pulumi.get(self, "all_regions")

    @property
    @pulumi.getter
    def regions(self) -> Optional[Sequence[str]]:
        """
        List of source regions being aggregated.
        """
        return pulumi.get(self, "regions")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DeliveryChannelSnapshotDeliveryProperties(dict):
    def __init__(__self__, *,
                 delivery_frequency: Optional[str] = None):
        """
        :param str delivery_frequency: - The frequency with which AWS Config recurringly delivers configuration snapshots. e.g. `One_Hour` or `Three_Hours`. Valid values are listed [here](https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigSnapshotDeliveryProperties.html#API_ConfigSnapshotDeliveryProperties_Contents).
        """
        if delivery_frequency is not None:
            pulumi.set(__self__, "delivery_frequency", delivery_frequency)

    @property
    @pulumi.getter(name="deliveryFrequency")
    def delivery_frequency(self) -> Optional[str]:
        """
        - The frequency with which AWS Config recurringly delivers configuration snapshots. e.g. `One_Hour` or `Three_Hours`. Valid values are listed [here](https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigSnapshotDeliveryProperties.html#API_ConfigSnapshotDeliveryProperties_Contents).
        """
        return pulumi.get(self, "delivery_frequency")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RecorderRecordingGroup(dict):
    def __init__(__self__, *,
                 all_supported: Optional[bool] = None,
                 include_global_resource_types: Optional[bool] = None,
                 resource_types: Optional[Sequence[str]] = None):
        """
        :param bool all_supported: Specifies whether AWS Config records configuration changes for every supported type of regional resource (which includes any new type that will become supported in the future). Conflicts with `resource_types`. Defaults to `true`.
        :param bool include_global_resource_types: Specifies whether AWS Config includes all supported types of *global resources* with the resources that it records. Requires `all_supported = true`. Conflicts with `resource_types`.
        :param Sequence[str] resource_types: A list that specifies the types of AWS resources for which AWS Config records configuration changes (for example, `AWS::EC2::Instance` or `AWS::CloudTrail::Trail`). See [relevant part of AWS Docs](http://docs.aws.amazon.com/config/latest/APIReference/API_ResourceIdentifier.html#config-Type-ResourceIdentifier-resourceType) for available types.
        """
        if all_supported is not None:
            pulumi.set(__self__, "all_supported", all_supported)
        if include_global_resource_types is not None:
            pulumi.set(__self__, "include_global_resource_types", include_global_resource_types)
        if resource_types is not None:
            pulumi.set(__self__, "resource_types", resource_types)

    @property
    @pulumi.getter(name="allSupported")
    def all_supported(self) -> Optional[bool]:
        """
        Specifies whether AWS Config records configuration changes for every supported type of regional resource (which includes any new type that will become supported in the future). Conflicts with `resource_types`. Defaults to `true`.
        """
        return pulumi.get(self, "all_supported")

    @property
    @pulumi.getter(name="includeGlobalResourceTypes")
    def include_global_resource_types(self) -> Optional[bool]:
        """
        Specifies whether AWS Config includes all supported types of *global resources* with the resources that it records. Requires `all_supported = true`. Conflicts with `resource_types`.
        """
        return pulumi.get(self, "include_global_resource_types")

    @property
    @pulumi.getter(name="resourceTypes")
    def resource_types(self) -> Optional[Sequence[str]]:
        """
        A list that specifies the types of AWS resources for which AWS Config records configuration changes (for example, `AWS::EC2::Instance` or `AWS::CloudTrail::Trail`). See [relevant part of AWS Docs](http://docs.aws.amazon.com/config/latest/APIReference/API_ResourceIdentifier.html#config-Type-ResourceIdentifier-resourceType) for available types.
        """
        return pulumi.get(self, "resource_types")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RemediationConfigurationParameter(dict):
    def __init__(__self__, *,
                 name: str,
                 resource_value: Optional[str] = None,
                 static_value: Optional[str] = None):
        """
        :param str name: The name of the attribute.
        :param str resource_value: The value is dynamic and changes at run-time.
        :param str static_value: The value is static and does not change at run-time.
        """
        pulumi.set(__self__, "name", name)
        if resource_value is not None:
            pulumi.set(__self__, "resource_value", resource_value)
        if static_value is not None:
            pulumi.set(__self__, "static_value", static_value)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the attribute.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceValue")
    def resource_value(self) -> Optional[str]:
        """
        The value is dynamic and changes at run-time.
        """
        return pulumi.get(self, "resource_value")

    @property
    @pulumi.getter(name="staticValue")
    def static_value(self) -> Optional[str]:
        """
        The value is static and does not change at run-time.
        """
        return pulumi.get(self, "static_value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RuleScope(dict):
    def __init__(__self__, *,
                 compliance_resource_id: Optional[str] = None,
                 compliance_resource_types: Optional[Sequence[str]] = None,
                 tag_key: Optional[str] = None,
                 tag_value: Optional[str] = None):
        """
        :param str compliance_resource_id: The IDs of the only AWS resource that you want to trigger an evaluation for the rule. If you specify a resource ID, you must specify one resource type for `compliance_resource_types`.
        :param Sequence[str] compliance_resource_types: A list of resource types of only those AWS resources that you want to trigger an evaluation for the rule. e.g. `AWS::EC2::Instance`. You can only specify one type if you also specify a resource ID for `compliance_resource_id`. See [relevant part of AWS Docs](http://docs.aws.amazon.com/config/latest/APIReference/API_ResourceIdentifier.html#config-Type-ResourceIdentifier-resourceType) for available types.
        :param str tag_key: The tag key that is applied to only those AWS resources that you want you want to trigger an evaluation for the rule.
        :param str tag_value: The tag value applied to only those AWS resources that you want to trigger an evaluation for the rule.
        """
        if compliance_resource_id is not None:
            pulumi.set(__self__, "compliance_resource_id", compliance_resource_id)
        if compliance_resource_types is not None:
            pulumi.set(__self__, "compliance_resource_types", compliance_resource_types)
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="complianceResourceId")
    def compliance_resource_id(self) -> Optional[str]:
        """
        The IDs of the only AWS resource that you want to trigger an evaluation for the rule. If you specify a resource ID, you must specify one resource type for `compliance_resource_types`.
        """
        return pulumi.get(self, "compliance_resource_id")

    @property
    @pulumi.getter(name="complianceResourceTypes")
    def compliance_resource_types(self) -> Optional[Sequence[str]]:
        """
        A list of resource types of only those AWS resources that you want to trigger an evaluation for the rule. e.g. `AWS::EC2::Instance`. You can only specify one type if you also specify a resource ID for `compliance_resource_id`. See [relevant part of AWS Docs](http://docs.aws.amazon.com/config/latest/APIReference/API_ResourceIdentifier.html#config-Type-ResourceIdentifier-resourceType) for available types.
        """
        return pulumi.get(self, "compliance_resource_types")

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[str]:
        """
        The tag key that is applied to only those AWS resources that you want you want to trigger an evaluation for the rule.
        """
        return pulumi.get(self, "tag_key")

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[str]:
        """
        The tag value applied to only those AWS resources that you want to trigger an evaluation for the rule.
        """
        return pulumi.get(self, "tag_value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RuleSource(dict):
    def __init__(__self__, *,
                 owner: str,
                 source_identifier: str,
                 source_details: Optional[Sequence['outputs.RuleSourceSourceDetail']] = None):
        """
        :param str owner: Indicates whether AWS or the customer owns and manages the AWS Config rule. Valid values are `AWS` or `CUSTOM_LAMBDA`. For more information about managed rules, see the [AWS Config Managed Rules documentation](https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html). For more information about custom rules, see the [AWS Config Custom Rules documentation](https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_develop-rules.html). Custom Lambda Functions require permissions to allow the AWS Config service to invoke them, e.g. via the `lambda.Permission` resource.
        :param str source_identifier: For AWS Config managed rules, a predefined identifier, e.g `IAM_PASSWORD_POLICY`. For custom Lambda rules, the identifier is the ARN of the Lambda Function, such as `arn:aws:lambda:us-east-1:123456789012:function:custom_rule_name` or the `arn` attribute of the `lambda.Function` resource.
        :param Sequence['RuleSourceSourceDetailArgs'] source_details: Provides the source and type of the event that causes AWS Config to evaluate your AWS resources. Only valid if `owner` is `CUSTOM_LAMBDA`.
        """
        pulumi.set(__self__, "owner", owner)
        pulumi.set(__self__, "source_identifier", source_identifier)
        if source_details is not None:
            pulumi.set(__self__, "source_details", source_details)

    @property
    @pulumi.getter
    def owner(self) -> str:
        """
        Indicates whether AWS or the customer owns and manages the AWS Config rule. Valid values are `AWS` or `CUSTOM_LAMBDA`. For more information about managed rules, see the [AWS Config Managed Rules documentation](https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html). For more information about custom rules, see the [AWS Config Custom Rules documentation](https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_develop-rules.html). Custom Lambda Functions require permissions to allow the AWS Config service to invoke them, e.g. via the `lambda.Permission` resource.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="sourceIdentifier")
    def source_identifier(self) -> str:
        """
        For AWS Config managed rules, a predefined identifier, e.g `IAM_PASSWORD_POLICY`. For custom Lambda rules, the identifier is the ARN of the Lambda Function, such as `arn:aws:lambda:us-east-1:123456789012:function:custom_rule_name` or the `arn` attribute of the `lambda.Function` resource.
        """
        return pulumi.get(self, "source_identifier")

    @property
    @pulumi.getter(name="sourceDetails")
    def source_details(self) -> Optional[Sequence['outputs.RuleSourceSourceDetail']]:
        """
        Provides the source and type of the event that causes AWS Config to evaluate your AWS resources. Only valid if `owner` is `CUSTOM_LAMBDA`.
        """
        return pulumi.get(self, "source_details")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class RuleSourceSourceDetail(dict):
    def __init__(__self__, *,
                 event_source: Optional[str] = None,
                 maximum_execution_frequency: Optional[str] = None,
                 message_type: Optional[str] = None):
        """
        :param str event_source: The source of the event, such as an AWS service, that triggers AWS Config to evaluate your AWS resources. This defaults to `aws.config` and is the only valid value.
        :param str maximum_execution_frequency: The frequency that you want AWS Config to run evaluations for a rule that is triggered periodically. If specified, requires `message_type` to be `ScheduledNotification`.
        :param str message_type: The type of notification that triggers AWS Config to run an evaluation for a rule. You can specify the following notification types:
        """
        if event_source is not None:
            pulumi.set(__self__, "event_source", event_source)
        if maximum_execution_frequency is not None:
            pulumi.set(__self__, "maximum_execution_frequency", maximum_execution_frequency)
        if message_type is not None:
            pulumi.set(__self__, "message_type", message_type)

    @property
    @pulumi.getter(name="eventSource")
    def event_source(self) -> Optional[str]:
        """
        The source of the event, such as an AWS service, that triggers AWS Config to evaluate your AWS resources. This defaults to `aws.config` and is the only valid value.
        """
        return pulumi.get(self, "event_source")

    @property
    @pulumi.getter(name="maximumExecutionFrequency")
    def maximum_execution_frequency(self) -> Optional[str]:
        """
        The frequency that you want AWS Config to run evaluations for a rule that is triggered periodically. If specified, requires `message_type` to be `ScheduledNotification`.
        """
        return pulumi.get(self, "maximum_execution_frequency")

    @property
    @pulumi.getter(name="messageType")
    def message_type(self) -> Optional[str]:
        """
        The type of notification that triggers AWS Config to run an evaluation for a rule. You can specify the following notification types:
        """
        return pulumi.get(self, "message_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


