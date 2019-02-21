// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides a resource to create a VPC VPN Gateway.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const vpnGw = new aws.ec2.VpnGateway("vpn_gw", {
 *     tags: {
 *         Name: "main",
 *     },
 *     vpcId: aws_vpc_main.id,
 * });
 * ```
 */
export class VpnGateway extends pulumi.CustomResource {
    /**
     * Get an existing VpnGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpnGatewayState, opts?: pulumi.CustomResourceOptions): VpnGateway {
        return new VpnGateway(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<VpnGatewayResult> {
        return ctx.list({...args, type: 'aws:ec2/vpnGateway:VpnGateway'});
    }

    /**
     * The Autonomous System Number (ASN) for the Amazon side of the gateway. If you don't specify an ASN, the virtual private gateway is created with the default ASN.
     */
    public readonly amazonSideAsn: pulumi.Output<string>;
    /**
     * The Availability Zone for the virtual private gateway.
     */
    public readonly availabilityZone: pulumi.Output<string | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The VPC ID to create in.
     */
    public readonly vpcId: pulumi.Output<string>;

    /**
     * Create a VpnGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: VpnGatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpnGatewayArgs | VpnGatewayState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: VpnGatewayState = argsOrState as VpnGatewayState | undefined;
            inputs["amazonSideAsn"] = state ? state.amazonSideAsn : undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as VpnGatewayArgs | undefined;
            inputs["amazonSideAsn"] = args ? args.amazonSideAsn : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
        }
        super("aws:ec2/vpnGateway:VpnGateway", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpnGateway resources.
 */
export interface VpnGatewayState {
    /**
     * The Autonomous System Number (ASN) for the Amazon side of the gateway. If you don't specify an ASN, the virtual private gateway is created with the default ASN.
     */
    readonly amazonSideAsn?: pulumi.Input<string>;
    /**
     * The Availability Zone for the virtual private gateway.
     */
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID to create in.
     */
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VpnGateway resource.
 */
export interface VpnGatewayArgs {
    /**
     * The Autonomous System Number (ASN) for the Amazon side of the gateway. If you don't specify an ASN, the virtual private gateway is created with the default ASN.
     */
    readonly amazonSideAsn?: pulumi.Input<string>;
    /**
     * The Availability Zone for the virtual private gateway.
     */
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID to create in.
     */
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The live VpnGateway resource.
 */
export interface VpnGatewayResult {
    /**
     * The Autonomous System Number (ASN) for the Amazon side of the gateway. If you don't specify an ASN, the virtual private gateway is created with the default ASN.
     */
    readonly amazonSideAsn: string;
    /**
     * The Availability Zone for the virtual private gateway.
     */
    readonly availabilityZone?: string;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: {[key: string]: any};
    /**
     * The VPC ID to create in.
     */
    readonly vpcId: string;
}
