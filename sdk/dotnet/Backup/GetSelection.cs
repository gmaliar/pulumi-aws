// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Backup
{
    public static class GetSelection
    {
        /// <summary>
        /// Use this data source to get information on an existing backup selection.
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
        ///         var example = Output.Create(Aws.Backup.GetSelection.InvokeAsync(new Aws.Backup.GetSelectionArgs
        ///         {
        ///             PlanId = data.Aws_backup_plan.Example.Id,
        ///             SelectionId = "selection-id-example",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSelectionResult> InvokeAsync(GetSelectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSelectionResult>("aws:backup/getSelection:getSelection", args ?? new GetSelectionArgs(), options.WithVersion());
    }


    public sealed class GetSelectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The backup plan ID associated with the selection of resources.
        /// </summary>
        [Input("planId", required: true)]
        public string PlanId { get; set; } = null!;

        /// <summary>
        /// The backup selection ID.
        /// </summary>
        [Input("selectionId", required: true)]
        public string SelectionId { get; set; } = null!;

        public GetSelectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSelectionResult
    {
        /// <summary>
        /// The ARN of the IAM role that AWS Backup uses to authenticate when restoring and backing up the target resource. See the [AWS Backup Developer Guide](https://docs.aws.amazon.com/aws-backup/latest/devguide/access-control.html#managed-policies) for additional information about using AWS managed policies or creating custom policies attached to the IAM role.
        /// </summary>
        public readonly string IamRoleArn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The display name of a resource selection document.
        /// </summary>
        public readonly string Name;
        public readonly string PlanId;
        /// <summary>
        /// An array of strings that either contain Amazon Resource Names (ARNs) or match patterns of resources to assign to a backup plan..
        /// </summary>
        public readonly ImmutableArray<string> Resources;
        public readonly string SelectionId;

        [OutputConstructor]
        private GetSelectionResult(
            string iamRoleArn,

            string id,

            string name,

            string planId,

            ImmutableArray<string> resources,

            string selectionId)
        {
            IamRoleArn = iamRoleArn;
            Id = id;
            Name = name;
            PlanId = planId;
            Resources = resources;
            SelectionId = selectionId;
        }
    }
}
