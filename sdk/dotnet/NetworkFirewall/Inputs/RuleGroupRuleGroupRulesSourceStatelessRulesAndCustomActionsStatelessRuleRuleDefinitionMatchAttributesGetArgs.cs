// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.NetworkFirewall.Inputs
{

    public sealed class RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesGetArgs : Pulumi.ResourceArgs
    {
        [Input("destinationPorts")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPortGetArgs>? _destinationPorts;

        /// <summary>
        /// Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPortGetArgs> DestinationPorts
        {
            get => _destinationPorts ?? (_destinationPorts = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPortGetArgs>());
            set => _destinationPorts = value;
        }

        [Input("destinations")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationGetArgs>? _destinations;

        /// <summary>
        /// Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationGetArgs> Destinations
        {
            get => _destinations ?? (_destinations = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationGetArgs>());
            set => _destinations = value;
        }

        [Input("protocols")]
        private InputList<int>? _protocols;

        /// <summary>
        /// Set of protocols to inspect for, specified using the protocol's assigned internet protocol number (IANA). If not specified, this matches with any protocol.
        /// </summary>
        public InputList<int> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<int>());
            set => _protocols = value;
        }

        [Input("sourcePorts")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePortGetArgs>? _sourcePorts;

        /// <summary>
        /// Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePortGetArgs> SourcePorts
        {
            get => _sourcePorts ?? (_sourcePorts = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePortGetArgs>());
            set => _sourcePorts = value;
        }

        [Input("sources")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourceGetArgs>? _sources;

        /// <summary>
        /// Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourceGetArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourceGetArgs>());
            set => _sources = value;
        }

        [Input("tcpFlags")]
        private InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlagGetArgs>? _tcpFlags;

        /// <summary>
        /// Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlagGetArgs> TcpFlags
        {
            get => _tcpFlags ?? (_tcpFlags = new InputList<Inputs.RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlagGetArgs>());
            set => _tcpFlags = value;
        }

        public RuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesGetArgs()
        {
        }
    }
}
