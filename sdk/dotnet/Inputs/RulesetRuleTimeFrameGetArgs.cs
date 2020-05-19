// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class RulesetRuleTimeFrameGetArgs : Pulumi.ResourceArgs
    {
        [Input("activeBetweens")]
        private InputList<Inputs.RulesetRuleTimeFrameActiveBetweenGetArgs>? _activeBetweens;

        /// <summary>
        /// Values for executing the rule during a specific time period.
        /// </summary>
        public InputList<Inputs.RulesetRuleTimeFrameActiveBetweenGetArgs> ActiveBetweens
        {
            get => _activeBetweens ?? (_activeBetweens = new InputList<Inputs.RulesetRuleTimeFrameActiveBetweenGetArgs>());
            set => _activeBetweens = value;
        }

        [Input("scheduledWeeklies")]
        private InputList<Inputs.RulesetRuleTimeFrameScheduledWeeklyGetArgs>? _scheduledWeeklies;

        /// <summary>
        /// Values for executing the rule on a recurring schedule.
        /// </summary>
        public InputList<Inputs.RulesetRuleTimeFrameScheduledWeeklyGetArgs> ScheduledWeeklies
        {
            get => _scheduledWeeklies ?? (_scheduledWeeklies = new InputList<Inputs.RulesetRuleTimeFrameScheduledWeeklyGetArgs>());
            set => _scheduledWeeklies = value;
        }

        public RulesetRuleTimeFrameGetArgs()
        {
        }
    }
}
