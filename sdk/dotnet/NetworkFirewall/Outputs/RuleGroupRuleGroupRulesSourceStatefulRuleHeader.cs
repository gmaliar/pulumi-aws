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
    public sealed class RuleGroupRuleGroupRulesSourceStatefulRuleHeader
    {
        /// <summary>
        /// The destination IP address or address range to inspect for, in CIDR notation. To match with any address, specify `ANY`.
        /// </summary>
        public readonly string Destination;
        /// <summary>
        /// The destination port to inspect for. To match with any address, specify `ANY`.
        /// </summary>
        public readonly string DestinationPort;
        /// <summary>
        /// The direction of traffic flow to inspect. Valid values: `ANY` or `FORWARD`.
        /// </summary>
        public readonly string Direction;
        /// <summary>
        /// The protocol to inspect. Valid values: `IP`, `TCP`, `UDP`, `ICMP`, `HTTP`, `FTP`, `TLS`, `SMB`, `DNS`, `DCERPC`, `SSH`, `SMTP`, `IMAP`, `MSN`, `KRB5`, `IKEV2`, `TFTP`, `NTP`, `DHCP`.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// The source IP address or address range for, in CIDR notation. To match with any address, specify `ANY`.
        /// </summary>
        public readonly string Source;
        /// <summary>
        /// The source port to inspect for. To match with any address, specify `ANY`.
        /// </summary>
        public readonly string SourcePort;

        [OutputConstructor]
        private RuleGroupRuleGroupRulesSourceStatefulRuleHeader(
            string destination,

            string destinationPort,

            string direction,

            string protocol,

            string source,

            string sourcePort)
        {
            Destination = destination;
            DestinationPort = destinationPort;
            Direction = direction;
            Protocol = protocol;
            Source = source;
            SourcePort = sourcePort;
        }
    }
}
