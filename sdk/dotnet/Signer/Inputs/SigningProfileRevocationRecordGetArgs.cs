// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Signer.Inputs
{

    public sealed class SigningProfileRevocationRecordGetArgs : Pulumi.ResourceArgs
    {
        [Input("revocationEffectiveFrom")]
        public Input<string>? RevocationEffectiveFrom { get; set; }

        [Input("revokedAt")]
        public Input<string>? RevokedAt { get; set; }

        [Input("revokedBy")]
        public Input<string>? RevokedBy { get; set; }

        public SigningProfileRevocationRecordGetArgs()
        {
        }
    }
}
