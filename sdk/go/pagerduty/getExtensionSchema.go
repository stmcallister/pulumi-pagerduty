// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to get information about a specific [extension][1] vendor that you can use for a service (e.g: Slack, Generic Webhook, ServiceNow).
func GetExtensionSchema(ctx *pulumi.Context, args *GetExtensionSchemaArgs, opts ...pulumi.InvokeOption) (*GetExtensionSchemaResult, error) {
	var rv GetExtensionSchemaResult
	err := ctx.Invoke("pagerduty:index/getExtensionSchema:getExtensionSchema", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getExtensionSchema.
type GetExtensionSchemaArgs struct {
	// The extension name to use to find an extension vendor in the PagerDuty API.
	Name string `pulumi:"name"`
}

// A collection of values returned by getExtensionSchema.
type GetExtensionSchemaResult struct {
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The short name of the found extension vendor.
	Name string `pulumi:"name"`
	// The generic service type for this extension vendor.
	Type string `pulumi:"type"`
}
