// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * An [extension](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Extensions/post_extensions) can be associated with a service.
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
 *     config: `{
 * 	"restrict": "any",
 * 	"notifyTypes": {
 * 			"resolve": false,
 * 			"acknowledge": false,
 * 			"assignments": false
 * 	},
 * 	"accessToken": "XXX"
 * }
 * `,
 *     endpointUrl: "https://generic_webhook_url/XXXXXX/BBBBBB",
 *     extensionObjects: [exampleService.id],
 *     extensionSchema: webhook.id,
 * });
 * ```
 */
export class Extension extends pulumi.CustomResource {
    /**
     * Get an existing Extension resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ExtensionState, opts?: pulumi.CustomResourceOptions): Extension {
        return new Extension(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'pagerduty:index/extension:Extension';

    /**
     * Returns true if the given object is an instance of Extension.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Extension {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Extension.__pulumiType;
    }

    /**
     * The configuration of the service extension as string containing plain JSON-encoded data.
     */
    public readonly config!: pulumi.Output<string | undefined>;
    /**
     * The url of the extension.  
     * **Note:** The [endpoint URL is Optional API wise](https://api-reference.pagerduty.com/#!/Extensions/post_extensions) in most cases. But in some cases it is a _Required_ parameter. For example, `pagerduty..getExtensionSchema` named `Generic V2 Webhook` doesn't accept `pagerduty..Extension` with no `endpointUrl`, but one with named `Slack` accepts.
     */
    public readonly endpointUrl!: pulumi.Output<string | undefined>;
    /**
     * This is the objects for which the extension applies (An array of service ids).
     */
    public readonly extensionObjects!: pulumi.Output<string[]>;
    /**
     * This is the schema for this extension.
     */
    public readonly extensionSchema!: pulumi.Output<string>;
    /**
     * URL at which the entity is uniquely displayed in the Web app
     */
    public /*out*/ readonly htmlUrl!: pulumi.Output<string>;
    /**
     * The name of the service extension.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a Extension resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExtensionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ExtensionArgs | ExtensionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ExtensionState | undefined;
            inputs["config"] = state ? state.config : undefined;
            inputs["endpointUrl"] = state ? state.endpointUrl : undefined;
            inputs["extensionObjects"] = state ? state.extensionObjects : undefined;
            inputs["extensionSchema"] = state ? state.extensionSchema : undefined;
            inputs["htmlUrl"] = state ? state.htmlUrl : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as ExtensionArgs | undefined;
            if (!args || args.extensionObjects === undefined) {
                throw new Error("Missing required property 'extensionObjects'");
            }
            if (!args || args.extensionSchema === undefined) {
                throw new Error("Missing required property 'extensionSchema'");
            }
            inputs["config"] = args ? args.config : undefined;
            inputs["endpointUrl"] = args ? args.endpointUrl : undefined;
            inputs["extensionObjects"] = args ? args.extensionObjects : undefined;
            inputs["extensionSchema"] = args ? args.extensionSchema : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["htmlUrl"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Extension.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Extension resources.
 */
export interface ExtensionState {
    /**
     * The configuration of the service extension as string containing plain JSON-encoded data.
     */
    readonly config?: pulumi.Input<string>;
    /**
     * The url of the extension.  
     * **Note:** The [endpoint URL is Optional API wise](https://api-reference.pagerduty.com/#!/Extensions/post_extensions) in most cases. But in some cases it is a _Required_ parameter. For example, `pagerduty..getExtensionSchema` named `Generic V2 Webhook` doesn't accept `pagerduty..Extension` with no `endpointUrl`, but one with named `Slack` accepts.
     */
    readonly endpointUrl?: pulumi.Input<string>;
    /**
     * This is the objects for which the extension applies (An array of service ids).
     */
    readonly extensionObjects?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This is the schema for this extension.
     */
    readonly extensionSchema?: pulumi.Input<string>;
    /**
     * URL at which the entity is uniquely displayed in the Web app
     */
    readonly htmlUrl?: pulumi.Input<string>;
    /**
     * The name of the service extension.
     */
    readonly name?: pulumi.Input<string>;
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Extension resource.
 */
export interface ExtensionArgs {
    /**
     * The configuration of the service extension as string containing plain JSON-encoded data.
     */
    readonly config?: pulumi.Input<string>;
    /**
     * The url of the extension.  
     * **Note:** The [endpoint URL is Optional API wise](https://api-reference.pagerduty.com/#!/Extensions/post_extensions) in most cases. But in some cases it is a _Required_ parameter. For example, `pagerduty..getExtensionSchema` named `Generic V2 Webhook` doesn't accept `pagerduty..Extension` with no `endpointUrl`, but one with named `Slack` accepts.
     */
    readonly endpointUrl?: pulumi.Input<string>;
    /**
     * This is the objects for which the extension applies (An array of service ids).
     */
    readonly extensionObjects: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This is the schema for this extension.
     */
    readonly extensionSchema: pulumi.Input<string>;
    /**
     * The name of the service extension.
     */
    readonly name?: pulumi.Input<string>;
    readonly type?: pulumi.Input<string>;
}
