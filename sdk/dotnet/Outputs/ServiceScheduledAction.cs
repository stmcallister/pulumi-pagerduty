// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Outputs
{

    [OutputType]
    public sealed class ServiceScheduledAction
    {
        /// <summary>
        /// A block representing when the scheduled action will occur.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceScheduledActionAt> Ats;
        /// <summary>
        /// The urgency to change to: `low` (does not escalate), or `high` (follows escalation rules).
        /// </summary>
        public readonly string? ToUrgency;
        /// <summary>
        /// The type of scheduled action. Currently, this must be set to `urgency_change`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ServiceScheduledAction(
            ImmutableArray<Outputs.ServiceScheduledActionAt> ats,

            string? toUrgency,

            string? type)
        {
            Ats = ats;
            ToUrgency = toUrgency;
            Type = type;
        }
    }
}
