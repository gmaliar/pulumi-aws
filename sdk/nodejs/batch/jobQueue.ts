// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Batch Job Queue resource.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const testQueue = new aws.batch.JobQueue("testQueue", {
 *     state: "ENABLED",
 *     priority: 1,
 *     computeEnvironments: [
 *         aws_batch_compute_environment.test_environment_1.arn,
 *         aws_batch_compute_environment.test_environment_2.arn,
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * Batch Job Queue can be imported using the `arn`, e.g.
 *
 * ```sh
 *  $ pulumi import aws:batch/jobQueue:JobQueue test_queue arn:aws:batch:us-east-1:123456789012:job-queue/sample
 * ```
 */
export class JobQueue extends pulumi.CustomResource {
    /**
     * Get an existing JobQueue resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: JobQueueState, opts?: pulumi.CustomResourceOptions): JobQueue {
        return new JobQueue(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:batch/jobQueue:JobQueue';

    /**
     * Returns true if the given object is an instance of JobQueue.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is JobQueue {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === JobQueue.__pulumiType;
    }

    /**
     * The Amazon Resource Name of the job queue.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Specifies the set of compute environments
     * mapped to a job queue and their order.  The position of the compute environments
     * in the list will dictate the order. You can associate up to 3 compute environments
     * with a job queue.
     */
    public readonly computeEnvironments!: pulumi.Output<string[]>;
    /**
     * Specifies the name of the job queue.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The priority of the job queue. Job queues with a higher priority
     * are evaluated first when associated with the same compute environment.
     */
    public readonly priority!: pulumi.Output<number>;
    /**
     * The state of the job queue. Must be one of: `ENABLED` or `DISABLED`
     */
    public readonly state!: pulumi.Output<string>;
    /**
     * Key-value map of resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a JobQueue resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: JobQueueArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: JobQueueArgs | JobQueueState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as JobQueueState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["computeEnvironments"] = state ? state.computeEnvironments : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["priority"] = state ? state.priority : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as JobQueueArgs | undefined;
            if ((!args || args.computeEnvironments === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'computeEnvironments'");
            }
            if ((!args || args.priority === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'priority'");
            }
            if ((!args || args.state === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'state'");
            }
            inputs["computeEnvironments"] = args ? args.computeEnvironments : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["priority"] = args ? args.priority : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(JobQueue.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering JobQueue resources.
 */
export interface JobQueueState {
    /**
     * The Amazon Resource Name of the job queue.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * Specifies the set of compute environments
     * mapped to a job queue and their order.  The position of the compute environments
     * in the list will dictate the order. You can associate up to 3 compute environments
     * with a job queue.
     */
    readonly computeEnvironments?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the name of the job queue.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The priority of the job queue. Job queues with a higher priority
     * are evaluated first when associated with the same compute environment.
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * The state of the job queue. Must be one of: `ENABLED` or `DISABLED`
     */
    readonly state?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a JobQueue resource.
 */
export interface JobQueueArgs {
    /**
     * Specifies the set of compute environments
     * mapped to a job queue and their order.  The position of the compute environments
     * in the list will dictate the order. You can associate up to 3 compute environments
     * with a job queue.
     */
    readonly computeEnvironments: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the name of the job queue.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The priority of the job queue. Job queues with a higher priority
     * are evaluated first when associated with the same compute environment.
     */
    readonly priority: pulumi.Input<number>;
    /**
     * The state of the job queue. Must be one of: `ENABLED` or `DISABLED`
     */
    readonly state: pulumi.Input<string>;
    /**
     * Key-value map of resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
