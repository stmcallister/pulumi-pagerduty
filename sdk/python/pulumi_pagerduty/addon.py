# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class Addon(pulumi.CustomResource):
    name: pulumi.Output[str]
    """
    The name of the add-on.
    """
    src: pulumi.Output[str]
    """
    The source URL to display in a frame in the PagerDuty UI. `HTTPS` is required.
    """
    def __init__(__self__, resource_name, opts=None, name=None, src=None, __props__=None, __name__=None, __opts__=None):
        """
        With [add-ons](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Add-ons/get_addons), third-party developers can write their own add-ons to PagerDuty's UI. Given a configuration containing a src parameter, that URL will be embedded in an iframe on a page that's available to users from a drop-down menu.



        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the add-on.
        :param pulumi.Input[str] src: The source URL to display in a frame in the PagerDuty UI. `HTTPS` is required.
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

            __props__['name'] = name
            if src is None:
                raise TypeError("Missing required property 'src'")
            __props__['src'] = src
        super(Addon, __self__).__init__(
            'pagerduty:index/addon:Addon',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, name=None, src=None):
        """
        Get an existing Addon resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the add-on.
        :param pulumi.Input[str] src: The source URL to display in a frame in the PagerDuty UI. `HTTPS` is required.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["name"] = name
        __props__["src"] = src
        return Addon(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

