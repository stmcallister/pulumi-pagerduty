// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class EventRule extends pulumi.CustomResource {
    /**
     * Get an existing EventRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EventRuleState, opts?: pulumi.CustomResourceOptions): EventRule {
        return new EventRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'pagerduty:index/eventRule:EventRule';

    /**
     * Returns true if the given object is an instance of EventRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EventRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EventRule.__pulumiType;
    }

    /**
     * A list of one or more actions for each rule. Each action within the list is itself a list.
     */
    public readonly actionJson!: pulumi.Output<string>;
    /**
     * Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
     */
    public readonly advancedConditionJson!: pulumi.Output<string | undefined>;
    /**
     * A boolean that indicates whether the rule is a catch all for the account. This field is read-only through the PagerDuty API.
     */
    public /*out*/ readonly catchAll!: pulumi.Output<boolean>;
    /**
     * Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
     */
    public readonly conditionJson!: pulumi.Output<string>;

    /**
     * Create a EventRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EventRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EventRuleArgs | EventRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as EventRuleState | undefined;
            inputs["actionJson"] = state ? state.actionJson : undefined;
            inputs["advancedConditionJson"] = state ? state.advancedConditionJson : undefined;
            inputs["catchAll"] = state ? state.catchAll : undefined;
            inputs["conditionJson"] = state ? state.conditionJson : undefined;
        } else {
            const args = argsOrState as EventRuleArgs | undefined;
            if (!args || args.actionJson === undefined) {
                throw new Error("Missing required property 'actionJson'");
            }
            if (!args || args.conditionJson === undefined) {
                throw new Error("Missing required property 'conditionJson'");
            }
            inputs["actionJson"] = args ? args.actionJson : undefined;
            inputs["advancedConditionJson"] = args ? args.advancedConditionJson : undefined;
            inputs["conditionJson"] = args ? args.conditionJson : undefined;
            inputs["catchAll"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(EventRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EventRule resources.
 */
export interface EventRuleState {
    /**
     * A list of one or more actions for each rule. Each action within the list is itself a list.
     */
    readonly actionJson?: pulumi.Input<string>;
    /**
     * Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
     */
    readonly advancedConditionJson?: pulumi.Input<string>;
    /**
     * A boolean that indicates whether the rule is a catch all for the account. This field is read-only through the PagerDuty API.
     */
    readonly catchAll?: pulumi.Input<boolean>;
    /**
     * Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
     */
    readonly conditionJson?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EventRule resource.
 */
export interface EventRuleArgs {
    /**
     * A list of one or more actions for each rule. Each action within the list is itself a list.
     */
    readonly actionJson: pulumi.Input<string>;
    /**
     * Contains a list of specific conditions including `active-between`,`scheduled-weekly`, and `frequency-over`. The first element in the list is the label for the condition, followed by a list of values for the specific condition. For more details on these conditions see [Advanced Condition](https://v2.developer.pagerduty.com/docs/global-event-rules-api#section-advanced-condition) in the PagerDuty API documentation.
     */
    readonly advancedConditionJson?: pulumi.Input<string>;
    /**
     * Contains a list of conditions. The first field in the list is `and` or `or`, followed by a list of operators and values.
     */
    readonly conditionJson: pulumi.Input<string>;
}
