# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class EventRule(pulumi.CustomResource):
    action_json: pulumi.Output[str]
    """
    A list of one or more actions for each rule. Each action within the list is itself a list.
    """
    advanced_condition_json: pulumi.Output[str]
    """
    Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
    """
    catch_all: pulumi.Output[bool]
    """
    A boolean that indicates whether the rule is a catch all for the account. This field is read-only through the PagerDuty API.
    """
    condition_json: pulumi.Output[str]
    """
    Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
    """
    def __init__(__self__, resource_name, opts=None, action_json=None, advanced_condition_json=None, condition_json=None, __props__=None, __name__=None, __opts__=None):
        """
        *NOTE: The `.EventRule` resource has been deprecated in favor the the .Ruleset and .RulesetRule resources. Please use the `ruleset` based resources for working with Event Rules.*


        An [event rule](https://v2.developer.pagerduty.com/docs/global-event-rules-api) determines what happens to an event that is sent to PagerDuty by monitoring tools and other integrations.




        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action_json: A list of one or more actions for each rule. Each action within the list is itself a list.
        :param pulumi.Input[str] advanced_condition_json: Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
        :param pulumi.Input[str] condition_json: Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
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

            if action_json is None:
                raise TypeError("Missing required property 'action_json'")
            __props__['action_json'] = action_json
            __props__['advanced_condition_json'] = advanced_condition_json
            if condition_json is None:
                raise TypeError("Missing required property 'condition_json'")
            __props__['condition_json'] = condition_json
            __props__['catch_all'] = None
        super(EventRule, __self__).__init__(
            'pagerduty:index/eventRule:EventRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, action_json=None, advanced_condition_json=None, catch_all=None, condition_json=None):
        """
        Get an existing EventRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action_json: A list of one or more actions for each rule. Each action within the list is itself a list.
        :param pulumi.Input[str] advanced_condition_json: Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
        :param pulumi.Input[bool] catch_all: A boolean that indicates whether the rule is a catch all for the account. This field is read-only through the PagerDuty API.
        :param pulumi.Input[str] condition_json: Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["action_json"] = action_json
        __props__["advanced_condition_json"] = advanced_condition_json
        __props__["catch_all"] = catch_all
        __props__["condition_json"] = condition_json
        return EventRule(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

