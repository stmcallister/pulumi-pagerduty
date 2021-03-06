// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A [user](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Users/get_users) is a member of a PagerDuty account that have the ability to interact with incidents and other data on the account.
type User struct {
	pulumi.CustomResourceState

	// The URL of the user's avatar.
	AvatarUrl pulumi.StringOutput `pulumi:"avatarUrl"`
	// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
	Color       pulumi.StringOutput    `pulumi:"color"`
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The user's email address.
	Email pulumi.StringOutput `pulumi:"email"`
	// URL at which the entity is uniquely displayed in the Web app
	HtmlUrl pulumi.StringOutput `pulumi:"htmlUrl"`
	// If true, the user has an outstanding invitation.
	InvitationSent pulumi.BoolOutput `pulumi:"invitationSent"`
	// The user's title.
	JobTitle pulumi.StringPtrOutput `pulumi:"jobTitle"`
	// The name of the user.
	Name pulumi.StringOutput `pulumi:"name"`
	// The user role. Account must have the `readOnlyUsers` ability to set a user as a `readOnlyUser`. Can be `admin`, `limitedUser`, `observer`, `owner`, `readOnlyUser` or `user`
	Role pulumi.StringPtrOutput `pulumi:"role"`
	// A list of teams the user should belong to. Please use `.TeamMembership` instead.
	//
	// Deprecated: Use the 'pagerduty_team_membership' resource instead.
	Teams pulumi.StringArrayOutput `pulumi:"teams"`
	// The timezone of the user
	TimeZone pulumi.StringOutput `pulumi:"timeZone"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil || args.Email == nil {
		return nil, errors.New("missing required argument 'Email'")
	}
	if args == nil {
		args = &UserArgs{}
	}
	var resource User
	err := ctx.RegisterResource("pagerduty:index/user:User", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserState, opts ...pulumi.ResourceOption) (*User, error) {
	var resource User
	err := ctx.ReadResource("pagerduty:index/user:User", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering User resources.
type userState struct {
	// The URL of the user's avatar.
	AvatarUrl *string `pulumi:"avatarUrl"`
	// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
	Color       *string `pulumi:"color"`
	Description *string `pulumi:"description"`
	// The user's email address.
	Email *string `pulumi:"email"`
	// URL at which the entity is uniquely displayed in the Web app
	HtmlUrl *string `pulumi:"htmlUrl"`
	// If true, the user has an outstanding invitation.
	InvitationSent *bool `pulumi:"invitationSent"`
	// The user's title.
	JobTitle *string `pulumi:"jobTitle"`
	// The name of the user.
	Name *string `pulumi:"name"`
	// The user role. Account must have the `readOnlyUsers` ability to set a user as a `readOnlyUser`. Can be `admin`, `limitedUser`, `observer`, `owner`, `readOnlyUser` or `user`
	Role *string `pulumi:"role"`
	// A list of teams the user should belong to. Please use `.TeamMembership` instead.
	//
	// Deprecated: Use the 'pagerduty_team_membership' resource instead.
	Teams []string `pulumi:"teams"`
	// The timezone of the user
	TimeZone *string `pulumi:"timeZone"`
}

type UserState struct {
	// The URL of the user's avatar.
	AvatarUrl pulumi.StringPtrInput
	// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
	Color       pulumi.StringPtrInput
	Description pulumi.StringPtrInput
	// The user's email address.
	Email pulumi.StringPtrInput
	// URL at which the entity is uniquely displayed in the Web app
	HtmlUrl pulumi.StringPtrInput
	// If true, the user has an outstanding invitation.
	InvitationSent pulumi.BoolPtrInput
	// The user's title.
	JobTitle pulumi.StringPtrInput
	// The name of the user.
	Name pulumi.StringPtrInput
	// The user role. Account must have the `readOnlyUsers` ability to set a user as a `readOnlyUser`. Can be `admin`, `limitedUser`, `observer`, `owner`, `readOnlyUser` or `user`
	Role pulumi.StringPtrInput
	// A list of teams the user should belong to. Please use `.TeamMembership` instead.
	//
	// Deprecated: Use the 'pagerduty_team_membership' resource instead.
	Teams pulumi.StringArrayInput
	// The timezone of the user
	TimeZone pulumi.StringPtrInput
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
	Color       *string `pulumi:"color"`
	Description *string `pulumi:"description"`
	// The user's email address.
	Email string `pulumi:"email"`
	// The user's title.
	JobTitle *string `pulumi:"jobTitle"`
	// The name of the user.
	Name *string `pulumi:"name"`
	// The user role. Account must have the `readOnlyUsers` ability to set a user as a `readOnlyUser`. Can be `admin`, `limitedUser`, `observer`, `owner`, `readOnlyUser` or `user`
	Role *string `pulumi:"role"`
	// A list of teams the user should belong to. Please use `.TeamMembership` instead.
	//
	// Deprecated: Use the 'pagerduty_team_membership' resource instead.
	Teams []string `pulumi:"teams"`
	// The timezone of the user
	TimeZone *string `pulumi:"timeZone"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	// The schedule color for the user. Valid options are purple, red, green, blue, teal, orange, brown, turquoise, dark-slate-blue, cayenne, orange-red, dark-orchid, dark-slate-grey, lime, dark-magenta, lime-green, midnight-blue, deep-pink, dark-green, dark-orange, dark-cyan, darkolive-green, dark-slate-gray, grey20, firebrick, maroon, crimson, dark-red, dark-goldenrod, chocolate, medium-violet-red, sea-green, olivedrab, forest-green, dark-olive-green, blue-violet, royal-blue, indigo, slate-blue, saddle-brown, or steel-blue.
	Color       pulumi.StringPtrInput
	Description pulumi.StringPtrInput
	// The user's email address.
	Email pulumi.StringInput
	// The user's title.
	JobTitle pulumi.StringPtrInput
	// The name of the user.
	Name pulumi.StringPtrInput
	// The user role. Account must have the `readOnlyUsers` ability to set a user as a `readOnlyUser`. Can be `admin`, `limitedUser`, `observer`, `owner`, `readOnlyUser` or `user`
	Role pulumi.StringPtrInput
	// A list of teams the user should belong to. Please use `.TeamMembership` instead.
	//
	// Deprecated: Use the 'pagerduty_team_membership' resource instead.
	Teams pulumi.StringArrayInput
	// The timezone of the user
	TimeZone pulumi.StringPtrInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}
