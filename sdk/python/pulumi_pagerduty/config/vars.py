# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

__config__ = pulumi.Config('pagerduty')

skip_credentials_validation = __config__.get('skipCredentialsValidation') or False

token = __config__.get('token') or utilities.get_env('PAGERDUTY_TOKEN')

