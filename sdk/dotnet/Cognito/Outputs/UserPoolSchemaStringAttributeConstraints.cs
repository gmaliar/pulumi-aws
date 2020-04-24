// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Outputs
{

    [OutputType]
    public sealed class UserPoolSchemaStringAttributeConstraints
    {
        /// <summary>
        /// The maximum length of an attribute value of the string type.
        /// </summary>
        public readonly string? MaxLength;
        /// <summary>
        /// The minimum length of an attribute value of the string type.
        /// </summary>
        public readonly string? MinLength;

        [OutputConstructor]
        private UserPoolSchemaStringAttributeConstraints(
            string? maxLength,

            string? minLength)
        {
            MaxLength = maxLength;
            MinLength = minLength;
        }
    }
}