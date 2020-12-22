// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class RuleGroupRuleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action that AWS WAF should take on a web request when it matches the rule's statement. Settings at the `aws.wafv2.WebAcl` level can override the rule action setting. See Action below for details.
        /// </summary>
        [Input("action", required: true)]
        public Input<Inputs.RuleGroupRuleActionGetArgs> Action { get; set; } = null!;

        /// <summary>
        /// A friendly name of the rule.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// If you define more than one Rule in a WebACL, AWS WAF evaluates each request against the `rules` in order based on the value of `priority`. AWS WAF processes rules with lower priority first.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// The AWS WAF processing statement for the rule, for example `byte_match_statement` or `geo_match_statement`. See Statement below for details.
        /// </summary>
        [Input("statement", required: true)]
        public Input<Inputs.RuleGroupRuleStatementGetArgs> Statement { get; set; } = null!;

        /// <summary>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.
        /// </summary>
        [Input("visibilityConfig", required: true)]
        public Input<Inputs.RuleGroupRuleVisibilityConfigGetArgs> VisibilityConfig { get; set; } = null!;

        public RuleGroupRuleGetArgs()
        {
        }
    }
}
