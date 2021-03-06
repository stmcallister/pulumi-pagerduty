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
    public sealed class RulesetRuleActionsExtraction
    {
        /// <summary>
        /// The conditions that need to be met for the extraction to happen.
        /// * *NOTE: A rule can have multiple `extraction` objects attributed to it.*
        /// </summary>
        public readonly string? Regex;
        /// <summary>
        /// Field where the data is being copied from.
        /// </summary>
        public readonly string? Source;
        /// <summary>
        /// Field where the data is being copied to.
        /// </summary>
        public readonly string? Target;

        [OutputConstructor]
        private RulesetRuleActionsExtraction(
            string? regex,

            string? source,

            string? target)
        {
            Regex = regex;
            Source = source;
            Target = target;
        }
    }
}
