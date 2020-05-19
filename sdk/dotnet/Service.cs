// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty
{
    /// <summary>
    /// A [service](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Services/get_services) represents something you monitor (like a web service, email service, or database service). It is a container for related incidents that associates them with escalation policies.
    /// </summary>
    public partial class Service : Pulumi.CustomResource
    {
        /// <summary>
        /// Time in seconds that an incident changes to the Triggered State after being Acknowledged. Disabled if set to the `"null"` string.
        /// </summary>
        [Output("acknowledgementTimeout")]
        public Output<string?> AcknowledgementTimeout { get; private set; } = null!;

        /// <summary>
        /// Must be one of two values. PagerDuty receives events from your monitoring systems and can then create incidents in different ways. Value "create_incidents" is default: events will create an incident that cannot be merged. Value "create_alerts_and_incidents" is the alternative: events will create an alert and then add it to a new incident, these incidents can be merged.
        /// </summary>
        [Output("alertCreation")]
        public Output<string?> AlertCreation { get; private set; } = null!;

        /// <summary>
        /// Defines how alerts on this service will be automatically grouped into incidents. Note that the alert grouping features are available only on certain plans. If not set, each alert will create a separate incident; If value is set to `time`: All alerts within a specified duration will be grouped into the same incident. This duration is set in the `alert_grouping_timeout` setting (described below). Available on Standard, Enterprise, and Event Intelligence plans; If value is set to `intelligent` - Alerts will be intelligently grouped based on a machine learning model that looks at the alert summary, timing, and the history of grouped alerts. Available on Enterprise and Event Intelligence plan.
        /// </summary>
        [Output("alertGrouping")]
        public Output<string?> AlertGrouping { get; private set; } = null!;

        /// <summary>
        /// The duration in minutes within which to automatically group incoming alerts. This setting applies only when `alert_grouping` is set to `time`. To continue grouping alerts until the incident is resolved, set this value to `0`.
        /// </summary>
        [Output("alertGroupingTimeout")]
        public Output<int?> AlertGroupingTimeout { get; private set; } = null!;

        /// <summary>
        /// Time in seconds that an incident is automatically resolved if left open for that long. Disabled if set to the `"null"` string.
        /// </summary>
        [Output("autoResolveTimeout")]
        public Output<string?> AutoResolveTimeout { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The escalation policy used by this service.
        /// </summary>
        [Output("escalationPolicy")]
        public Output<string> EscalationPolicy { get; private set; } = null!;

        [Output("htmlUrl")]
        public Output<string> HtmlUrl { get; private set; } = null!;

        [Output("incidentUrgencyRule")]
        public Output<Outputs.ServiceIncidentUrgencyRule> IncidentUrgencyRule { get; private set; } = null!;

        [Output("lastIncidentTimestamp")]
        public Output<string> LastIncidentTimestamp { get; private set; } = null!;

        /// <summary>
        /// The name of the service.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("scheduledActions")]
        public Output<ImmutableArray<Outputs.ServiceScheduledAction>> ScheduledActions { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        [Output("supportHours")]
        public Output<Outputs.ServiceSupportHours?> SupportHours { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("pagerduty:index/service:Service", name, args ?? new ServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("pagerduty:index/service:Service", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time in seconds that an incident changes to the Triggered State after being Acknowledged. Disabled if set to the `"null"` string.
        /// </summary>
        [Input("acknowledgementTimeout")]
        public Input<string>? AcknowledgementTimeout { get; set; }

        /// <summary>
        /// Must be one of two values. PagerDuty receives events from your monitoring systems and can then create incidents in different ways. Value "create_incidents" is default: events will create an incident that cannot be merged. Value "create_alerts_and_incidents" is the alternative: events will create an alert and then add it to a new incident, these incidents can be merged.
        /// </summary>
        [Input("alertCreation")]
        public Input<string>? AlertCreation { get; set; }

        /// <summary>
        /// Defines how alerts on this service will be automatically grouped into incidents. Note that the alert grouping features are available only on certain plans. If not set, each alert will create a separate incident; If value is set to `time`: All alerts within a specified duration will be grouped into the same incident. This duration is set in the `alert_grouping_timeout` setting (described below). Available on Standard, Enterprise, and Event Intelligence plans; If value is set to `intelligent` - Alerts will be intelligently grouped based on a machine learning model that looks at the alert summary, timing, and the history of grouped alerts. Available on Enterprise and Event Intelligence plan.
        /// </summary>
        [Input("alertGrouping")]
        public Input<string>? AlertGrouping { get; set; }

        /// <summary>
        /// The duration in minutes within which to automatically group incoming alerts. This setting applies only when `alert_grouping` is set to `time`. To continue grouping alerts until the incident is resolved, set this value to `0`.
        /// </summary>
        [Input("alertGroupingTimeout")]
        public Input<int>? AlertGroupingTimeout { get; set; }

        /// <summary>
        /// Time in seconds that an incident is automatically resolved if left open for that long. Disabled if set to the `"null"` string.
        /// </summary>
        [Input("autoResolveTimeout")]
        public Input<string>? AutoResolveTimeout { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The escalation policy used by this service.
        /// </summary>
        [Input("escalationPolicy", required: true)]
        public Input<string> EscalationPolicy { get; set; } = null!;

        [Input("incidentUrgencyRule")]
        public Input<Inputs.ServiceIncidentUrgencyRuleArgs>? IncidentUrgencyRule { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scheduledActions")]
        private InputList<Inputs.ServiceScheduledActionArgs>? _scheduledActions;
        public InputList<Inputs.ServiceScheduledActionArgs> ScheduledActions
        {
            get => _scheduledActions ?? (_scheduledActions = new InputList<Inputs.ServiceScheduledActionArgs>());
            set => _scheduledActions = value;
        }

        [Input("supportHours")]
        public Input<Inputs.ServiceSupportHoursArgs>? SupportHours { get; set; }

        public ServiceArgs()
        {
        }
    }

    public sealed class ServiceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time in seconds that an incident changes to the Triggered State after being Acknowledged. Disabled if set to the `"null"` string.
        /// </summary>
        [Input("acknowledgementTimeout")]
        public Input<string>? AcknowledgementTimeout { get; set; }

        /// <summary>
        /// Must be one of two values. PagerDuty receives events from your monitoring systems and can then create incidents in different ways. Value "create_incidents" is default: events will create an incident that cannot be merged. Value "create_alerts_and_incidents" is the alternative: events will create an alert and then add it to a new incident, these incidents can be merged.
        /// </summary>
        [Input("alertCreation")]
        public Input<string>? AlertCreation { get; set; }

        /// <summary>
        /// Defines how alerts on this service will be automatically grouped into incidents. Note that the alert grouping features are available only on certain plans. If not set, each alert will create a separate incident; If value is set to `time`: All alerts within a specified duration will be grouped into the same incident. This duration is set in the `alert_grouping_timeout` setting (described below). Available on Standard, Enterprise, and Event Intelligence plans; If value is set to `intelligent` - Alerts will be intelligently grouped based on a machine learning model that looks at the alert summary, timing, and the history of grouped alerts. Available on Enterprise and Event Intelligence plan.
        /// </summary>
        [Input("alertGrouping")]
        public Input<string>? AlertGrouping { get; set; }

        /// <summary>
        /// The duration in minutes within which to automatically group incoming alerts. This setting applies only when `alert_grouping` is set to `time`. To continue grouping alerts until the incident is resolved, set this value to `0`.
        /// </summary>
        [Input("alertGroupingTimeout")]
        public Input<int>? AlertGroupingTimeout { get; set; }

        /// <summary>
        /// Time in seconds that an incident is automatically resolved if left open for that long. Disabled if set to the `"null"` string.
        /// </summary>
        [Input("autoResolveTimeout")]
        public Input<string>? AutoResolveTimeout { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The escalation policy used by this service.
        /// </summary>
        [Input("escalationPolicy")]
        public Input<string>? EscalationPolicy { get; set; }

        [Input("htmlUrl")]
        public Input<string>? HtmlUrl { get; set; }

        [Input("incidentUrgencyRule")]
        public Input<Inputs.ServiceIncidentUrgencyRuleGetArgs>? IncidentUrgencyRule { get; set; }

        [Input("lastIncidentTimestamp")]
        public Input<string>? LastIncidentTimestamp { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scheduledActions")]
        private InputList<Inputs.ServiceScheduledActionGetArgs>? _scheduledActions;
        public InputList<Inputs.ServiceScheduledActionGetArgs> ScheduledActions
        {
            get => _scheduledActions ?? (_scheduledActions = new InputList<Inputs.ServiceScheduledActionGetArgs>());
            set => _scheduledActions = value;
        }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("supportHours")]
        public Input<Inputs.ServiceSupportHoursGetArgs>? SupportHours { get; set; }

        public ServiceState()
        {
        }
    }
}
