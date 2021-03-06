// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get information about a specific [extension](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Extension_Schemas/get_extension_schemas) vendor that you can use for a service (e.g: Slack, Generic Webhook, ServiceNow).
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pagerduty from "@pulumi/pagerduty";
 *
 * const webhook = pulumi.output(pagerduty.getExtensionSchema({
 *     name: "Generic V2 Webhook",
 * }, { async: true }));
 * const exampleUser = new pagerduty.User("example", {
 *     email: "howard.james@example.domain",
 *     teams: [pagerduty_team_example.id],
 * });
 * const foo = new pagerduty.EscalationPolicy("foo", {
 *     numLoops: 2,
 *     rules: [{
 *         escalationDelayInMinutes: 10,
 *         targets: [{
 *             id: exampleUser.id,
 *             type: "user",
 *         }],
 *     }],
 * });
 * const exampleService = new pagerduty.Service("example", {
 *     acknowledgementTimeout: "600",
 *     autoResolveTimeout: "14400",
 *     escalationPolicy: pagerduty_escalation_policy_example.id,
 * });
 * const slack = new pagerduty.Extension("slack", {
 *     endpointUrl: "https://generic_webhook_url/XXXXXX/BBBBBB",
 *     extensionObjects: [exampleService.id],
 *     extensionSchema: webhook.id,
 * });
 * ```
 */
export function getExtensionSchema(args: GetExtensionSchemaArgs, opts?: pulumi.InvokeOptions): Promise<GetExtensionSchemaResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("pagerduty:index/getExtensionSchema:getExtensionSchema", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getExtensionSchema.
 */
export interface GetExtensionSchemaArgs {
    /**
     * The extension name to use to find an extension vendor in the PagerDuty API.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getExtensionSchema.
 */
export interface GetExtensionSchemaResult {
    /**
     * The short name of the found extension vendor.
     */
    readonly name: string;
    /**
     * The generic service type for this extension vendor.
     */
    readonly type: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
