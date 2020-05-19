// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An [event rule](https://support.pagerduty.com/docs/rulesets#section-create-event-rules) allows you to set actions that should be taken on events that meet your designated rule criteria.
type RulesetRule struct {
	pulumi.CustomResourceState

	// Actions to apply to an event if the conditions match.
	Actions RulesetRuleActionsPtrOutput `pulumi:"actions"`
	// Conditions evaluated to check if an event matches this event rule. Is always empty for the catch all rule, though.
	Conditions RulesetRuleConditionsPtrOutput `pulumi:"conditions"`
	// Indicates whether the rule is disabled and would therefore not be evaluated.
	Disabled pulumi.BoolPtrOutput `pulumi:"disabled"`
	// Position/index of the rule within the ruleset.
	Position pulumi.IntPtrOutput `pulumi:"position"`
	// The ID of the ruleset that the rule belongs to.
	Ruleset pulumi.StringOutput `pulumi:"ruleset"`
	// Settings for [scheduling the rule](https://support.pagerduty.com/docs/rulesets#section-scheduled-event-rules).
	TimeFrame RulesetRuleTimeFramePtrOutput `pulumi:"timeFrame"`
}

// NewRulesetRule registers a new resource with the given unique name, arguments, and options.
func NewRulesetRule(ctx *pulumi.Context,
	name string, args *RulesetRuleArgs, opts ...pulumi.ResourceOption) (*RulesetRule, error) {
	if args == nil || args.Ruleset == nil {
		return nil, errors.New("missing required argument 'Ruleset'")
	}
	if args == nil {
		args = &RulesetRuleArgs{}
	}
	var resource RulesetRule
	err := ctx.RegisterResource("pagerduty:index/rulesetRule:RulesetRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRulesetRule gets an existing RulesetRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRulesetRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RulesetRuleState, opts ...pulumi.ResourceOption) (*RulesetRule, error) {
	var resource RulesetRule
	err := ctx.ReadResource("pagerduty:index/rulesetRule:RulesetRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RulesetRule resources.
type rulesetRuleState struct {
	// Actions to apply to an event if the conditions match.
	Actions *RulesetRuleActions `pulumi:"actions"`
	// Conditions evaluated to check if an event matches this event rule. Is always empty for the catch all rule, though.
	Conditions *RulesetRuleConditions `pulumi:"conditions"`
	// Indicates whether the rule is disabled and would therefore not be evaluated.
	Disabled *bool `pulumi:"disabled"`
	// Position/index of the rule within the ruleset.
	Position *int `pulumi:"position"`
	// The ID of the ruleset that the rule belongs to.
	Ruleset *string `pulumi:"ruleset"`
	// Settings for [scheduling the rule](https://support.pagerduty.com/docs/rulesets#section-scheduled-event-rules).
	TimeFrame *RulesetRuleTimeFrame `pulumi:"timeFrame"`
}

type RulesetRuleState struct {
	// Actions to apply to an event if the conditions match.
	Actions RulesetRuleActionsPtrInput
	// Conditions evaluated to check if an event matches this event rule. Is always empty for the catch all rule, though.
	Conditions RulesetRuleConditionsPtrInput
	// Indicates whether the rule is disabled and would therefore not be evaluated.
	Disabled pulumi.BoolPtrInput
	// Position/index of the rule within the ruleset.
	Position pulumi.IntPtrInput
	// The ID of the ruleset that the rule belongs to.
	Ruleset pulumi.StringPtrInput
	// Settings for [scheduling the rule](https://support.pagerduty.com/docs/rulesets#section-scheduled-event-rules).
	TimeFrame RulesetRuleTimeFramePtrInput
}

func (RulesetRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*rulesetRuleState)(nil)).Elem()
}

type rulesetRuleArgs struct {
	// Actions to apply to an event if the conditions match.
	Actions *RulesetRuleActions `pulumi:"actions"`
	// Conditions evaluated to check if an event matches this event rule. Is always empty for the catch all rule, though.
	Conditions *RulesetRuleConditions `pulumi:"conditions"`
	// Indicates whether the rule is disabled and would therefore not be evaluated.
	Disabled *bool `pulumi:"disabled"`
	// Position/index of the rule within the ruleset.
	Position *int `pulumi:"position"`
	// The ID of the ruleset that the rule belongs to.
	Ruleset string `pulumi:"ruleset"`
	// Settings for [scheduling the rule](https://support.pagerduty.com/docs/rulesets#section-scheduled-event-rules).
	TimeFrame *RulesetRuleTimeFrame `pulumi:"timeFrame"`
}

// The set of arguments for constructing a RulesetRule resource.
type RulesetRuleArgs struct {
	// Actions to apply to an event if the conditions match.
	Actions RulesetRuleActionsPtrInput
	// Conditions evaluated to check if an event matches this event rule. Is always empty for the catch all rule, though.
	Conditions RulesetRuleConditionsPtrInput
	// Indicates whether the rule is disabled and would therefore not be evaluated.
	Disabled pulumi.BoolPtrInput
	// Position/index of the rule within the ruleset.
	Position pulumi.IntPtrInput
	// The ID of the ruleset that the rule belongs to.
	Ruleset pulumi.StringInput
	// Settings for [scheduling the rule](https://support.pagerduty.com/docs/rulesets#section-scheduled-event-rules).
	TimeFrame RulesetRuleTimeFramePtrInput
}

func (RulesetRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rulesetRuleArgs)(nil)).Elem()
}
