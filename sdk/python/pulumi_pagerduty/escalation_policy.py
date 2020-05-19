# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class EscalationPolicy(pulumi.CustomResource):
    description: pulumi.Output[str]
    name: pulumi.Output[str]
    """
    The name of the escalation policy.
    """
    num_loops: pulumi.Output[float]
    """
    The number of times the escalation policy will repeat after reaching the end of its escalation.
    """
    rules: pulumi.Output[list]
    """
    An Escalation rule block. Escalation rules documented below.

      * `escalationDelayInMinutes` (`float`) - The number of minutes before an unacknowledged incident escalates away from this rule.
      * `id` (`str`) - A target ID
      * `targets` (`list`)
        * `id` (`str`) - A target ID
        * `type` (`str`) - Can be `user`, `schedule`, `user_reference` or `schedule_reference`. Defaults to `user_reference`
    """
    teams: pulumi.Output[list]
    """
    Teams associated with the policy. Account must have the `teams` ability to use this parameter.
    """
    def __init__(__self__, resource_name, opts=None, description=None, name=None, num_loops=None, rules=None, teams=None, __props__=None, __name__=None, __opts__=None):
        """
        An [escalation policy](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Escalation_Policies/get_escalation_policies) determines what user or schedule will be notified first, second, and so on when an incident is triggered. Escalation policies are used by one or more services.




        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the escalation policy.
        :param pulumi.Input[float] num_loops: The number of times the escalation policy will repeat after reaching the end of its escalation.
        :param pulumi.Input[list] rules: An Escalation rule block. Escalation rules documented below.
        :param pulumi.Input[list] teams: Teams associated with the policy. Account must have the `teams` ability to use this parameter.

        The **rules** object supports the following:

          * `escalationDelayInMinutes` (`pulumi.Input[float]`) - The number of minutes before an unacknowledged incident escalates away from this rule.
          * `id` (`pulumi.Input[str]`) - A target ID
          * `targets` (`pulumi.Input[list]`)
            * `id` (`pulumi.Input[str]`) - A target ID
            * `type` (`pulumi.Input[str]`) - Can be `user`, `schedule`, `user_reference` or `schedule_reference`. Defaults to `user_reference`
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
            __props__['name'] = name
            __props__['num_loops'] = num_loops
            if rules is None:
                raise TypeError("Missing required property 'rules'")
            __props__['rules'] = rules
            __props__['teams'] = teams
        super(EscalationPolicy, __self__).__init__(
            'pagerduty:index/escalationPolicy:EscalationPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, name=None, num_loops=None, rules=None, teams=None):
        """
        Get an existing EscalationPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the escalation policy.
        :param pulumi.Input[float] num_loops: The number of times the escalation policy will repeat after reaching the end of its escalation.
        :param pulumi.Input[list] rules: An Escalation rule block. Escalation rules documented below.
        :param pulumi.Input[list] teams: Teams associated with the policy. Account must have the `teams` ability to use this parameter.

        The **rules** object supports the following:

          * `escalationDelayInMinutes` (`pulumi.Input[float]`) - The number of minutes before an unacknowledged incident escalates away from this rule.
          * `id` (`pulumi.Input[str]`) - A target ID
          * `targets` (`pulumi.Input[list]`)
            * `id` (`pulumi.Input[str]`) - A target ID
            * `type` (`pulumi.Input[str]`) - Can be `user`, `schedule`, `user_reference` or `schedule_reference`. Defaults to `user_reference`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["name"] = name
        __props__["num_loops"] = num_loops
        __props__["rules"] = rules
        __props__["teams"] = teams
        return EscalationPolicy(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

