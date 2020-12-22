// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.StorageGateway.Inputs
{

    public sealed class GatewaySmbActiveDirectorySettingsGetArgs : Pulumi.ResourceArgs
    {
        [Input("activeDirectoryStatus")]
        public Input<string>? ActiveDirectoryStatus { get; set; }

        [Input("domainControllers")]
        private InputList<string>? _domainControllers;

        /// <summary>
        /// List of IPv4 addresses, NetBIOS names, or host names of your domain server.
        /// If you need to specify the port number include it after the colon (“:”). For example, `mydc.mydomain.com:389`.
        /// </summary>
        public InputList<string> DomainControllers
        {
            get => _domainControllers ?? (_domainControllers = new InputList<string>());
            set => _domainControllers = value;
        }

        /// <summary>
        /// The name of the domain that you want the gateway to join.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// The organizational unit (OU) is a container in an Active Directory that can hold users, groups,
        /// computers, and other OUs and this parameter specifies the OU that the gateway will join within the AD domain.
        /// </summary>
        [Input("organizationalUnit")]
        public Input<string>? OrganizationalUnit { get; set; }

        /// <summary>
        /// The password of the user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// Specifies the time in seconds, in which the JoinDomain operation must complete. The default is `20` seconds.
        /// </summary>
        [Input("timeoutInSeconds")]
        public Input<int>? TimeoutInSeconds { get; set; }

        /// <summary>
        /// The user name of user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public GatewaySmbActiveDirectorySettingsGetArgs()
        {
        }
    }
}
