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
    /// A [contact method](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Users/get_users_id_contact_methods) is a contact method for a PagerDuty user (email, phone or SMS).
    /// </summary>
    public partial class UserContactMethod : Pulumi.CustomResource
    {
        /// <summary>
        /// The "address" to deliver to: `email`, `phone number`, etc., depending on the type.
        /// </summary>
        [Output("address")]
        public Output<string> Address { get; private set; } = null!;

        /// <summary>
        /// If true, this phone has been blacklisted by PagerDuty and no messages will be sent to it.
        /// </summary>
        [Output("blacklisted")]
        public Output<bool> Blacklisted { get; private set; } = null!;

        /// <summary>
        /// The 1-to-3 digit country calling code. Required when using `phone_contact_method` or `sms_contact_method`.
        /// </summary>
        [Output("countryCode")]
        public Output<int?> CountryCode { get; private set; } = null!;

        /// <summary>
        /// If true, this phone is capable of receiving SMS messages.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The label (e.g., "Work", "Mobile", etc.).
        /// </summary>
        [Output("label")]
        public Output<string> Label { get; private set; } = null!;

        /// <summary>
        /// Send an abbreviated email message instead of the standard email output.
        /// </summary>
        [Output("sendShortEmail")]
        public Output<bool?> SendShortEmail { get; private set; } = null!;

        /// <summary>
        /// The contact method type. May be (`email_contact_method`, `phone_contact_method`, `sms_contact_method`, `push_notification_contact_method`).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [Output("userId")]
        public Output<string> UserId { get; private set; } = null!;


        /// <summary>
        /// Create a UserContactMethod resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserContactMethod(string name, UserContactMethodArgs args, CustomResourceOptions? options = null)
            : base("pagerduty:index/userContactMethod:UserContactMethod", name, args ?? new UserContactMethodArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserContactMethod(string name, Input<string> id, UserContactMethodState? state = null, CustomResourceOptions? options = null)
            : base("pagerduty:index/userContactMethod:UserContactMethod", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UserContactMethod resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserContactMethod Get(string name, Input<string> id, UserContactMethodState? state = null, CustomResourceOptions? options = null)
        {
            return new UserContactMethod(name, id, state, options);
        }
    }

    public sealed class UserContactMethodArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The "address" to deliver to: `email`, `phone number`, etc., depending on the type.
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// The 1-to-3 digit country calling code. Required when using `phone_contact_method` or `sms_contact_method`.
        /// </summary>
        [Input("countryCode")]
        public Input<int>? CountryCode { get; set; }

        /// <summary>
        /// The label (e.g., "Work", "Mobile", etc.).
        /// </summary>
        [Input("label", required: true)]
        public Input<string> Label { get; set; } = null!;

        /// <summary>
        /// Send an abbreviated email message instead of the standard email output.
        /// </summary>
        [Input("sendShortEmail")]
        public Input<bool>? SendShortEmail { get; set; }

        /// <summary>
        /// The contact method type. May be (`email_contact_method`, `phone_contact_method`, `sms_contact_method`, `push_notification_contact_method`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [Input("userId", required: true)]
        public Input<string> UserId { get; set; } = null!;

        public UserContactMethodArgs()
        {
        }
    }

    public sealed class UserContactMethodState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The "address" to deliver to: `email`, `phone number`, etc., depending on the type.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// If true, this phone has been blacklisted by PagerDuty and no messages will be sent to it.
        /// </summary>
        [Input("blacklisted")]
        public Input<bool>? Blacklisted { get; set; }

        /// <summary>
        /// The 1-to-3 digit country calling code. Required when using `phone_contact_method` or `sms_contact_method`.
        /// </summary>
        [Input("countryCode")]
        public Input<int>? CountryCode { get; set; }

        /// <summary>
        /// If true, this phone is capable of receiving SMS messages.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The label (e.g., "Work", "Mobile", etc.).
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// Send an abbreviated email message instead of the standard email output.
        /// </summary>
        [Input("sendShortEmail")]
        public Input<bool>? SendShortEmail { get; set; }

        /// <summary>
        /// The contact method type. May be (`email_contact_method`, `phone_contact_method`, `sms_contact_method`, `push_notification_contact_method`).
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        public UserContactMethodState()
        {
        }
    }
}