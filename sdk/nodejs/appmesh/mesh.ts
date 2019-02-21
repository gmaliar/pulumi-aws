// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides an AWS App Mesh service mesh resource.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const simple = new aws.appmesh.Mesh("simple", {
 *     name: "simpleapp",
 * });
 * ```
 */
export class Mesh extends pulumi.CustomResource {
    /**
     * Get an existing Mesh resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MeshState, opts?: pulumi.CustomResourceOptions): Mesh {
        return new Mesh(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<MeshResult> {
        return ctx.list({...args, type: 'aws:appmesh/mesh:Mesh'});
    }

    /**
     * The ARN of the service mesh.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * The creation date of the service mesh.
     */
    public /*out*/ readonly createdDate: pulumi.Output<string>;
    /**
     * The last update date of the service mesh.
     */
    public /*out*/ readonly lastUpdatedDate: pulumi.Output<string>;
    /**
     * The name to use for the service mesh.
     */
    public readonly name: pulumi.Output<string>;

    /**
     * Create a Mesh resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: MeshArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MeshArgs | MeshState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: MeshState = argsOrState as MeshState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["createdDate"] = state ? state.createdDate : undefined;
            inputs["lastUpdatedDate"] = state ? state.lastUpdatedDate : undefined;
            inputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as MeshArgs | undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["createdDate"] = undefined /*out*/;
            inputs["lastUpdatedDate"] = undefined /*out*/;
        }
        super("aws:appmesh/mesh:Mesh", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Mesh resources.
 */
export interface MeshState {
    /**
     * The ARN of the service mesh.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The creation date of the service mesh.
     */
    readonly createdDate?: pulumi.Input<string>;
    /**
     * The last update date of the service mesh.
     */
    readonly lastUpdatedDate?: pulumi.Input<string>;
    /**
     * The name to use for the service mesh.
     */
    readonly name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Mesh resource.
 */
export interface MeshArgs {
    /**
     * The name to use for the service mesh.
     */
    readonly name?: pulumi.Input<string>;
}

/**
 * The live Mesh resource.
 */
export interface MeshResult {
    /**
     * The ARN of the service mesh.
     */
    readonly arn: string;
    /**
     * The creation date of the service mesh.
     */
    readonly createdDate: string;
    /**
     * The last update date of the service mesh.
     */
    readonly lastUpdatedDate: string;
    /**
     * The name to use for the service mesh.
     */
    readonly name: string;
}
