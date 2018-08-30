// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * `aws_eip` provides details about a specific Elastic IP.
 * 
 * This resource can prove useful when a module accepts an allocation ID or
 * public IP as an input variable and needs to determine the other.
 */
export function getElasticIp(args?: GetElasticIpArgs, opts?: pulumi.InvokeOptions): Promise<GetElasticIpResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:index/getElasticIp:getElasticIp", {
        "id": args.id,
        "publicIp": args.publicIp,
    }, opts);
}

/**
 * A collection of arguments for invoking getElasticIp.
 */
export interface GetElasticIpArgs {
    /**
     * The allocation id of the specific EIP to retrieve.
     */
    readonly id?: string;
    /**
     * The public IP of the specific EIP to retrieve.
     */
    readonly publicIp?: string;
}

/**
 * A collection of values returned by getElasticIp.
 */
export interface GetElasticIpResult {
    readonly id: string;
    readonly publicIp: string;
}
