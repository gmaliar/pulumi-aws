// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Inputs
{

    public sealed class RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsArgs : Pulumi.ResourceArgs
    {
        [Input("customActions")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionArgs>? _customActions;

        /// <summary>
        /// Set of configuration blocks containing custom action definitions that are available for use by the set of `stateless rule`. See Custom Action below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionArgs> CustomActions
        {
            get => _customActions ?? (_customActions = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionArgs>());
            set => _customActions = value;
        }

        [Input("statelessRules", required: true)]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleArgs>? _statelessRules;

        /// <summary>
        /// Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleArgs> StatelessRules
        {
            get => _statelessRules ?? (_statelessRules = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleArgs>());
            set => _statelessRules = value;
        }

        public RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsArgs()
        {
        }
    }
}
