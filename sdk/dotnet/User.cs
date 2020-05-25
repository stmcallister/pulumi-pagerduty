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
    /// A [user](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Users/get_users) is a member of a PagerDuty account that have the ability to interact with incidents and other data on the account.
    /// </summary>
    public partial class User : Pulumi.CustomResource
    {
        /// <summary>
        /// The URL of the user's avatar.
        /// </summary>
        [Output("avatarUrl")]
        public Output<string> AvatarUrl { get; private set; } = null!;

        /// <summary>
        /// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
        /// </summary>
        [Output("color")]
        public Output<string> Color { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The user's email address.
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// URL at which the entity is uniquely displayed in the Web app
        /// </summary>
        [Output("htmlUrl")]
        public Output<string> HtmlUrl { get; private set; } = null!;

        /// <summary>
        /// If true, the user has an outstanding invitation.
        /// </summary>
        [Output("invitationSent")]
        public Output<bool> InvitationSent { get; private set; } = null!;

        /// <summary>
        /// The user's title.
        /// </summary>
        [Output("jobTitle")]
        public Output<string?> JobTitle { get; private set; } = null!;

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The user role. Account must have the `read_only_users` ability to set a user as a `read_only_user`. Can be `admin`, `limited_user`, `observer`, `owner`, `read_only_user` or `user`
        /// </summary>
        [Output("role")]
        public Output<string?> Role { get; private set; } = null!;

        /// <summary>
        /// A list of teams the user should belong to. Please use `pagerduty..TeamMembership` instead.
        /// </summary>
        [Output("teams")]
        public Output<ImmutableArray<string>> Teams { get; private set; } = null!;

        /// <summary>
        /// The timezone of the user
        /// </summary>
        [Output("timeZone")]
        public Output<string> TimeZone { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("pagerduty:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("pagerduty:index/user:User", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
        /// </summary>
        [Input("color")]
        public Input<string>? Color { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// The user's title.
        /// </summary>
        [Input("jobTitle")]
        public Input<string>? JobTitle { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The user role. Account must have the `read_only_users` ability to set a user as a `read_only_user`. Can be `admin`, `limited_user`, `observer`, `owner`, `read_only_user` or `user`
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("teams")]
        private InputList<string>? _teams;

        /// <summary>
        /// A list of teams the user should belong to. Please use `pagerduty..TeamMembership` instead.
        /// </summary>
        [Obsolete(@"Use the 'pagerduty_team_membership' resource instead.")]
        public InputList<string> Teams
        {
            get => _teams ?? (_teams = new InputList<string>());
            set => _teams = value;
        }

        /// <summary>
        /// The timezone of the user
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of the user's avatar.
        /// </summary>
        [Input("avatarUrl")]
        public Input<string>? AvatarUrl { get; set; }

        /// <summary>
        /// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
        /// </summary>
        [Input("color")]
        public Input<string>? Color { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// URL at which the entity is uniquely displayed in the Web app
        /// </summary>
        [Input("htmlUrl")]
        public Input<string>? HtmlUrl { get; set; }

        /// <summary>
        /// If true, the user has an outstanding invitation.
        /// </summary>
        [Input("invitationSent")]
        public Input<bool>? InvitationSent { get; set; }

        /// <summary>
        /// The user's title.
        /// </summary>
        [Input("jobTitle")]
        public Input<string>? JobTitle { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The user role. Account must have the `read_only_users` ability to set a user as a `read_only_user`. Can be `admin`, `limited_user`, `observer`, `owner`, `read_only_user` or `user`
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("teams")]
        private InputList<string>? _teams;

        /// <summary>
        /// A list of teams the user should belong to. Please use `pagerduty..TeamMembership` instead.
        /// </summary>
        [Obsolete(@"Use the 'pagerduty_team_membership' resource instead.")]
        public InputList<string> Teams
        {
            get => _teams ?? (_teams = new InputList<string>());
            set => _teams = value;
        }

        /// <summary>
        /// The timezone of the user
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        public UserState()
        {
        }
    }
}