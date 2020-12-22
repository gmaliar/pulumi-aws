// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Retrieve information about an AWS WorkSpaces directory.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = pulumi.output(aws.workspaces.getDirectory({
 *     directoryId: "d-9067783251",
 * }, { async: true }));
 * ```
 */
export function getDirectory(args: GetDirectoryArgs, opts?: pulumi.InvokeOptions): Promise<GetDirectoryResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:workspaces/getDirectory:getDirectory", {
        "directoryId": args.directoryId,
        "tags": args.tags,
        "workspaceCreationProperties": args.workspaceCreationProperties,
    }, opts);
}

/**
 * A collection of arguments for invoking getDirectory.
 */
export interface GetDirectoryArgs {
    /**
     * The directory identifier for registration in WorkSpaces service.
     */
    readonly directoryId: string;
    /**
     * A map of tags assigned to the WorkSpaces directory.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The default properties that are used for creating WorkSpaces. Defined below.
     */
    readonly workspaceCreationProperties?: inputs.workspaces.GetDirectoryWorkspaceCreationProperties;
}

/**
 * A collection of values returned by getDirectory.
 */
export interface GetDirectoryResult {
    /**
     * The directory alias.
     */
    readonly alias: string;
    /**
     * The user name for the service account.
     */
    readonly customerUserName: string;
    readonly directoryId: string;
    /**
     * The name of the directory.
     */
    readonly directoryName: string;
    /**
     * The directory type.
     */
    readonly directoryType: string;
    /**
     * The IP addresses of the DNS servers for the directory.
     */
    readonly dnsIpAddresses: string[];
    /**
     * The identifier of the IAM role. This is the role that allows Amazon WorkSpaces to make calls to other services, such as Amazon EC2, on your behalf.
     */
    readonly iamRoleId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The identifiers of the IP access control groups associated with the directory.
     */
    readonly ipGroupIds: string[];
    /**
     * The registration code for the directory. This is the code that users enter in their Amazon WorkSpaces client application to connect to the directory.
     */
    readonly registrationCode: string;
    /**
     * The permissions to enable or disable self-service capabilities.
     */
    readonly selfServicePermissions: outputs.workspaces.GetDirectorySelfServicePermission[];
    /**
     * The identifiers of the subnets where the directory resides.
     */
    readonly subnetIds: string[];
    /**
     * A map of tags assigned to the WorkSpaces directory.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The default properties that are used for creating WorkSpaces. Defined below.
     */
    readonly workspaceCreationProperties: outputs.workspaces.GetDirectoryWorkspaceCreationProperties;
    /**
     * The identifier of the security group that is assigned to new WorkSpaces. Defined below.
     */
    readonly workspaceSecurityGroupId: string;
}