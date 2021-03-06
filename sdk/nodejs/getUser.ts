// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get information about a specific [user](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Users/get_users) that you can use for other PagerDuty resources.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pagerduty from "@pulumi/pagerduty";
 *
 * const me = pulumi.output(pagerduty.getUser({
 *     email: "me@example.com",
 * }, { async: true }));
 * const foo = new pagerduty.EscalationPolicy("foo", {
 *     numLoops: 2,
 *     rules: [{
 *         escalationDelayInMinutes: 10,
 *         targets: [{
 *             id: me.id,
 *             type: "user",
 *         }],
 *     }],
 * });
 * ```
 */
export function getUser(args: GetUserArgs, opts?: pulumi.InvokeOptions): Promise<GetUserResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("pagerduty:index/getUser:getUser", {
        "email": args.email,
    }, opts);
}

/**
 * A collection of arguments for invoking getUser.
 */
export interface GetUserArgs {
    /**
     * The email to use to find a user in the PagerDuty API.
     */
    readonly email: string;
}

/**
 * A collection of values returned by getUser.
 */
export interface GetUserResult {
    readonly email: string;
    /**
     * The short name of the found user.
     */
    readonly name: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
