// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Inputs
{

    public sealed class RuleGroupRuleGroupRulesSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A configuration block containing **stateful** inspection criteria for a domain list rule group. See Rules Source List below for details.
        /// </summary>
        [Input("rulesSourceList")]
        public Input<Inputs.RuleGroupRuleGroupRulesSourceRulesSourceListArgs>? RulesSourceList { get; set; }

        /// <summary>
        /// The fully qualified name of a file in an S3 bucket that contains Suricata compatible intrusion preventions system (IPS) rules or the Suricata rules as a string. These rules contain **stateful** inspection criteria and the action to take for traffic that matches the criteria.
        /// </summary>
        [Input("rulesString")]
        public Input<string>? RulesString { get; set; }

        [Input("statefulRules")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatefulRuleArgs>? _statefulRules;

        /// <summary>
        /// Set of configuration blocks containing **stateful** inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatefulRuleArgs> StatefulRules
        {
            get => _statefulRules ?? (_statefulRules = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatefulRuleArgs>());
            set => _statefulRules = value;
        }

        /// <summary>
        /// A configuration block containing **stateless** inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.
        /// </summary>
        [Input("statelessRulesAndCustomActions")]
        public Input<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsArgs>? StatelessRulesAndCustomActions { get; set; }

        public RuleGroupRuleGroupRulesSourceArgs()
        {
        }
    }
}
