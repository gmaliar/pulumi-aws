// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Inputs
{

    public sealed class UserPoolAccountRecoverySettingRecoveryMechanismArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the recovery method for a user. Can be of the following: `verified_email`, `verified_phone_number`, and `admin_only`.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// A positive integer specifying priority of a method with 1 being the highest priority.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        public UserPoolAccountRecoverySettingRecoveryMechanismArgs()
        {
        }
    }
}
