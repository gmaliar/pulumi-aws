// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Signer.Outputs
{

    [OutputType]
    public sealed class SigningProfileRevocationRecord
    {
        public readonly string? RevocationEffectiveFrom;
        public readonly string? RevokedAt;
        public readonly string? RevokedBy;

        [OutputConstructor]
        private SigningProfileRevocationRecord(
            string? revocationEffectiveFrom,

            string? revokedAt,

            string? revokedBy)
        {
            RevocationEffectiveFrom = revocationEffectiveFrom;
            RevokedAt = revokedAt;
            RevokedBy = revokedBy;
        }
    }
}
