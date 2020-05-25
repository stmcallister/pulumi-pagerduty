// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pagerduty
{
    public static class GetEscalationPolicy
    {
        /// <summary>
        /// Use this data source to get information about a specific [escalation policy](https://v2.developer.pagerduty.com/v2/page/api-reference#!/Escalation_Policies/get_escalation_policies) that you can use for other PagerDuty resources.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetEscalationPolicyResult> InvokeAsync(GetEscalationPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEscalationPolicyResult>("pagerduty:index/getEscalationPolicy:getEscalationPolicy", args ?? new GetEscalationPolicyArgs(), options.WithVersion());
    }


    public sealed class GetEscalationPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name to use to find an escalation policy in the PagerDuty API.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetEscalationPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEscalationPolicyResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The short name of the found escalation policy.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetEscalationPolicyResult(
            string id,

            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
