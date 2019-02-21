// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * ## Example Usage
 * 
 * Basic usage:
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.worklink.Fleet("example", {
 *     name: "terraform-example",
 * });
 * ```
 * 
 * Network Configuration Usage:
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.worklink.Fleet("example", {
 *     name: "terraform-example",
 *     network: {
 *         securityGroupIds: [aws_security_group_test.id],
 *         subnetIds: [aws_subnet_test.map(v => v.id)],
 *         vpcId: aws_vpc_test.id,
 *     },
 * });
 * ```
 * 
 * Identity Provider Configuration Usage:
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * import * as fs from "fs";
 * 
 * const test = new aws.worklink.Fleet("test", {
 *     identityProvider: {
 *         samlMetadata: fs.readFileSync("saml-metadata.xml", "utf-8"),
 *         type: "SAML",
 *     },
 *     name: "tf-worklink-fleet-%s",
 * });
 * ```
 */
export class Fleet extends pulumi.CustomResource {
    /**
     * Get an existing Fleet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FleetState, opts?: pulumi.CustomResourceOptions): Fleet {
        return new Fleet(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<FleetResult> {
        return ctx.list({...args, type: 'aws:worklink/fleet:Fleet'});
    }

    /**
     * The ARN of the created WorkLink Fleet.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * The ARN of the Amazon Kinesis data stream that receives the audit events.
     */
    public readonly auditStreamArn: pulumi.Output<string | undefined>;
    /**
     * The identifier used by users to sign in to the Amazon WorkLink app.
     */
    public /*out*/ readonly companyCode: pulumi.Output<string>;
    /**
     * The time that the fleet was created.
     */
    public /*out*/ readonly createdTime: pulumi.Output<string>;
    /**
     * The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
     */
    public readonly deviceCaCertificate: pulumi.Output<string | undefined>;
    /**
     * The name of the fleet.
     */
    public readonly displayName: pulumi.Output<string | undefined>;
    /**
     * Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
     */
    public readonly identityProvider: pulumi.Output<{ samlMetadata: string, type: string } | undefined>;
    /**
     * The time that the fleet was last updated.
     */
    public /*out*/ readonly lastUpdatedTime: pulumi.Output<string>;
    /**
     * A region-unique name for the AMI.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Provide this to allow manage the company network configuration for the fleet. Fields documented below.
     */
    public readonly network: pulumi.Output<{ securityGroupIds: string[], subnetIds: string[], vpcId: string } | undefined>;
    /**
     * The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
     */
    public readonly optimizeForEndUserLocation: pulumi.Output<boolean | undefined>;

    /**
     * Create a Fleet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FleetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FleetArgs | FleetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: FleetState = argsOrState as FleetState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["auditStreamArn"] = state ? state.auditStreamArn : undefined;
            inputs["companyCode"] = state ? state.companyCode : undefined;
            inputs["createdTime"] = state ? state.createdTime : undefined;
            inputs["deviceCaCertificate"] = state ? state.deviceCaCertificate : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["identityProvider"] = state ? state.identityProvider : undefined;
            inputs["lastUpdatedTime"] = state ? state.lastUpdatedTime : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["network"] = state ? state.network : undefined;
            inputs["optimizeForEndUserLocation"] = state ? state.optimizeForEndUserLocation : undefined;
        } else {
            const args = argsOrState as FleetArgs | undefined;
            inputs["auditStreamArn"] = args ? args.auditStreamArn : undefined;
            inputs["deviceCaCertificate"] = args ? args.deviceCaCertificate : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["identityProvider"] = args ? args.identityProvider : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["network"] = args ? args.network : undefined;
            inputs["optimizeForEndUserLocation"] = args ? args.optimizeForEndUserLocation : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["companyCode"] = undefined /*out*/;
            inputs["createdTime"] = undefined /*out*/;
            inputs["lastUpdatedTime"] = undefined /*out*/;
        }
        super("aws:worklink/fleet:Fleet", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Fleet resources.
 */
export interface FleetState {
    /**
     * The ARN of the created WorkLink Fleet.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The ARN of the Amazon Kinesis data stream that receives the audit events.
     */
    readonly auditStreamArn?: pulumi.Input<string>;
    /**
     * The identifier used by users to sign in to the Amazon WorkLink app.
     */
    readonly companyCode?: pulumi.Input<string>;
    /**
     * The time that the fleet was created.
     */
    readonly createdTime?: pulumi.Input<string>;
    /**
     * The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
     */
    readonly deviceCaCertificate?: pulumi.Input<string>;
    /**
     * The name of the fleet.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
     */
    readonly identityProvider?: pulumi.Input<{ samlMetadata: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * The time that the fleet was last updated.
     */
    readonly lastUpdatedTime?: pulumi.Input<string>;
    /**
     * A region-unique name for the AMI.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Provide this to allow manage the company network configuration for the fleet. Fields documented below.
     */
    readonly network?: pulumi.Input<{ securityGroupIds: pulumi.Input<pulumi.Input<string>[]>, subnetIds: pulumi.Input<pulumi.Input<string>[]>, vpcId: pulumi.Input<string> }>;
    /**
     * The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
     */
    readonly optimizeForEndUserLocation?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a Fleet resource.
 */
export interface FleetArgs {
    /**
     * The ARN of the Amazon Kinesis data stream that receives the audit events.
     */
    readonly auditStreamArn?: pulumi.Input<string>;
    /**
     * The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
     */
    readonly deviceCaCertificate?: pulumi.Input<string>;
    /**
     * The name of the fleet.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
     */
    readonly identityProvider?: pulumi.Input<{ samlMetadata: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * A region-unique name for the AMI.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Provide this to allow manage the company network configuration for the fleet. Fields documented below.
     */
    readonly network?: pulumi.Input<{ securityGroupIds: pulumi.Input<pulumi.Input<string>[]>, subnetIds: pulumi.Input<pulumi.Input<string>[]>, vpcId: pulumi.Input<string> }>;
    /**
     * The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
     */
    readonly optimizeForEndUserLocation?: pulumi.Input<boolean>;
}

/**
 * The live Fleet resource.
 */
export interface FleetResult {
    /**
     * The ARN of the created WorkLink Fleet.
     */
    readonly arn: string;
    /**
     * The ARN of the Amazon Kinesis data stream that receives the audit events.
     */
    readonly auditStreamArn?: string;
    /**
     * The identifier used by users to sign in to the Amazon WorkLink app.
     */
    readonly companyCode: string;
    /**
     * The time that the fleet was created.
     */
    readonly createdTime: string;
    /**
     * The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
     */
    readonly deviceCaCertificate?: string;
    /**
     * The name of the fleet.
     */
    readonly displayName?: string;
    /**
     * Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
     */
    readonly identityProvider?: { samlMetadata: string, type: string };
    /**
     * The time that the fleet was last updated.
     */
    readonly lastUpdatedTime: string;
    /**
     * A region-unique name for the AMI.
     */
    readonly name: string;
    /**
     * Provide this to allow manage the company network configuration for the fleet. Fields documented below.
     */
    readonly network?: { securityGroupIds: string[], subnetIds: string[], vpcId: string };
    /**
     * The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
     */
    readonly optimizeForEndUserLocation?: boolean;
}
