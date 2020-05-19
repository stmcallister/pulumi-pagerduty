// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class ServiceScheduledActionGetArgs : Pulumi.ResourceArgs
    {
        [Input("ats")]
        private InputList<Inputs.ServiceScheduledActionAtGetArgs>? _ats;

        /// <summary>
        /// A block representing when the scheduled action will occur.
        /// </summary>
        public InputList<Inputs.ServiceScheduledActionAtGetArgs> Ats
        {
            get => _ats ?? (_ats = new InputList<Inputs.ServiceScheduledActionAtGetArgs>());
            set => _ats = value;
        }

        /// <summary>
        /// The urgency to change to: `low` (does not escalate), or `high` (follows escalation rules).
        /// </summary>
        [Input("toUrgency")]
        public Input<string>? ToUrgency { get; set; }

        /// <summary>
        /// The type of scheduled action. Currently, this must be set to `urgency_change`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ServiceScheduledActionGetArgs()
        {
        }
    }
}
