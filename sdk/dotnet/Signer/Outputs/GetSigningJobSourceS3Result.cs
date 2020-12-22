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
    public sealed class GetSigningJobSourceS3Result
    {
        public readonly string Bucket;
        public readonly string Key;
        public readonly string Version;

        [OutputConstructor]
        private GetSigningJobSourceS3Result(
            string bucket,

            string key,

            string version)
        {
            Bucket = bucket;
            Key = key;
            Version = version;
        }
    }
}