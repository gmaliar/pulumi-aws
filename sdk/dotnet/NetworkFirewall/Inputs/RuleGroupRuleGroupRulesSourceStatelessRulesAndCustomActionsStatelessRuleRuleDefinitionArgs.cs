// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Inputs
{

    public sealed class RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<string>? _actions;

        /// <summary>
        /// Set of actions to take on a packet that matches one of the stateless rule definition's `match_attributes`. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: `aws:pass`, `aws:drop`, `aws:forward_to_sfe`.
        /// </summary>
        public InputList<string> Actions
        {
            get => _actions ?? (_actions = new InputList<string>());
            set => _actions = value;
        }

        /// <summary>
        /// A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.
        /// </summary>
        [Input("matchAttributes", required: true)]
        public Input<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesArgs> MatchAttributes { get; set; } = null!;

        public RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionArgs()
        {
        }
    }
}
