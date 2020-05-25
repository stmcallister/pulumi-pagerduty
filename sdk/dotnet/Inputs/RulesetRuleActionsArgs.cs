// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class RulesetRuleActionsArgs : Pulumi.ResourceArgs
    {
        [Input("annotates")]
        private InputList<Inputs.RulesetRuleActionsAnnotateArgs>? _annotates;

        /// <summary>
        /// Note added to the event.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsAnnotateArgs> Annotates
        {
            get => _annotates ?? (_annotates = new InputList<Inputs.RulesetRuleActionsAnnotateArgs>());
            set => _annotates = value;
        }

        [Input("eventActions")]
        private InputList<Inputs.RulesetRuleActionsEventActionArgs>? _eventActions;
        public InputList<Inputs.RulesetRuleActionsEventActionArgs> EventActions
        {
            get => _eventActions ?? (_eventActions = new InputList<Inputs.RulesetRuleActionsEventActionArgs>());
            set => _eventActions = value;
        }

        [Input("extractions")]
        private InputList<Inputs.RulesetRuleActionsExtractionArgs>? _extractions;

        /// <summary>
        /// Allows you to copy important data from one event field to another. Extraction rules must use valid [RE2 regular expression syntax](https://github.com/google/re2/wiki/Syntax). Extraction objects consist of the following fields:
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsExtractionArgs> Extractions
        {
            get => _extractions ?? (_extractions = new InputList<Inputs.RulesetRuleActionsExtractionArgs>());
            set => _extractions = value;
        }

        [Input("priorities")]
        private InputList<Inputs.RulesetRuleActionsPriorityArgs>? _priorities;

        /// <summary>
        /// The ID of the priority applied to the event.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsPriorityArgs> Priorities
        {
            get => _priorities ?? (_priorities = new InputList<Inputs.RulesetRuleActionsPriorityArgs>());
            set => _priorities = value;
        }

        [Input("routes")]
        private InputList<Inputs.RulesetRuleActionsRouteArgs>? _routes;

        /// <summary>
        /// The ID of the service where the event will be routed.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsRouteArgs> Routes
        {
            get => _routes ?? (_routes = new InputList<Inputs.RulesetRuleActionsRouteArgs>());
            set => _routes = value;
        }

        [Input("severities")]
        private InputList<Inputs.RulesetRuleActionsSeverityArgs>? _severities;

        /// <summary>
        /// The [severity level](https://support.pagerduty.com/docs/rulesets#section-set-severity-with-event-rules) of the event. Can be either `info`,`error`,`warning`, or `critical`.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsSeverityArgs> Severities
        {
            get => _severities ?? (_severities = new InputList<Inputs.RulesetRuleActionsSeverityArgs>());
            set => _severities = value;
        }

        [Input("suppresses")]
        private InputList<Inputs.RulesetRuleActionsSuppressArgs>? _suppresses;

        /// <summary>
        /// Controls whether an alert is [suppressed](https://support.pagerduty.com/docs/rulesets#section-suppress-but-create-triggering-thresholds-with-event-rules) (does not create an incident).
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsSuppressArgs> Suppresses
        {
            get => _suppresses ?? (_suppresses = new InputList<Inputs.RulesetRuleActionsSuppressArgs>());
            set => _suppresses = value;
        }

        public RulesetRuleActionsArgs()
        {
        }
    }
}
