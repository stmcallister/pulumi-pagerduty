// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty
{
    public static class GetPriority
    {
        /// <summary>
        /// Use this data source to get information about a specific [priority](https://developer.pagerduty.com/api-reference/reference/REST/openapiv3.json/paths/~1priorities/get) that you can use for other PagerDuty resources.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPriorityResult> InvokeAsync(GetPriorityArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPriorityResult>("pagerduty:index/getPriority:getPriority", args ?? new GetPriorityArgs(), options.WithVersion());
    }


    public sealed class GetPriorityArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the priority to find in the PagerDuty API.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetPriorityArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPriorityResult
    {
        /// <summary>
        /// A description of the found priority.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the found priority.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetPriorityResult(
            string description,

            string id,

            string name)
        {
            Description = description;
            Id = id;
            Name = name;
        }
    }
}
