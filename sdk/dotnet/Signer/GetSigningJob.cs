// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Signer
{
    public static class GetSigningJob
    {
        /// <summary>
        /// Provides information about a Signer Signing Job.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var buildSigningJob = Output.Create(Aws.Signer.GetSigningJob.InvokeAsync(new Aws.Signer.GetSigningJobArgs
        ///         {
        ///             JobId = "9ed7e5c3-b8d4-4da0-8459-44e0b068f7ee",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSigningJobResult> InvokeAsync(GetSigningJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSigningJobResult>("aws:signer/getSigningJob:getSigningJob", args ?? new GetSigningJobArgs(), options.WithVersion());
    }


    public sealed class GetSigningJobArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the signing job on output.
        /// </summary>
        [Input("jobId", required: true)]
        public string JobId { get; set; } = null!;

        public GetSigningJobArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSigningJobResult
    {
        /// <summary>
        /// Date and time in [RFC3339 format](https://tools.ietf.org/html/rfc3339#section-5.8) that the signing job was completed.
        /// </summary>
        public readonly string CompletedAt;
        /// <summary>
        /// Date and time in [RFC3339 format](https://tools.ietf.org/html/rfc3339#section-5.8) that the signing job was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string JobId;
        /// <summary>
        /// The IAM entity that initiated the signing job.
        /// </summary>
        public readonly string JobInvoker;
        /// <summary>
        /// The AWS account ID of the job owner.
        /// </summary>
        public readonly string JobOwner;
        /// <summary>
        /// A human-readable name for the signing platform associated with the signing job.
        /// </summary>
        public readonly string PlatformDisplayName;
        /// <summary>
        /// The platform to which your signed code image will be distributed.
        /// </summary>
        public readonly string PlatformId;
        /// <summary>
        /// The name of the profile that initiated the signing operation.
        /// </summary>
        public readonly string ProfileName;
        /// <summary>
        /// The version of the signing profile used to initiate the signing job.
        /// </summary>
        public readonly string ProfileVersion;
        /// <summary>
        /// The IAM principal that requested the signing job.
        /// </summary>
        public readonly string RequestedBy;
        /// <summary>
        /// A revocation record if the signature generated by the signing job has been revoked. Contains a timestamp and the ID of the IAM entity that revoked the signature.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSigningJobRevocationRecordResult> RevocationRecords;
        /// <summary>
        /// The time when the signature of a signing job expires.
        /// </summary>
        public readonly string SignatureExpiresAt;
        /// <summary>
        /// Name of the S3 bucket where the signed code image is saved by code signing.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSigningJobSignedObjectResult> SignedObjects;
        /// <summary>
        /// The object that contains the name of your S3 bucket or your raw code.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSigningJobSourceResult> Sources;
        /// <summary>
        /// Status of the signing job.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// String value that contains the status reason.
        /// </summary>
        public readonly string StatusReason;

        [OutputConstructor]
        private GetSigningJobResult(
            string completedAt,

            string createdAt,

            string id,

            string jobId,

            string jobInvoker,

            string jobOwner,

            string platformDisplayName,

            string platformId,

            string profileName,

            string profileVersion,

            string requestedBy,

            ImmutableArray<Outputs.GetSigningJobRevocationRecordResult> revocationRecords,

            string signatureExpiresAt,

            ImmutableArray<Outputs.GetSigningJobSignedObjectResult> signedObjects,

            ImmutableArray<Outputs.GetSigningJobSourceResult> sources,

            string status,

            string statusReason)
        {
            CompletedAt = completedAt;
            CreatedAt = createdAt;
            Id = id;
            JobId = jobId;
            JobInvoker = jobInvoker;
            JobOwner = jobOwner;
            PlatformDisplayName = platformDisplayName;
            PlatformId = platformId;
            ProfileName = profileName;
            ProfileVersion = profileVersion;
            RequestedBy = requestedBy;
            RevocationRecords = revocationRecords;
            SignatureExpiresAt = signatureExpiresAt;
            SignedObjects = signedObjects;
            Sources = sources;
            Status = status;
            StatusReason = statusReason;
        }
    }
}
