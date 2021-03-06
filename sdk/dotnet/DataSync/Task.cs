// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DataSync
{
    /// <summary>
    /// Manages an AWS DataSync Task, which represents a configuration for synchronization. Starting an execution of these DataSync Tasks (actually synchronizing files) is performed outside of this resource.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.DataSync.Task("example", new Aws.DataSync.TaskArgs
    ///         {
    ///             DestinationLocationArn = aws_datasync_location_s3.Destination.Arn,
    ///             Options = new Aws.DataSync.Inputs.TaskOptionsArgs
    ///             {
    ///                 BytesPerSecond = -1,
    ///             },
    ///             SourceLocationArn = aws_datasync_location_nfs.Source.Arn,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Task : Pulumi.CustomResource
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Task.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Output("cloudwatchLogGroupArn")]
        public Output<string?> CloudwatchLogGroupArn { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Output("destinationLocationArn")]
        public Output<string> DestinationLocationArn { get; private set; } = null!;

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Output("options")]
        public Output<Outputs.TaskOptions?> Options { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Output("sourceLocationArn")]
        public Output<string> SourceLocationArn { get; private set; } = null!;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Task resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Task(string name, TaskArgs args, CustomResourceOptions? options = null)
            : base("aws:datasync/task:Task", name, args ?? new TaskArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Task(string name, Input<string> id, TaskState? state = null, CustomResourceOptions? options = null)
            : base("aws:datasync/task:Task", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Task resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Task Get(string name, Input<string> id, TaskState? state = null, CustomResourceOptions? options = null)
        {
            return new Task(name, id, state, options);
        }
    }

    public sealed class TaskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Input("cloudwatchLogGroupArn")]
        public Input<string>? CloudwatchLogGroupArn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Input("destinationLocationArn", required: true)]
        public Input<string> DestinationLocationArn { get; set; } = null!;

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Input("options")]
        public Input<Inputs.TaskOptionsArgs>? Options { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Input("sourceLocationArn", required: true)]
        public Input<string> SourceLocationArn { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public TaskArgs()
        {
        }
    }

    public sealed class TaskState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Task.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Input("cloudwatchLogGroupArn")]
        public Input<string>? CloudwatchLogGroupArn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Input("destinationLocationArn")]
        public Input<string>? DestinationLocationArn { get; set; }

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Input("options")]
        public Input<Inputs.TaskOptionsGetArgs>? Options { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Input("sourceLocationArn")]
        public Input<string>? SourceLocationArn { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public TaskState()
        {
        }
    }
}
