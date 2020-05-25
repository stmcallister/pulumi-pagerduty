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
    public sealed class ServiceScheduledActionAt
    {
        /// <summary>
        /// Designates either the start or the end of the scheduled action. Can be `support_hours_start` or `support_hours_end`.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The type of time specification. Currently, this must be set to `named_time`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ServiceScheduledActionAt(
            string? name,

            string? type)
        {
            Name = name;
            Type = type;
        }
    }
}