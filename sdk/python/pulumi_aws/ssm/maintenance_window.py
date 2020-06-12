# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class MaintenanceWindow(pulumi.CustomResource):
    allow_unassociated_targets: pulumi.Output[bool]
    """
    Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.
    """
    cutoff: pulumi.Output[float]
    """
    The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.
    """
    description: pulumi.Output[str]
    """
    A description for the maintenance window.
    """
    duration: pulumi.Output[float]
    """
    The duration of the Maintenance Window in hours.
    """
    enabled: pulumi.Output[bool]
    """
    Whether the maintenance window is enabled. Default: `true`.
    """
    end_date: pulumi.Output[str]
    """
    Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to no longer run the maintenance window.
    """
    name: pulumi.Output[str]
    """
    The name of the maintenance window.
    """
    schedule: pulumi.Output[str]
    """
    The schedule of the Maintenance Window in the form of a [cron](https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-cron.html) or rate expression.
    """
    schedule_timezone: pulumi.Output[str]
    """
    Timezone for schedule in [Internet Assigned Numbers Authority (IANA) Time Zone Database format](https://www.iana.org/time-zones). For example: `America/Los_Angeles`, `etc/UTC`, or `Asia/Seoul`.
    """
    start_date: pulumi.Output[str]
    """
    Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to begin the maintenance window.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, allow_unassociated_targets=None, cutoff=None, description=None, duration=None, enabled=None, end_date=None, name=None, schedule=None, schedule_timezone=None, start_date=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an SSM Maintenance Window resource

        ## Example Usage



        ```python
        import pulumi
        import pulumi_aws as aws

        production = aws.ssm.MaintenanceWindow("production",
            cutoff=1,
            duration=3,
            schedule="cron(0 16 ? * TUE *)")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] allow_unassociated_targets: Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.
        :param pulumi.Input[float] cutoff: The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.
        :param pulumi.Input[str] description: A description for the maintenance window.
        :param pulumi.Input[float] duration: The duration of the Maintenance Window in hours.
        :param pulumi.Input[bool] enabled: Whether the maintenance window is enabled. Default: `true`.
        :param pulumi.Input[str] end_date: Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to no longer run the maintenance window.
        :param pulumi.Input[str] name: The name of the maintenance window.
        :param pulumi.Input[str] schedule: The schedule of the Maintenance Window in the form of a [cron](https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-cron.html) or rate expression.
        :param pulumi.Input[str] schedule_timezone: Timezone for schedule in [Internet Assigned Numbers Authority (IANA) Time Zone Database format](https://www.iana.org/time-zones). For example: `America/Los_Angeles`, `etc/UTC`, or `Asia/Seoul`.
        :param pulumi.Input[str] start_date: Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to begin the maintenance window.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
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

            __props__['allow_unassociated_targets'] = allow_unassociated_targets
            if cutoff is None:
                raise TypeError("Missing required property 'cutoff'")
            __props__['cutoff'] = cutoff
            __props__['description'] = description
            if duration is None:
                raise TypeError("Missing required property 'duration'")
            __props__['duration'] = duration
            __props__['enabled'] = enabled
            __props__['end_date'] = end_date
            __props__['name'] = name
            if schedule is None:
                raise TypeError("Missing required property 'schedule'")
            __props__['schedule'] = schedule
            __props__['schedule_timezone'] = schedule_timezone
            __props__['start_date'] = start_date
            __props__['tags'] = tags
        super(MaintenanceWindow, __self__).__init__(
            'aws:ssm/maintenanceWindow:MaintenanceWindow',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, allow_unassociated_targets=None, cutoff=None, description=None, duration=None, enabled=None, end_date=None, name=None, schedule=None, schedule_timezone=None, start_date=None, tags=None):
        """
        Get an existing MaintenanceWindow resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] allow_unassociated_targets: Whether targets must be registered with the Maintenance Window before tasks can be defined for those targets.
        :param pulumi.Input[float] cutoff: The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling new tasks for execution.
        :param pulumi.Input[str] description: A description for the maintenance window.
        :param pulumi.Input[float] duration: The duration of the Maintenance Window in hours.
        :param pulumi.Input[bool] enabled: Whether the maintenance window is enabled. Default: `true`.
        :param pulumi.Input[str] end_date: Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to no longer run the maintenance window.
        :param pulumi.Input[str] name: The name of the maintenance window.
        :param pulumi.Input[str] schedule: The schedule of the Maintenance Window in the form of a [cron](https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-cron.html) or rate expression.
        :param pulumi.Input[str] schedule_timezone: Timezone for schedule in [Internet Assigned Numbers Authority (IANA) Time Zone Database format](https://www.iana.org/time-zones). For example: `America/Los_Angeles`, `etc/UTC`, or `Asia/Seoul`.
        :param pulumi.Input[str] start_date: Timestamp in [ISO-8601 extended format](https://www.iso.org/iso-8601-date-and-time-format.html) when to begin the maintenance window.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["allow_unassociated_targets"] = allow_unassociated_targets
        __props__["cutoff"] = cutoff
        __props__["description"] = description
        __props__["duration"] = duration
        __props__["enabled"] = enabled
        __props__["end_date"] = end_date
        __props__["name"] = name
        __props__["schedule"] = schedule
        __props__["schedule_timezone"] = schedule_timezone
        __props__["start_date"] = start_date
        __props__["tags"] = tags
        return MaintenanceWindow(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

