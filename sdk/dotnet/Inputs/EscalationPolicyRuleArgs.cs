// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class EscalationPolicyRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of minutes before an unacknowledged incident escalates away from this rule.
        /// </summary>
        [Input("escalationDelayInMinutes", required: true)]
        public Input<int> EscalationDelayInMinutes { get; set; } = null!;

        /// <summary>
        /// A target ID
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("targets", required: true)]
        private InputList<Inputs.EscalationPolicyRuleTargetArgs>? _targets;
        public InputList<Inputs.EscalationPolicyRuleTargetArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.EscalationPolicyRuleTargetArgs>());
            set => _targets = value;
        }

        public EscalationPolicyRuleArgs()
        {
        }
    }
}
