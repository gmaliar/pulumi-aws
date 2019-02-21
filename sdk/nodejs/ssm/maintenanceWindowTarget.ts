// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides an SSM Maintenance Window Target resource
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const window = new aws.ssm.MaintenanceWindow("window", {
 *     cutoff: 1,
 *     duration: 3,
 *     name: "maintenance-window-webapp",
 *     schedule: "cron(0 16 ? * TUE *)",
 * });
 * const target1 = new aws.ssm.MaintenanceWindowTarget("target1", {
 *     resourceType: "INSTANCE",
 *     targets: [{
 *         key: "tag:Name",
 *         values: ["acceptance_test"],
 *     }],
 *     windowId: window.id,
 * });
 * ```
 */
export class MaintenanceWindowTarget extends pulumi.CustomResource {
    /**
     * Get an existing MaintenanceWindowTarget resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MaintenanceWindowTargetState, opts?: pulumi.CustomResourceOptions): MaintenanceWindowTarget {
        return new MaintenanceWindowTarget(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<MaintenanceWindowTargetResult> {
        return ctx.list({...args, type: 'aws:ssm/maintenanceWindowTarget:MaintenanceWindowTarget'});
    }

    /**
     * User-provided value that will be included in any CloudWatch events raised while running tasks for these targets in this Maintenance Window.
     */
    public readonly ownerInformation: pulumi.Output<string | undefined>;
    /**
     * The type of target being registered with the Maintenance Window. Possible values `INSTANCE`.
     */
    public readonly resourceType: pulumi.Output<string>;
    /**
     * The targets (either instances or tags). Instances are specified using Key=instanceids,Values=instanceid1,instanceid2. Tags are specified using Key=tag name,Values=tag value.
     */
    public readonly targets: pulumi.Output<{ key: string, values: string[] }[]>;
    /**
     * The Id of the maintenance window to register the target with.
     */
    public readonly windowId: pulumi.Output<string>;

    /**
     * Create a MaintenanceWindowTarget resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MaintenanceWindowTargetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MaintenanceWindowTargetArgs | MaintenanceWindowTargetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: MaintenanceWindowTargetState = argsOrState as MaintenanceWindowTargetState | undefined;
            inputs["ownerInformation"] = state ? state.ownerInformation : undefined;
            inputs["resourceType"] = state ? state.resourceType : undefined;
            inputs["targets"] = state ? state.targets : undefined;
            inputs["windowId"] = state ? state.windowId : undefined;
        } else {
            const args = argsOrState as MaintenanceWindowTargetArgs | undefined;
            if (!args || args.resourceType === undefined) {
                throw new Error("Missing required property 'resourceType'");
            }
            if (!args || args.targets === undefined) {
                throw new Error("Missing required property 'targets'");
            }
            if (!args || args.windowId === undefined) {
                throw new Error("Missing required property 'windowId'");
            }
            inputs["ownerInformation"] = args ? args.ownerInformation : undefined;
            inputs["resourceType"] = args ? args.resourceType : undefined;
            inputs["targets"] = args ? args.targets : undefined;
            inputs["windowId"] = args ? args.windowId : undefined;
        }
        super("aws:ssm/maintenanceWindowTarget:MaintenanceWindowTarget", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MaintenanceWindowTarget resources.
 */
export interface MaintenanceWindowTargetState {
    /**
     * User-provided value that will be included in any CloudWatch events raised while running tasks for these targets in this Maintenance Window.
     */
    readonly ownerInformation?: pulumi.Input<string>;
    /**
     * The type of target being registered with the Maintenance Window. Possible values `INSTANCE`.
     */
    readonly resourceType?: pulumi.Input<string>;
    /**
     * The targets (either instances or tags). Instances are specified using Key=instanceids,Values=instanceid1,instanceid2. Tags are specified using Key=tag name,Values=tag value.
     */
    readonly targets?: pulumi.Input<pulumi.Input<{ key: pulumi.Input<string>, values: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * The Id of the maintenance window to register the target with.
     */
    readonly windowId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MaintenanceWindowTarget resource.
 */
export interface MaintenanceWindowTargetArgs {
    /**
     * User-provided value that will be included in any CloudWatch events raised while running tasks for these targets in this Maintenance Window.
     */
    readonly ownerInformation?: pulumi.Input<string>;
    /**
     * The type of target being registered with the Maintenance Window. Possible values `INSTANCE`.
     */
    readonly resourceType: pulumi.Input<string>;
    /**
     * The targets (either instances or tags). Instances are specified using Key=instanceids,Values=instanceid1,instanceid2. Tags are specified using Key=tag name,Values=tag value.
     */
    readonly targets: pulumi.Input<pulumi.Input<{ key: pulumi.Input<string>, values: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * The Id of the maintenance window to register the target with.
     */
    readonly windowId: pulumi.Input<string>;
}

/**
 * The live MaintenanceWindowTarget resource.
 */
export interface MaintenanceWindowTargetResult {
    /**
     * User-provided value that will be included in any CloudWatch events raised while running tasks for these targets in this Maintenance Window.
     */
    readonly ownerInformation?: string;
    /**
     * The type of target being registered with the Maintenance Window. Possible values `INSTANCE`.
     */
    readonly resourceType: string;
    /**
     * The targets (either instances or tags). Instances are specified using Key=instanceids,Values=instanceid1,instanceid2. Tags are specified using Key=tag name,Values=tag value.
     */
    readonly targets: { key: string, values: string[] }[];
    /**
     * The Id of the maintenance window to register the target with.
     */
    readonly windowId: string;
}
