# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class Schedule(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    The description of the schedule
    """
    layers: pulumi.Output[list]
    """
    A schedule layer block. Schedule layers documented below.

      * `end` (`str`) - The end time of the schedule layer. If not specified, the layer does not end.
      * `id` (`str`) - The ID of the schedule
      * `name` (`str`) - The name of the schedule layer.
      * `restrictions` (`list`) - A schedule layer restriction block. Restriction blocks documented below.
        * `durationSeconds` (`float`) - The duration of the restriction in `seconds`.
        * `startDayOfWeek` (`float`) - Number of the day when restriction starts. From 1 to 7 where 1 is Monday and 7 is Sunday.
        * `startTimeOfDay` (`str`) - The start time in `HH:mm:ss` format.
        * `type` (`str`) - Can be `daily_restriction` or `weekly_restriction`

      * `rotationTurnLengthSeconds` (`float`) - The duration of each on-call shift in `seconds`.
      * `rotationVirtualStart` (`str`) - The effective start time of the schedule layer. This can be before the start time of the schedule.
      * `start` (`str`) - The start time of the schedule layer. This value will not be read back from the PagerDuty API because the API will always return a new `start` time, which represents the last updated time of the schedule layer.
      * `users` (`list`) - The ordered list of users on this layer. The position of the user on the list determines their order in the layer.
    """
    name: pulumi.Output[str]
    """
    The name of the schedule.
    """
    overflow: pulumi.Output[bool]
    """
    Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow` is passed. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:
    If you don't pass the overflow=true parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`.
    If you do pass the `overflow` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.
    """
    time_zone: pulumi.Output[str]
    """
    The time zone of the schedule (e.g Europe/Berlin).
    """
    def __init__(__self__, resource_name, opts=None, description=None, layers=None, name=None, overflow=None, time_zone=None, __props__=None, __name__=None, __opts__=None):
        """
        A [schedule](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Schedules/get_schedules) determines the time periods that users are on call. Only on-call users are eligible to receive notifications from incidents.


        ## Example Usage



        ```python
        import pulumi
        import pulumi_pagerduty as pagerduty

        example = pagerduty.User("example",
            email="125.greenholt.earline@graham.name",
            teams=[pagerduty_team["example"]["id"]])
        foo = pagerduty.Schedule("foo",
            layers=[{
                "name": "Night Shift",
                "restriction": [{
                    "durationSeconds": 32400,
                    "startTimeOfDay": "08:00:00",
                    "type": "daily_restriction",
                }],
                "rotationTurnLengthSeconds": 86400,
                "rotationVirtualStart": "2015-11-06T20:00:00-05:00",
                "start": "2015-11-06T20:00:00-05:00",
                "users": [pagerduty_user["foo"]["id"]],
            }],
            time_zone="America/New_York")
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the schedule
        :param pulumi.Input[list] layers: A schedule layer block. Schedule layers documented below.
        :param pulumi.Input[str] name: The name of the schedule.
        :param pulumi.Input[bool] overflow: Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow` is passed. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:
               If you don't pass the overflow=true parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`.
               If you do pass the `overflow` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.
        :param pulumi.Input[str] time_zone: The time zone of the schedule (e.g Europe/Berlin).

        The **layers** object supports the following:

          * `end` (`pulumi.Input[str]`) - The end time of the schedule layer. If not specified, the layer does not end.
          * `id` (`pulumi.Input[str]`) - The ID of the schedule
          * `name` (`pulumi.Input[str]`) - The name of the schedule layer.
          * `restrictions` (`pulumi.Input[list]`) - A schedule layer restriction block. Restriction blocks documented below.
            * `durationSeconds` (`pulumi.Input[float]`) - The duration of the restriction in `seconds`.
            * `startDayOfWeek` (`pulumi.Input[float]`) - Number of the day when restriction starts. From 1 to 7 where 1 is Monday and 7 is Sunday.
            * `startTimeOfDay` (`pulumi.Input[str]`) - The start time in `HH:mm:ss` format.
            * `type` (`pulumi.Input[str]`) - Can be `daily_restriction` or `weekly_restriction`

          * `rotationTurnLengthSeconds` (`pulumi.Input[float]`) - The duration of each on-call shift in `seconds`.
          * `rotationVirtualStart` (`pulumi.Input[str]`) - The effective start time of the schedule layer. This can be before the start time of the schedule.
          * `start` (`pulumi.Input[str]`) - The start time of the schedule layer. This value will not be read back from the PagerDuty API because the API will always return a new `start` time, which represents the last updated time of the schedule layer.
          * `users` (`pulumi.Input[list]`) - The ordered list of users on this layer. The position of the user on the list determines their order in the layer.
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

            __props__['description'] = description
            if layers is None:
                raise TypeError("Missing required property 'layers'")
            __props__['layers'] = layers
            __props__['name'] = name
            __props__['overflow'] = overflow
            if time_zone is None:
                raise TypeError("Missing required property 'time_zone'")
            __props__['time_zone'] = time_zone
        super(Schedule, __self__).__init__(
            'pagerduty:index/schedule:Schedule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, layers=None, name=None, overflow=None, time_zone=None):
        """
        Get an existing Schedule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the schedule
        :param pulumi.Input[list] layers: A schedule layer block. Schedule layers documented below.
        :param pulumi.Input[str] name: The name of the schedule.
        :param pulumi.Input[bool] overflow: Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow` is passed. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:
               If you don't pass the overflow=true parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`.
               If you do pass the `overflow` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.
        :param pulumi.Input[str] time_zone: The time zone of the schedule (e.g Europe/Berlin).

        The **layers** object supports the following:

          * `end` (`pulumi.Input[str]`) - The end time of the schedule layer. If not specified, the layer does not end.
          * `id` (`pulumi.Input[str]`) - The ID of the schedule
          * `name` (`pulumi.Input[str]`) - The name of the schedule layer.
          * `restrictions` (`pulumi.Input[list]`) - A schedule layer restriction block. Restriction blocks documented below.
            * `durationSeconds` (`pulumi.Input[float]`) - The duration of the restriction in `seconds`.
            * `startDayOfWeek` (`pulumi.Input[float]`) - Number of the day when restriction starts. From 1 to 7 where 1 is Monday and 7 is Sunday.
            * `startTimeOfDay` (`pulumi.Input[str]`) - The start time in `HH:mm:ss` format.
            * `type` (`pulumi.Input[str]`) - Can be `daily_restriction` or `weekly_restriction`

          * `rotationTurnLengthSeconds` (`pulumi.Input[float]`) - The duration of each on-call shift in `seconds`.
          * `rotationVirtualStart` (`pulumi.Input[str]`) - The effective start time of the schedule layer. This can be before the start time of the schedule.
          * `start` (`pulumi.Input[str]`) - The start time of the schedule layer. This value will not be read back from the PagerDuty API because the API will always return a new `start` time, which represents the last updated time of the schedule layer.
          * `users` (`pulumi.Input[list]`) - The ordered list of users on this layer. The position of the user on the list determines their order in the layer.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["layers"] = layers
        __props__["name"] = name
        __props__["overflow"] = overflow
        __props__["time_zone"] = time_zone
        return Schedule(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
