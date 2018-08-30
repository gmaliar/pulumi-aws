// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

import {Tags} from "../index";

/**
 * Provides a CloudWatch Log Group resource.
 */
export class LogGroup extends pulumi.CustomResource {
    /**
     * Get an existing LogGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogGroupState): LogGroup {
        return new LogGroup(name, <any>state, { id });
    }

    /**
     * The Amazon Resource Name (ARN) specifying the log group.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * The ARN of the KMS Key to use when encrypting log data. Please note, after the AWS KMS CMK is disassociated from the log group,
     * AWS CloudWatch Logs stops encrypting newly ingested data for the log group. All previously ingested data remains encrypted, and AWS CloudWatch Logs requires
     * permissions for the CMK whenever the encrypted data is requested.
     */
    public readonly kmsKeyId: pulumi.Output<string | undefined>;
    /**
     * The name of the log group. If omitted, Terraform will assign a random, unique name.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    public readonly namePrefix: pulumi.Output<string | undefined>;
    /**
     * Specifies the number of days
     * you want to retain log events in the specified log group.
     */
    public readonly retentionInDays: pulumi.Output<number | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<Tags | undefined>;

    /**
     * Create a LogGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: LogGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogGroupArgs | LogGroupState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: LogGroupState = argsOrState as LogGroupState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["kmsKeyId"] = state ? state.kmsKeyId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namePrefix"] = state ? state.namePrefix : undefined;
            inputs["retentionInDays"] = state ? state.retentionInDays : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as LogGroupArgs | undefined;
            inputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namePrefix"] = args ? args.namePrefix : undefined;
            inputs["retentionInDays"] = args ? args.retentionInDays : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        super("aws:cloudwatch/logGroup:LogGroup", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogGroup resources.
 */
export interface LogGroupState {
    /**
     * The Amazon Resource Name (ARN) specifying the log group.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The ARN of the KMS Key to use when encrypting log data. Please note, after the AWS KMS CMK is disassociated from the log group,
     * AWS CloudWatch Logs stops encrypting newly ingested data for the log group. All previously ingested data remains encrypted, and AWS CloudWatch Logs requires
     * permissions for the CMK whenever the encrypted data is requested.
     */
    readonly kmsKeyId?: pulumi.Input<string>;
    /**
     * The name of the log group. If omitted, Terraform will assign a random, unique name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * Specifies the number of days
     * you want to retain log events in the specified log group.
     */
    readonly retentionInDays?: pulumi.Input<number>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<Tags>;
}

/**
 * The set of arguments for constructing a LogGroup resource.
 */
export interface LogGroupArgs {
    /**
     * The ARN of the KMS Key to use when encrypting log data. Please note, after the AWS KMS CMK is disassociated from the log group,
     * AWS CloudWatch Logs stops encrypting newly ingested data for the log group. All previously ingested data remains encrypted, and AWS CloudWatch Logs requires
     * permissions for the CMK whenever the encrypted data is requested.
     */
    readonly kmsKeyId?: pulumi.Input<string>;
    /**
     * The name of the log group. If omitted, Terraform will assign a random, unique name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * Specifies the number of days
     * you want to retain log events in the specified log group.
     */
    readonly retentionInDays?: pulumi.Input<number>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<Tags>;
}
