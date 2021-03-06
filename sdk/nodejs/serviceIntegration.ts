// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * A [service integration](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Services/post_services_id_integrations) is an integration that belongs to a service.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pagerduty from "@pulumi/pagerduty";
 *
 * const exampleUser = new pagerduty.User("example", {
 *     email: "125.greenholt.earline@graham.name",
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
 * const exampleServiceIntegration = new pagerduty.ServiceIntegration("example", {
 *     service: exampleService.id,
 *     type: "genericEventsApiInboundIntegration",
 * });
 * const datadogVendor = pulumi.output(pagerduty.getVendor({
 *     name: "Datadog",
 * }, { async: true }));
 * const datadogServiceIntegration = new pagerduty.ServiceIntegration("datadog", {
 *     service: exampleService.id,
 *     vendor: datadogVendor.id,
 * });
 * const cloudwatchVendor = pulumi.output(pagerduty.getVendor({
 *     name: "Cloudwatch",
 * }, { async: true }));
 * const cloudwatchServiceIntegration = new pagerduty.ServiceIntegration("cloudwatch", {
 *     service: exampleService.id,
 *     vendor: cloudwatchVendor.id,
 * });
 * ```
 */
export class ServiceIntegration extends pulumi.CustomResource {
    /**
     * Get an existing ServiceIntegration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceIntegrationState, opts?: pulumi.CustomResourceOptions): ServiceIntegration {
        return new ServiceIntegration(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'pagerduty:index/serviceIntegration:ServiceIntegration';

    /**
     * Returns true if the given object is an instance of ServiceIntegration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceIntegration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceIntegration.__pulumiType;
    }

    /**
     * URL at which the entity is uniquely displayed in the Web app
     */
    public /*out*/ readonly htmlUrl!: pulumi.Output<string>;
    /**
     * This is the unique fully-qualified email address used for routing emails to this integration for processing.
     */
    public readonly integrationEmail!: pulumi.Output<string>;
    /**
     * This is the unique key used to route events to this integration when received via the PagerDuty Events API.
     */
    public readonly integrationKey!: pulumi.Output<string>;
    /**
     * The name of the service integration.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the service the integration should belong to.
     */
    public readonly service!: pulumi.Output<string>;
    /**
     * The service type. Can be:
     * `awsCloudwatchInboundIntegration`,
     * `cloudkickInboundIntegration`,
     * `eventTransformerApiInboundIntegration`,
     * `eventsApiV2InboundIntegration` (requires service `alertCreation` to be `createAlertsAndIncidents`),
     * `genericEmailInboundIntegration`,
     * `genericEventsApiInboundIntegration`,
     * `keynoteInboundIntegration`,
     * `nagiosInboundIntegration`,
     * `pingdomInboundIntegration`or `sqlMonitorInboundIntegration`.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * The ID of the vendor the integration should integrate with (e.g Datadog or Amazon Cloudwatch).
     */
    public readonly vendor!: pulumi.Output<string>;

    /**
     * Create a ServiceIntegration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceIntegrationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceIntegrationArgs | ServiceIntegrationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceIntegrationState | undefined;
            inputs["htmlUrl"] = state ? state.htmlUrl : undefined;
            inputs["integrationEmail"] = state ? state.integrationEmail : undefined;
            inputs["integrationKey"] = state ? state.integrationKey : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["service"] = state ? state.service : undefined;
            inputs["type"] = state ? state.type : undefined;
            inputs["vendor"] = state ? state.vendor : undefined;
        } else {
            const args = argsOrState as ServiceIntegrationArgs | undefined;
            if (!args || args.service === undefined) {
                throw new Error("Missing required property 'service'");
            }
            inputs["integrationEmail"] = args ? args.integrationEmail : undefined;
            inputs["integrationKey"] = args ? args.integrationKey : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["service"] = args ? args.service : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["vendor"] = args ? args.vendor : undefined;
            inputs["htmlUrl"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ServiceIntegration.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceIntegration resources.
 */
export interface ServiceIntegrationState {
    /**
     * URL at which the entity is uniquely displayed in the Web app
     */
    readonly htmlUrl?: pulumi.Input<string>;
    /**
     * This is the unique fully-qualified email address used for routing emails to this integration for processing.
     */
    readonly integrationEmail?: pulumi.Input<string>;
    /**
     * This is the unique key used to route events to this integration when received via the PagerDuty Events API.
     */
    readonly integrationKey?: pulumi.Input<string>;
    /**
     * The name of the service integration.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the service the integration should belong to.
     */
    readonly service?: pulumi.Input<string>;
    /**
     * The service type. Can be:
     * `awsCloudwatchInboundIntegration`,
     * `cloudkickInboundIntegration`,
     * `eventTransformerApiInboundIntegration`,
     * `eventsApiV2InboundIntegration` (requires service `alertCreation` to be `createAlertsAndIncidents`),
     * `genericEmailInboundIntegration`,
     * `genericEventsApiInboundIntegration`,
     * `keynoteInboundIntegration`,
     * `nagiosInboundIntegration`,
     * `pingdomInboundIntegration`or `sqlMonitorInboundIntegration`.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * The ID of the vendor the integration should integrate with (e.g Datadog or Amazon Cloudwatch).
     */
    readonly vendor?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceIntegration resource.
 */
export interface ServiceIntegrationArgs {
    /**
     * This is the unique fully-qualified email address used for routing emails to this integration for processing.
     */
    readonly integrationEmail?: pulumi.Input<string>;
    /**
     * This is the unique key used to route events to this integration when received via the PagerDuty Events API.
     */
    readonly integrationKey?: pulumi.Input<string>;
    /**
     * The name of the service integration.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the service the integration should belong to.
     */
    readonly service: pulumi.Input<string>;
    /**
     * The service type. Can be:
     * `awsCloudwatchInboundIntegration`,
     * `cloudkickInboundIntegration`,
     * `eventTransformerApiInboundIntegration`,
     * `eventsApiV2InboundIntegration` (requires service `alertCreation` to be `createAlertsAndIncidents`),
     * `genericEmailInboundIntegration`,
     * `genericEventsApiInboundIntegration`,
     * `keynoteInboundIntegration`,
     * `nagiosInboundIntegration`,
     * `pingdomInboundIntegration`or `sqlMonitorInboundIntegration`.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * The ID of the vendor the integration should integrate with (e.g Datadog or Amazon Cloudwatch).
     */
    readonly vendor?: pulumi.Input<string>;
}
