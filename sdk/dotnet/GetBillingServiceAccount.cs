// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws
{
    public static class GetBillingServiceAccount
    {
        /// <summary>
        /// Use this data source to get the Account ID of the [AWS Billing and Cost Management Service Account](http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-getting-started.html#step-2) for the purpose of whitelisting in S3 bucket policy.
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
        ///         var main = Output.Create(Aws.GetBillingServiceAccount.InvokeAsync());
        ///         var billingLogs = new Aws.S3.Bucket("billingLogs", new Aws.S3.BucketArgs
        ///         {
        ///             Acl = "private",
        ///             Policy = Output.Tuple(main, main).Apply(values =&gt;
        ///             {
        ///                 var main = values.Item1;
        ///                 var main1 = values.Item2;
        ///                 return @$"{{
        ///   ""Id"": ""Policy"",
        ///   ""Version"": ""2012-10-17"",
        ///   ""Statement"": [
        ///     {{
        ///       ""Action"": [
        ///         ""s3:GetBucketAcl"", ""s3:GetBucketPolicy""
        ///       ],
        ///       ""Effect"": ""Allow"",
        ///       ""Resource"": ""arn:aws:s3:::my-billing-tf-test-bucket"",
        ///       ""Principal"": {{
        ///         ""AWS"": [
        ///           ""{main.Arn}""
        ///         ]
        ///       }}
        ///     }},
        ///     {{
        ///       ""Action"": [
        ///         ""s3:PutObject""
        ///       ],
        ///       ""Effect"": ""Allow"",
        ///       ""Resource"": ""arn:aws:s3:::my-billing-tf-test-bucket/*"",
        ///       ""Principal"": {{
        ///         ""AWS"": [
        ///           ""{main1.Arn}""
        ///         ]
        ///       }}
        ///     }}
        ///   ]
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
        public static Task<GetBillingServiceAccountResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBillingServiceAccountResult>("aws:index/getBillingServiceAccount:getBillingServiceAccount", InvokeArgs.Empty, options.WithVersion());
    }


    [OutputType]
    public sealed class GetBillingServiceAccountResult
    {
        /// <summary>
        /// The ARN of the AWS billing service account.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetBillingServiceAccountResult(
            string arn,

            string id)
        {
            Arn = arn;
            Id = id;
        }
    }
}
