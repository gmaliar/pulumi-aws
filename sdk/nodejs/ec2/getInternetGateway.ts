// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * `aws.ec2.InternetGateway` provides details about a specific Internet Gateway.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const config = new pulumi.Config();
 * const vpcId = config.requireObject("vpcId");
 * const default = aws.ec2.getInternetGateway({
 *     filters: [{
 *         name: "attachment.vpc-id",
 *         values: [vpcId],
 *     }],
 * });
 * ```
 */
export function getInternetGateway(args?: GetInternetGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetInternetGatewayResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:ec2/getInternetGateway:getInternetGateway", {
        "filters": args.filters,
        "internetGatewayId": args.internetGatewayId,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getInternetGateway.
 */
export interface GetInternetGatewayArgs {
    /**
     * Custom filter block as described below.
     */
    readonly filters?: inputs.ec2.GetInternetGatewayFilter[];
    /**
     * The id of the specific Internet Gateway to retrieve.
     */
    readonly internetGatewayId?: string;
    /**
     * A map of tags, each pair of which must exactly match
     * a pair on the desired Internet Gateway.
     */
    readonly tags?: {[key: string]: string};
}

/**
 * A collection of values returned by getInternetGateway.
 */
export interface GetInternetGatewayResult {
    /**
     * The ARN of the Internet Gateway.
     */
    readonly arn: string;
    readonly attachments: outputs.ec2.GetInternetGatewayAttachment[];
    readonly filters?: outputs.ec2.GetInternetGatewayFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly internetGatewayId: string;
    /**
     * The ID of the AWS account that owns the internet gateway.
     */
    readonly ownerId: string;
    readonly tags: {[key: string]: string};
}
