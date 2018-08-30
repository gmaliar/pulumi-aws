// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to manage a CloudWatch log resource policy.
 */
export class LogResourcePolicy extends pulumi.CustomResource {
    /**
     * Get an existing LogResourcePolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogResourcePolicyState): LogResourcePolicy {
        return new LogResourcePolicy(name, <any>state, { id });
    }

    /**
     * Details of the resource policy, including the identity of the principal that is enabled to put logs to this account. This is formatted as a JSON string. Maximum length of 5120 characters.
     */
    public readonly policyDocument: pulumi.Output<string>;
    /**
     * Name of the resource policy.
     */
    public readonly policyName: pulumi.Output<string>;

    /**
     * Create a LogResourcePolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogResourcePolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogResourcePolicyArgs | LogResourcePolicyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: LogResourcePolicyState = argsOrState as LogResourcePolicyState | undefined;
            inputs["policyDocument"] = state ? state.policyDocument : undefined;
            inputs["policyName"] = state ? state.policyName : undefined;
        } else {
            const args = argsOrState as LogResourcePolicyArgs | undefined;
            if (!args || args.policyDocument === undefined) {
                throw new Error("Missing required property 'policyDocument'");
            }
            if (!args || args.policyName === undefined) {
                throw new Error("Missing required property 'policyName'");
            }
            inputs["policyDocument"] = args ? args.policyDocument : undefined;
            inputs["policyName"] = args ? args.policyName : undefined;
        }
        super("aws:cloudwatch/logResourcePolicy:LogResourcePolicy", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogResourcePolicy resources.
 */
export interface LogResourcePolicyState {
    /**
     * Details of the resource policy, including the identity of the principal that is enabled to put logs to this account. This is formatted as a JSON string. Maximum length of 5120 characters.
     */
    readonly policyDocument?: pulumi.Input<string>;
    /**
     * Name of the resource policy.
     */
    readonly policyName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LogResourcePolicy resource.
 */
export interface LogResourcePolicyArgs {
    /**
     * Details of the resource policy, including the identity of the principal that is enabled to put logs to this account. This is formatted as a JSON string. Maximum length of 5120 characters.
     */
    readonly policyDocument: pulumi.Input<string>;
    /**
     * Name of the resource policy.
     */
    readonly policyName: pulumi.Input<string>;
}
