// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get information about a specific [team][1] that you can use for other PagerDuty resources.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pagerduty from "@pulumi/pagerduty";
 * 
 * const me = pagerduty.getUser({
 *     email: "me@example.com",
 * });
 * const devops = pagerduty.getTeam({
 *     name: "devops",
 * });
 * const foo = new pagerduty.EscalationPolicy("foo", {
 *     numLoops: 2,
 *     rules: [{
 *         escalationDelayInMinutes: 10,
 *         targets: [{
 *             id: me.id,
 *             type: "user",
 *         }],
 *     }],
 *     teams: [devops.id],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-pagerduty/blob/master/website/docs/d/team.html.markdown.
 */
export function getTeam(args: GetTeamArgs, opts?: pulumi.InvokeOptions): Promise<GetTeamResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("pagerduty:index/getTeam:getTeam", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getTeam.
 */
export interface GetTeamArgs {
    /**
     * The name of the team to find in the PagerDuty API.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getTeam.
 */
export interface GetTeamResult {
    /**
     * A description of the found team.
     */
    readonly description: string;
    /**
     * The name of the found team.
     */
    readonly name: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
