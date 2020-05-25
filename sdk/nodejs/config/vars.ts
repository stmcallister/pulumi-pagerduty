// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

let __config = new pulumi.Config("pagerduty");

export let skipCredentialsValidation: boolean | undefined = <any>__config.getObject<boolean>("skipCredentialsValidation") || false;
export let token: string | undefined = __config.get("token") || utilities.getEnv("PAGERDUTY_TOKEN");