// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";

export interface EscalationPolicyRule {
    /**
     * The number of minutes before an unacknowledged incident escalates away from this rule.
     */
    escalationDelayInMinutes: pulumi.Input<number>;
    /**
     * A target ID
     */
    id?: pulumi.Input<string>;
    targets: pulumi.Input<pulumi.Input<inputs.EscalationPolicyRuleTarget>[]>;
}

export interface EscalationPolicyRuleTarget {
    /**
     * A target ID
     */
    id: pulumi.Input<string>;
    /**
     * Can be `user`, `schedule`, `userReference` or `scheduleReference`. Defaults to `userReference`
     */
    type?: pulumi.Input<string>;
}

export interface RulesetRuleActions {
    /**
     * Note added to the event.
     */
    annotates?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsAnnotate>[]>;
    eventActions?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsEventAction>[]>;
    /**
     * Allows you to copy important data from one event field to another. Extraction rules must use valid [RE2 regular expression syntax](https://github.com/google/re2/wiki/Syntax). Extraction objects consist of the following fields:
     */
    extractions?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsExtraction>[]>;
    /**
     * The ID of the priority applied to the event.
     */
    priorities?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsPriority>[]>;
    /**
     * The ID of the service where the event will be routed.
     */
    routes?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsRoute>[]>;
    /**
     * The [severity level](https://support.pagerduty.com/docs/rulesets#section-set-severity-with-event-rules) of the event. Can be either `info`,`error`,`warning`, or `critical`.
     */
    severities?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsSeverity>[]>;
    /**
     * Controls whether an alert is [suppressed](https://support.pagerduty.com/docs/rulesets#section-suppress-but-create-triggering-thresholds-with-event-rules) (does not create an incident).
     */
    suppresses?: pulumi.Input<pulumi.Input<inputs.RulesetRuleActionsSuppress>[]>;
}

