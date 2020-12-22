// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class RuleGroupRuleGroup
    {
        /// <summary>
        /// A configuration block that defines additional settings available to use in the rules defined in the rule group. See Rule Variables below for details.
        /// </summary>
        public readonly Outputs.RuleGroupRuleGroupRuleVariables? RuleVariables;
        /// <summary>
        /// A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.
        /// </summary>
        public readonly Outputs.RuleGroupRuleGroupRulesSource RulesSource;

        [OutputConstructor]
        private RuleGroupRuleGroup(
            Outputs.RuleGroupRuleGroupRuleVariables? ruleVariables,

            Outputs.RuleGroupRuleGroupRulesSource rulesSource)
        {
            RuleVariables = ruleVariables;
            RulesSource = rulesSource;
        }
    }
}
