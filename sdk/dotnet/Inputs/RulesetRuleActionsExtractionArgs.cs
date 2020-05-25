// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class RulesetRuleActionsExtractionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The conditions that need to be met for the extraction to happen.
        /// * *NOTE: A rule can have multiple `extraction` objects attributed to it.*
        /// </summary>
        [Input("regex")]
        public Input<string>? Regex { get; set; }

        /// <summary>
        /// Field where the data is being copied from.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// Field where the data is being copied to.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        public RulesetRuleActionsExtractionArgs()
        {
        }
    }
}