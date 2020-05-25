// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty.Inputs
{

    public sealed class RulesetRuleActionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("annotates")]
        private InputList<Inputs.RulesetRuleActionsAnnotateGetArgs>? _annotates;

        /// <summary>
        /// Note added to the event.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsAnnotateGetArgs> Annotates
        {
            get => _annotates ?? (_annotates = new InputList<Inputs.RulesetRuleActionsAnnotateGetArgs>());
            set => _annotates = value;
        }

        [Input("eventActions")]
        private InputList<Inputs.RulesetRuleActionsEventActionGetArgs>? _eventActions;
        public InputList<Inputs.RulesetRuleActionsEventActionGetArgs> EventActions
        {
            get => _eventActions ?? (_eventActions = new InputList<Inputs.RulesetRuleActionsEventActionGetArgs>());
            set => _eventActions = value;
        }

        [Input("extractions")]
        private InputList<Inputs.RulesetRuleActionsExtractionGetArgs>? _extractions;

        /// <summary>
        /// Allows you to copy important data from one event field to another. Extraction rules must use valid [RE2 regular expression syntax](https://github.com/google/re2/wiki/Syntax). Extraction objects consist of the following fields:
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsExtractionGetArgs> Extractions
        {
            get => _extractions ?? (_extractions = new InputList<Inputs.RulesetRuleActionsExtractionGetArgs>());
            set => _extractions = value;
        }

        [Input("priorities")]
        private InputList<Inputs.RulesetRuleActionsPriorityGetArgs>? _priorities;

        /// <summary>
        /// The ID of the priority applied to the event.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsPriorityGetArgs> Priorities
        {
            get => _priorities ?? (_priorities = new InputList<Inputs.RulesetRuleActionsPriorityGetArgs>());
            set => _priorities = value;
        }

        [Input("routes")]
        private InputList<Inputs.RulesetRuleActionsRouteGetArgs>? _routes;

        /// <summary>
        /// The ID of the service where the event will be routed.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsRouteGetArgs> Routes
        {
            get => _routes ?? (_routes = new InputList<Inputs.RulesetRuleActionsRouteGetArgs>());
            set => _routes = value;
        }

        [Input("severities")]
        private InputList<Inputs.RulesetRuleActionsSeverityGetArgs>? _severities;

        /// <summary>
        /// The [severity level](https://support.pagerduty.com/docs/rulesets#section-set-severity-with-event-rules) of the event. Can be either `info`,`error`,`warning`, or `critical`.
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsSeverityGetArgs> Severities
        {
            get => _severities ?? (_severities = new InputList<Inputs.RulesetRuleActionsSeverityGetArgs>());
            set => _severities = value;
        }

        [Input("suppresses")]
        private InputList<Inputs.RulesetRuleActionsSuppressGetArgs>? _suppresses;

        /// <summary>
        /// Controls whether an alert is [suppressed](https://support.pagerduty.com/docs/rulesets#section-suppress-but-create-triggering-thresholds-with-event-rules) (does not create an incident).
        /// </summary>
        public InputList<Inputs.RulesetRuleActionsSuppressGetArgs> Suppresses
        {
            get => _suppresses ?? (_suppresses = new InputList<Inputs.RulesetRuleActionsSuppressGetArgs>());
            set => _suppresses = value;
        }

        public RulesetRuleActionsGetArgs()
        {
        }
    }
}
