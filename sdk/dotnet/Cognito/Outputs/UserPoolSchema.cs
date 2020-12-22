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
    public sealed class UserPoolSchema
    {
        /// <summary>
        /// The attribute data type. Must be one of `Boolean`, `Number`, `String`, `DateTime`.
        /// </summary>
        public readonly string AttributeDataType;
        /// <summary>
        /// Specifies whether the attribute type is developer only.
        /// </summary>
        public readonly bool? DeveloperOnlyAttribute;
        /// <summary>
        /// Specifies whether the attribute can be changed once it has been created.
        /// </summary>
        public readonly bool? Mutable;
        /// <summary>
        /// Specifies the recovery method for a user. Can be of the following: `verified_email`, `verified_phone_number`, and `admin_only`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the constraints for an attribute of the number type.
        /// </summary>
        public readonly Outputs.UserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraints;
        /// <summary>
        /// Specifies whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.
        /// </summary>
        public readonly bool? Required;
        /// <summary>
        /// -Specifies the constraints for an attribute of the string type.
        /// </summary>
        public readonly Outputs.UserPoolSchemaStringAttributeConstraints? StringAttributeConstraints;

        [OutputConstructor]
        private UserPoolSchema(
            string attributeDataType,

            bool? developerOnlyAttribute,

            bool? mutable,

            string name,

            Outputs.UserPoolSchemaNumberAttributeConstraints? numberAttributeConstraints,

            bool? required,

            Outputs.UserPoolSchemaStringAttributeConstraints? stringAttributeConstraints)
        {
            AttributeDataType = attributeDataType;
            DeveloperOnlyAttribute = developerOnlyAttribute;
            Mutable = mutable;
            Name = name;
            NumberAttributeConstraints = numberAttributeConstraints;
            Required = required;
            StringAttributeConstraints = stringAttributeConstraints;
        }
    }
}
