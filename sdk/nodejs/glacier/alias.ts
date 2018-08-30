// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Gamelift Alias resource.
 */
export class Alias extends pulumi.CustomResource {
    /**
     * Get an existing Alias resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AliasState): Alias {
        return new Alias(name, <any>state, { id });
    }

    /**
     * Alias ARN.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * Description of the alias.
     */
    public readonly description: pulumi.Output<string | undefined>;
    /**
     * Name of the alias.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Specifies the fleet and/or routing type to use for the alias.
     */
    public readonly routingStrategy: pulumi.Output<{ fleetId?: string, message?: string, type: string }>;

    /**
     * Create a Alias resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AliasArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AliasArgs | AliasState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: AliasState = argsOrState as AliasState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["routingStrategy"] = state ? state.routingStrategy : undefined;
        } else {
            const args = argsOrState as AliasArgs | undefined;
            if (!args || args.routingStrategy === undefined) {
                throw new Error("Missing required property 'routingStrategy'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["routingStrategy"] = args ? args.routingStrategy : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        super("aws:glacier/alias:Alias", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Alias resources.
 */
export interface AliasState {
    /**
     * Alias ARN.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * Description of the alias.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Name of the alias.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the fleet and/or routing type to use for the alias.
     */
    readonly routingStrategy?: pulumi.Input<{ fleetId?: pulumi.Input<string>, message?: pulumi.Input<string>, type: pulumi.Input<string> }>;
}

/**
 * The set of arguments for constructing a Alias resource.
 */
export interface AliasArgs {
    /**
     * Description of the alias.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Name of the alias.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the fleet and/or routing type to use for the alias.
     */
    readonly routingStrategy: pulumi.Input<{ fleetId?: pulumi.Input<string>, message?: pulumi.Input<string>, type: pulumi.Input<string> }>;
}
