// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.RedShift
{
    public static class GetServiceAccount
    {
        /// <summary>
        /// Use this data source to get the Account ID of the [AWS Redshift Service Account](http://docs.aws.amazon.com/redshift/latest/mgmt/db-auditing.html#db-auditing-enable-logging)
        /// in a given region for the purpose of allowing Redshift to store audit data in S3.
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
        ///         var main = Output.Create(Aws.RedShift.GetServiceAccount.InvokeAsync());
        ///         var bucket = new Aws.S3.Bucket("bucket", new Aws.S3.BucketArgs
        ///         {
        ///             ForceDestroy = true,
        ///             Policy = Output.Tuple(main, main).Apply(values =&gt;
        ///             {
        ///                 var main = values.Item1;
        ///                 var main1 = values.Item2;
        ///                 return @$"{{
        /// 	""Version"": ""2008-10-17"",
        /// 	""Statement"": [
        /// 		{{
        ///         			""Sid"": ""Put bucket policy needed for audit logging"",
        ///         			""Effect"": ""Allow"",
        ///         			""Principal"": {{
        /// 						""AWS"": ""{main.Arn}""
        ///         			}},
        ///         			""Action"": ""s3:PutObject"",
        ///         			""Resource"": ""arn:aws:s3:::tf-redshift-logging-test-bucket/*""
        ///         		}},
        ///         		{{
        ///         			""Sid"": ""Get bucket policy needed for audit logging "",
        ///         			""Effect"": ""Allow"",
        ///         			""Principal"": {{
        /// 						""AWS"": ""{main1.Arn}""
        ///         			}},
        ///         			""Action"": ""s3:GetBucketAcl"",
        ///         			""Resource"": ""arn:aws:s3:::tf-redshift-logging-test-bucket""
        ///         		}}
        /// 	]
        /// }}
        /// 
        /// ";
        ///             }),
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetServiceAccountResult> InvokeAsync(GetServiceAccountArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceAccountResult>("aws:redshift/getServiceAccount:getServiceAccount", args ?? new GetServiceAccountArgs(), options.WithVersion());
    }


    public sealed class GetServiceAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the region whose AWS Redshift account ID is desired.
        /// Defaults to the region from the AWS provider configuration.
        /// </summary>
        [Input("region")]
        public string? Region { get; set; }

        public GetServiceAccountArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceAccountResult
    {
        /// <summary>
        /// The ARN of the AWS Redshift service account in the selected region.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Region;

        [OutputConstructor]
        private GetServiceAccountResult(
            string arn,

            string id,

            string? region)
        {
            Arn = arn;
            Id = id;
            Region = region;
        }
    }
}
