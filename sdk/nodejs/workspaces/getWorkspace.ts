// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as enums from "../types/enums";
import * as utilities from "../utilities";

/**
 * Use this data source to get information about a workspace in [AWS Workspaces](https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces.html) Service.
 *
 * ## Example Usage
 * ### Filter By Workspace ID
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = pulumi.output(aws.workspaces.getWorkspace({
 *     workspaceId: "ws-cj5xcxsz5",
 * }, { async: true }));
 * ```
 * ### Filter By Directory ID & User Name
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = pulumi.output(aws.workspaces.getWorkspace({
 *     directoryId: "d-9967252f57",
 *     userName: "Example",
 * }, { async: true }));
 * ```
 */
export function getWorkspace(args?: GetWorkspaceArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkspaceResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:workspaces/getWorkspace:getWorkspace", {
        "directoryId": args.directoryId,
        "tags": args.tags,
        "userName": args.userName,
        "workspaceId": args.workspaceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkspace.
 */
export interface GetWorkspaceArgs {
    /**
     * The ID of the directory for the WorkSpace. You have to specify `userName` along with `directoryId`. You cannot combine this parameter with `workspaceId`.
     */
    readonly directoryId?: string;
    /**
     * The tags for the WorkSpace.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The user name of the user for the WorkSpace. This user name must exist in the directory for the WorkSpace. You cannot combine this parameter with `workspaceId`.
     */
    readonly userName?: string;
    /**
     * The ID of the WorkSpace. You cannot combine this parameter with `directoryId`.
     */
    readonly workspaceId?: string;
}

/**
 * A collection of values returned by getWorkspace.
 */
export interface GetWorkspaceResult {
    readonly bundleId: string;
    /**
     * The name of the WorkSpace, as seen by the operating system.
     */
    readonly computerName: string;
    readonly directoryId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The IP address of the WorkSpace.
     */
    readonly ipAddress: string;
    readonly rootVolumeEncryptionEnabled: boolean;
    /**
     * The operational state of the WorkSpace.
     */
    readonly state: string;
    readonly tags: {[key: string]: string};
    readonly userName: string;
    readonly userVolumeEncryptionEnabled: boolean;
    readonly volumeEncryptionKey: string;
    readonly workspaceId: string;
    readonly workspaceProperties: outputs.workspaces.GetWorkspaceWorkspaceProperty[];
}
