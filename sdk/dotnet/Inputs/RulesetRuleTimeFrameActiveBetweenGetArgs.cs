// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class RulesetRuleTimeFrameActiveBetweenGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Ending of the scheduled time when the rule should execute.  Unix timestamp in milliseconds.
        /// </summary>
        [Input("endTime")]
        public Input<int>? EndTime { get; set; }

        /// <summary>
        /// Time when the schedule will start. Unix timestamp in milliseconds. For example, if you have a rule with a `start_time` of `0` and a `duration` of `60,000` then that rule would be active from `00:00` to `00:01`. If the `start_time` was `3,600,000` the it would be active starting at `01:00`.
        /// </summary>
        [Input("startTime")]
        public Input<int>? StartTime { get; set; }

        public RulesetRuleTimeFrameActiveBetweenGetArgs()
        {
        }
    }
}