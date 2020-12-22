# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'ApplicationAppversionLifecycleArgs',
    'ConfigurationTemplateSettingArgs',
    'EnvironmentAllSettingArgs',
    'EnvironmentSettingArgs',
]

@pulumi.input_type
class ApplicationAppversionLifecycleArgs:
    def __init__(__self__, *,
                 service_role: pulumi.Input[str],
                 delete_source_from_s3: Optional[pulumi.Input[bool]] = None,
                 max_age_in_days: Optional[pulumi.Input[int]] = None,
                 max_count: Optional[pulumi.Input[int]] = None):
        """
        :param pulumi.Input[str] service_role: The ARN of an IAM service role under which the application version is deleted.  Elastic Beanstalk must have permission to assume this role.
        :param pulumi.Input[bool] delete_source_from_s3: Set to `true` to delete a version's source bundle from S3 when the application version is deleted.
        :param pulumi.Input[int] max_age_in_days: The number of days to retain an application version ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        :param pulumi.Input[int] max_count: The maximum number of application versions to retain ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        """
        pulumi.set(__self__, "service_role", service_role)
        if delete_source_from_s3 is not None:
            pulumi.set(__self__, "delete_source_from_s3", delete_source_from_s3)
        if max_age_in_days is not None:
            pulumi.set(__self__, "max_age_in_days", max_age_in_days)
        if max_count is not None:
            pulumi.set(__self__, "max_count", max_count)

    @property
    @pulumi.getter(name="serviceRole")
    def service_role(self) -> pulumi.Input[str]:
        """
        The ARN of an IAM service role under which the application version is deleted.  Elastic Beanstalk must have permission to assume this role.
        """
        return pulumi.get(self, "service_role")

    @service_role.setter
    def service_role(self, value: pulumi.Input[str]):
        pulumi.set(self, "service_role", value)

    @property
    @pulumi.getter(name="deleteSourceFromS3")
    def delete_source_from_s3(self) -> Optional[pulumi.Input[bool]]:
        """
        Set to `true` to delete a version's source bundle from S3 when the application version is deleted.
        """
        return pulumi.get(self, "delete_source_from_s3")

    @delete_source_from_s3.setter
    def delete_source_from_s3(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "delete_source_from_s3", value)

    @property
    @pulumi.getter(name="maxAgeInDays")
    def max_age_in_days(self) -> Optional[pulumi.Input[int]]:
        """
        The number of days to retain an application version ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        """
        return pulumi.get(self, "max_age_in_days")

    @max_age_in_days.setter
    def max_age_in_days(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_age_in_days", value)

    @property
    @pulumi.getter(name="maxCount")
    def max_count(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum number of application versions to retain ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        """
        return pulumi.get(self, "max_count")

    @max_count.setter
    def max_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_count", value)


@pulumi.input_type
class ConfigurationTemplateSettingArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 namespace: pulumi.Input[str],
                 value: pulumi.Input[str],
                 resource: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] name: A unique name for this Template.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "namespace", namespace)
        pulumi.set(__self__, "value", value)
        if resource is not None:
            pulumi.set(__self__, "resource", resource)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A unique name for this Template.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter
    def resource(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resource")

    @resource.setter
    def resource(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource", value)


@pulumi.input_type
class EnvironmentAllSettingArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 namespace: pulumi.Input[str],
                 value: pulumi.Input[str],
                 resource: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] name: A unique name for this Environment. This name is used
               in the application URL
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "namespace", namespace)
        pulumi.set(__self__, "value", value)
        if resource is not None:
            pulumi.set(__self__, "resource", resource)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A unique name for this Environment. This name is used
        in the application URL
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter
    def resource(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resource")

    @resource.setter
    def resource(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource", value)


@pulumi.input_type
class EnvironmentSettingArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 namespace: pulumi.Input[str],
                 value: pulumi.Input[str],
                 resource: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] name: A unique name for this Environment. This name is used
               in the application URL
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "namespace", namespace)
        pulumi.set(__self__, "value", value)
        if resource is not None:
            pulumi.set(__self__, "resource", resource)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A unique name for this Environment. This name is used
        in the application URL
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter
    def resource(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resource")

    @resource.setter
    def resource(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource", value)


