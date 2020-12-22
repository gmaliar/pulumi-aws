// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class RuleGroupRuleActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instructs AWS WAF to allow the web request.
        /// </summary>
        [Input("allow")]
        public Input<Inputs.RuleGroupRuleActionAllowArgs>? Allow { get; set; }

        /// <summary>
        /// Instructs AWS WAF to block the web request.
        /// </summary>
        [Input("block")]
        public Input<Inputs.RuleGroupRuleActionBlockArgs>? Block { get; set; }

        /// <summary>
        /// Instructs AWS WAF to count the web request and allow it.
        /// </summary>
        [Input("count")]
        public Input<Inputs.RuleGroupRuleActionCountArgs>? Count { get; set; }

        public RuleGroupRuleActionArgs()
        {
        }
    }
}
