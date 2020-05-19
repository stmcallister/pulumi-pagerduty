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
    public sealed class EscalationPolicyRuleTarget
    {
        /// <summary>
        /// A target ID
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Can be `user`, `schedule`, `user_reference` or `schedule_reference`. Defaults to `user_reference`
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private EscalationPolicyRuleTarget(
            string id,

            string? type)
        {
            Id = id;
            Type = type;
        }
    }
}