export interface RulesetRuleActionsAnnotate {
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleActionsEventAction {
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleActionsExtraction {
    /**
     * The conditions that need to be met for the extraction to happen.
     * * *NOTE: A rule can have multiple `extraction` objects attributed to it.*
     */
    regex?: pulumi.Input<string>;
    /**
     * Field where the data is being copied from.
     */
    source?: pulumi.Input<string>;
    /**
     * Field where the data is being copied to.
     */
    target?: pulumi.Input<string>;
}

export interface RulesetRuleActionsPriority {
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleActionsRoute {
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleActionsSeverity {
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleActionsSuppress {
    /**
     * The number value of the `thresholdTimeUnit` before an incident is created.
     */
    thresholdTimeAmount?: pulumi.Input<number>;
    /**
     * The `minutes`,`hours`, or `days` that the `thresholdTimeAmount` should be measured. 
     */
    thresholdTimeUnit?: pulumi.Input<string>;
    /**
     * The number of alerts that should be suppressed.
     */
    thresholdValue?: pulumi.Input<number>;
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<boolean>;
}

export interface RulesetRuleConditions {
    /**
     * Operator to combine sub-conditions. Can be `and` or `or`.
     */
    operator?: pulumi.Input<string>;
    /**
     * List of sub-conditions that define the the condition. 
     */
    subconditions?: pulumi.Input<pulumi.Input<inputs.RulesetRuleConditionsSubcondition>[]>;
}

export interface RulesetRuleConditionsSubcondition {
    /**
     * Type of operator to apply to the sub-condition. Can be `exists`,`nexists`,`equals`,`nequals`,`contains`,`ncontains`,`matches`, or `nmatches`.
     */
    operator?: pulumi.Input<string>;
    /**
     * Parameter for the sub-condition. It requires both a `path` and `value` to be set.
     */
    parameters?: pulumi.Input<pulumi.Input<inputs.RulesetRuleConditionsSubconditionParameter>[]>;
}

export interface RulesetRuleConditionsSubconditionParameter {
    path?: pulumi.Input<string>;
    /**
     * Boolean value that indicates if the alert should be suppressed before the indicated threshold values are met.
     */
    value?: pulumi.Input<string>;
}

export interface RulesetRuleTimeFrame {
    /**
     * Values for executing the rule during a specific time period.
     */
    activeBetweens?: pulumi.Input<pulumi.Input<inputs.RulesetRuleTimeFrameActiveBetween>[]>;
    /**
     * Values for executing the rule on a recurring schedule.
     */
    scheduledWeeklies?: pulumi.Input<pulumi.Input<inputs.RulesetRuleTimeFrameScheduledWeekly>[]>;
}

export interface RulesetRuleTimeFrameActiveBetween {
    /**
     * Ending of the scheduled time when the rule should execute.  Unix timestamp in milliseconds.
     */
    endTime?: pulumi.Input<number>;
    /**
     * Time when the schedule will start. Unix timestamp in milliseconds. For example, if you have a rule with a `startTime` of `0` and a `duration` of `60,000` then that rule would be active from `00:00` to `00:01`. If the `startTime` was `3,600,000` the it would be active starting at `01:00`.
     */
    startTime?: pulumi.Input<number>;
}

export interface RulesetRuleTimeFrameScheduledWeekly {
    /**
     * Length of time the schedule will be active.  Unix timestamp in milliseconds.
     */
    duration?: pulumi.Input<number>;
    /**
     * Time when the schedule will start. Unix timestamp in milliseconds. For example, if you have a rule with a `startTime` of `0` and a `duration` of `60,000` then that rule would be active from `00:00` to `00:01`. If the `startTime` was `3,600,000` the it would be active starting at `01:00`.
     */
    startTime?: pulumi.Input<number>;
    /**
     * Timezone for the given schedule.
     */
    timezone?: pulumi.Input<string>;
    /**
     * An integer array representing which days during the week the rule executes. For example `weekdays = [1,3,7]` would execute on Monday, Wednesday and Sunday.
     */
    weekdays?: pulumi.Input<pulumi.Input<number>[]>;
}

export interface RulesetTeam {
    /**
     * The ID of the ruleset.
     */
    id: pulumi.Input<string>;
}

export interface ScheduleLayer {
    /**
     * The end time of the schedule layer. If not specified, the layer does not end.
     */
    end?: pulumi.Input<string>;
    /**
     * The ID of the schedule
     */
    id?: pulumi.Input<string>;
    /**
     * The name of the schedule layer.
     */
    name?: pulumi.Input<string>;
    /**
     * A schedule layer restriction block. Restriction blocks documented below.
     */
    restrictions?: pulumi.Input<pulumi.Input<inputs.ScheduleLayerRestriction>[]>;
    /**
     * The duration of each on-call shift in `seconds`.
     */
    rotationTurnLengthSeconds: pulumi.Input<number>;
    /**
     * The effective start time of the schedule layer. This can be before the start time of the schedule.
     */
    rotationVirtualStart: pulumi.Input<string>;
    /**
     * The start time of the schedule layer. This value will not be read back from the PagerDuty API because the API will always return a new `start` time, which represents the last updated time of the schedule layer.
     */
    start: pulumi.Input<string>;
    /**
     * The ordered list of users on this layer. The position of the user on the list determines their order in the layer.
     */
    users: pulumi.Input<pulumi.Input<string>[]>;
}

export interface ScheduleLayerRestriction {
    /**
     * The duration of the restriction in `seconds`.
     */
    durationSeconds: pulumi.Input<number>;
    /**
     * Number of the day when restriction starts. From 1 to 7 where 1 is Monday and 7 is Sunday.
     */
    startDayOfWeek?: pulumi.Input<number>;
    /**
     * The start time in `HH:mm:ss` format.
     */
    startTimeOfDay: pulumi.Input<string>;
    /**
     * Can be `dailyRestriction` or `weeklyRestriction`
     */
    type: pulumi.Input<string>;
}

export interface ServiceDependencyDependency {
    /**
     * The service that id dependent on the supporting service.
     */
    dependentServices: pulumi.Input<pulumi.Input<inputs.ServiceDependencyDependencyDependentService>[]>;
    /**
     * The service that supports  the  dependent service.
     */
    supportingServices: pulumi.Input<pulumi.Input<inputs.ServiceDependencyDependencySupportingService>[]>;
    type?: pulumi.Input<string>;
}

export interface ServiceDependencyDependencyDependentService {
    /**
     * The ID of the service dependency.
     */
    id: pulumi.Input<string>;
    type: pulumi.Input<string>;
}

export interface ServiceDependencyDependencySupportingService {
    /**
     * The ID of the service dependency.
     */
    id: pulumi.Input<string>;
    type: pulumi.Input<string>;
}

export interface ServiceIncidentUrgencyRule {
    /**
     * Incidents' urgency during support hours.
     */
    duringSupportHours?: pulumi.Input<inputs.ServiceIncidentUrgencyRuleDuringSupportHours>;
    /**
     * Incidents' urgency outside of support hours.
     */
    outsideSupportHours?: pulumi.Input<inputs.ServiceIncidentUrgencyRuleOutsideSupportHours>;
    /**
     * The type of scheduled action. Currently, this must be set to `urgencyChange`.
     */
    type: pulumi.Input<string>;
    /**
     * The urgency: `low` Notify responders (does not escalate), `high` (follows escalation rules) or `severityBased` Set's the urgency of the incident based on the severity set by the triggering monitoring tool.
     */
    urgency?: pulumi.Input<string>;
}

export interface ServiceIncidentUrgencyRuleDuringSupportHours {
    /**
     * The type of scheduled action. Currently, this must be set to `urgencyChange`.
     */
    type?: pulumi.Input<string>;
    /**
     * The urgency: `low` Notify responders (does not escalate), `high` (follows escalation rules) or `severityBased` Set's the urgency of the incident based on the severity set by the triggering monitoring tool.
     */
    urgency?: pulumi.Input<string>;
}

export interface ServiceIncidentUrgencyRuleOutsideSupportHours {
    /**
     * The type of scheduled action. Currently, this must be set to `urgencyChange`.
     */
    type?: pulumi.Input<string>;
    /**
     * The urgency: `low` Notify responders (does not escalate), `high` (follows escalation rules) or `severityBased` Set's the urgency of the incident based on the severity set by the triggering monitoring tool.
     */
    urgency?: pulumi.Input<string>;
}

export interface ServiceScheduledAction {
    /**
     * A block representing when the scheduled action will occur.
     */
    ats?: pulumi.Input<pulumi.Input<inputs.ServiceScheduledActionAt>[]>;
    /**
     * The urgency to change to: `low` (does not escalate), or `high` (follows escalation rules).
     */
    toUrgency?: pulumi.Input<string>;
    /**
     * The type of scheduled action. Currently, this must be set to `urgencyChange`.
     */
    type?: pulumi.Input<string>;
}

export interface ServiceScheduledActionAt {
    /**
     * Designates either the start or the end of the scheduled action. Can be `supportHoursStart` or `supportHoursEnd`.
     */
    name?: pulumi.Input<string>;
    /**
     * The type of time specification. Currently, this must be set to `namedTime`.
     */
    type?: pulumi.Input<string>;
}

export interface ServiceSupportHours {
    /**
     * Array of days of week as integers. `1` to `7`, `1` being
     * Monday and `7` being Sunday.
     */
    daysOfWeeks?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * The support hours' ending time of day.
     */
    endTime?: pulumi.Input<string>;
    /**
     * The support hours' starting time of day.
     */
    startTime?: pulumi.Input<string>;
    /**
     * The time zone for the support hours.
     */
    timeZone?: pulumi.Input<string>;
    /**
     * The type of scheduled action. Currently, this must be set to `urgencyChange`.
     */
    type?: pulumi.Input<string>;
}

export interface UserNotificationRuleContactMethod {
    /**
     * The id of the referenced contact method.
     */
    id: pulumi.Input<string>;
    /**
     * The type of contact method. Can be `emailContactMethod`, `phoneContactMethod`, `pushNotificationContactMethod` or `smsContactMethod`.
     */
    type: pulumi.Input<string>;
}
