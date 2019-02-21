// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * Provides an SES receipt rule resource
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * // Add a header to the email and store it in S3
 * const store = new aws.ses.ReceiptRule("store", {
 *     addHeaderActions: [{
 *         headerName: "Custom-Header",
 *         headerValue: "Added by SES",
 *     }],
 *     enabled: true,
 *     name: "store",
 *     recipients: ["karen@example.com"],
 *     ruleSetName: "default-rule-set",
 *     s3Actions: [{
 *         bucketName: "emails",
 *     }],
 *     scanEnabled: true,
 * });
 * ```
 */
export class ReceiptRule extends pulumi.CustomResource {
    /**
     * Get an existing ReceiptRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ReceiptRuleState, opts?: pulumi.CustomResourceOptions): ReceiptRule {
        return new ReceiptRule(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<ReceiptRuleResult> {
        return ctx.list({...args, type: 'aws:ses/receiptRule:ReceiptRule'});
    }

    /**
     * A list of Add Header Action blocks. Documented below.
     */
    public readonly addHeaderActions: pulumi.Output<{ headerName: string, headerValue: string, position: number }[] | undefined>;
    /**
     * The name of the rule to place this rule after
     */
    public readonly after: pulumi.Output<string | undefined>;
    /**
     * A list of Bounce Action blocks. Documented below.
     */
    public readonly bounceActions: pulumi.Output<{ message: string, position: number, sender: string, smtpReplyCode: string, statusCode?: string, topicArn?: string }[] | undefined>;
    /**
     * If true, the rule will be enabled
     */
    public readonly enabled: pulumi.Output<boolean>;
    /**
     * A list of Lambda Action blocks. Documented below.
     */
    public readonly lambdaActions: pulumi.Output<{ functionArn: string, invocationType: string, position: number, topicArn?: string }[] | undefined>;
    /**
     * The name of the rule
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A list of email addresses
     */
    public readonly recipients: pulumi.Output<string[] | undefined>;
    /**
     * The name of the rule set
     */
    public readonly ruleSetName: pulumi.Output<string>;
    /**
     * A list of S3 Action blocks. Documented below.
     */
    public readonly s3Actions: pulumi.Output<{ bucketName: string, kmsKeyArn?: string, objectKeyPrefix?: string, position: number, topicArn?: string }[] | undefined>;
    /**
     * If true, incoming emails will be scanned for spam and viruses
     */
    public readonly scanEnabled: pulumi.Output<boolean>;
    /**
     * A list of SNS Action blocks. Documented below.
     */
    public readonly snsActions: pulumi.Output<{ position: number, topicArn: string }[] | undefined>;
    /**
     * A list of Stop Action blocks. Documented below.
     */
    public readonly stopActions: pulumi.Output<{ position: number, scope: string, topicArn?: string }[] | undefined>;
    /**
     * Require or Optional
     */
    public readonly tlsPolicy: pulumi.Output<string>;
    /**
     * A list of WorkMail Action blocks. Documented below.
     */
    public readonly workmailActions: pulumi.Output<{ organizationArn: string, position: number, topicArn?: string }[] | undefined>;

    /**
     * Create a ReceiptRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReceiptRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ReceiptRuleArgs | ReceiptRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ReceiptRuleState = argsOrState as ReceiptRuleState | undefined;
            inputs["addHeaderActions"] = state ? state.addHeaderActions : undefined;
            inputs["after"] = state ? state.after : undefined;
            inputs["bounceActions"] = state ? state.bounceActions : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["lambdaActions"] = state ? state.lambdaActions : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["recipients"] = state ? state.recipients : undefined;
            inputs["ruleSetName"] = state ? state.ruleSetName : undefined;
            inputs["s3Actions"] = state ? state.s3Actions : undefined;
            inputs["scanEnabled"] = state ? state.scanEnabled : undefined;
            inputs["snsActions"] = state ? state.snsActions : undefined;
            inputs["stopActions"] = state ? state.stopActions : undefined;
            inputs["tlsPolicy"] = state ? state.tlsPolicy : undefined;
            inputs["workmailActions"] = state ? state.workmailActions : undefined;
        } else {
            const args = argsOrState as ReceiptRuleArgs | undefined;
            if (!args || args.ruleSetName === undefined) {
                throw new Error("Missing required property 'ruleSetName'");
            }
            inputs["addHeaderActions"] = args ? args.addHeaderActions : undefined;
            inputs["after"] = args ? args.after : undefined;
            inputs["bounceActions"] = args ? args.bounceActions : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["lambdaActions"] = args ? args.lambdaActions : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["recipients"] = args ? args.recipients : undefined;
            inputs["ruleSetName"] = args ? args.ruleSetName : undefined;
            inputs["s3Actions"] = args ? args.s3Actions : undefined;
            inputs["scanEnabled"] = args ? args.scanEnabled : undefined;
            inputs["snsActions"] = args ? args.snsActions : undefined;
            inputs["stopActions"] = args ? args.stopActions : undefined;
            inputs["tlsPolicy"] = args ? args.tlsPolicy : undefined;
            inputs["workmailActions"] = args ? args.workmailActions : undefined;
        }
        super("aws:ses/receiptRule:ReceiptRule", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ReceiptRule resources.
 */
export interface ReceiptRuleState {
    /**
     * A list of Add Header Action blocks. Documented below.
     */
    readonly addHeaderActions?: pulumi.Input<pulumi.Input<{ headerName: pulumi.Input<string>, headerValue: pulumi.Input<string>, position: pulumi.Input<number> }>[]>;
    /**
     * The name of the rule to place this rule after
     */
    readonly after?: pulumi.Input<string>;
    /**
     * A list of Bounce Action blocks. Documented below.
     */
    readonly bounceActions?: pulumi.Input<pulumi.Input<{ message: pulumi.Input<string>, position: pulumi.Input<number>, sender: pulumi.Input<string>, smtpReplyCode: pulumi.Input<string>, statusCode?: pulumi.Input<string>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * If true, the rule will be enabled
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * A list of Lambda Action blocks. Documented below.
     */
    readonly lambdaActions?: pulumi.Input<pulumi.Input<{ functionArn: pulumi.Input<string>, invocationType?: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * The name of the rule
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of email addresses
     */
    readonly recipients?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the rule set
     */
    readonly ruleSetName?: pulumi.Input<string>;
    /**
     * A list of S3 Action blocks. Documented below.
     */
    readonly s3Actions?: pulumi.Input<pulumi.Input<{ bucketName: pulumi.Input<string>, kmsKeyArn?: pulumi.Input<string>, objectKeyPrefix?: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * If true, incoming emails will be scanned for spam and viruses
     */
    readonly scanEnabled?: pulumi.Input<boolean>;
    /**
     * A list of SNS Action blocks. Documented below.
     */
    readonly snsActions?: pulumi.Input<pulumi.Input<{ position: pulumi.Input<number>, topicArn: pulumi.Input<string> }>[]>;
    /**
     * A list of Stop Action blocks. Documented below.
     */
    readonly stopActions?: pulumi.Input<pulumi.Input<{ position: pulumi.Input<number>, scope: pulumi.Input<string>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * Require or Optional
     */
    readonly tlsPolicy?: pulumi.Input<string>;
    /**
     * A list of WorkMail Action blocks. Documented below.
     */
    readonly workmailActions?: pulumi.Input<pulumi.Input<{ organizationArn: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
}

/**
 * The set of arguments for constructing a ReceiptRule resource.
 */
export interface ReceiptRuleArgs {
    /**
     * A list of Add Header Action blocks. Documented below.
     */
    readonly addHeaderActions?: pulumi.Input<pulumi.Input<{ headerName: pulumi.Input<string>, headerValue: pulumi.Input<string>, position: pulumi.Input<number> }>[]>;
    /**
     * The name of the rule to place this rule after
     */
    readonly after?: pulumi.Input<string>;
    /**
     * A list of Bounce Action blocks. Documented below.
     */
    readonly bounceActions?: pulumi.Input<pulumi.Input<{ message: pulumi.Input<string>, position: pulumi.Input<number>, sender: pulumi.Input<string>, smtpReplyCode: pulumi.Input<string>, statusCode?: pulumi.Input<string>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * If true, the rule will be enabled
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * A list of Lambda Action blocks. Documented below.
     */
    readonly lambdaActions?: pulumi.Input<pulumi.Input<{ functionArn: pulumi.Input<string>, invocationType?: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * The name of the rule
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of email addresses
     */
    readonly recipients?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the rule set
     */
    readonly ruleSetName: pulumi.Input<string>;
    /**
     * A list of S3 Action blocks. Documented below.
     */
    readonly s3Actions?: pulumi.Input<pulumi.Input<{ bucketName: pulumi.Input<string>, kmsKeyArn?: pulumi.Input<string>, objectKeyPrefix?: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * If true, incoming emails will be scanned for spam and viruses
     */
    readonly scanEnabled?: pulumi.Input<boolean>;
    /**
     * A list of SNS Action blocks. Documented below.
     */
    readonly snsActions?: pulumi.Input<pulumi.Input<{ position: pulumi.Input<number>, topicArn: pulumi.Input<string> }>[]>;
    /**
     * A list of Stop Action blocks. Documented below.
     */
    readonly stopActions?: pulumi.Input<pulumi.Input<{ position: pulumi.Input<number>, scope: pulumi.Input<string>, topicArn?: pulumi.Input<string> }>[]>;
    /**
     * Require or Optional
     */
    readonly tlsPolicy?: pulumi.Input<string>;
    /**
     * A list of WorkMail Action blocks. Documented below.
     */
    readonly workmailActions?: pulumi.Input<pulumi.Input<{ organizationArn: pulumi.Input<string>, position: pulumi.Input<number>, topicArn?: pulumi.Input<string> }>[]>;
}

/**
 * The live ReceiptRule resource.
 */
export interface ReceiptRuleResult {
    /**
     * A list of Add Header Action blocks. Documented below.
     */
    readonly addHeaderActions?: { headerName: string, headerValue: string, position: number }[];
    /**
     * The name of the rule to place this rule after
     */
    readonly after?: string;
    /**
     * A list of Bounce Action blocks. Documented below.
     */
    readonly bounceActions?: { message: string, position: number, sender: string, smtpReplyCode: string, statusCode?: string, topicArn?: string }[];
    /**
     * If true, the rule will be enabled
     */
    readonly enabled: boolean;
    /**
     * A list of Lambda Action blocks. Documented below.
     */
    readonly lambdaActions?: { functionArn: string, invocationType: string, position: number, topicArn?: string }[];
    /**
     * The name of the rule
     */
    readonly name: string;
    /**
     * A list of email addresses
     */
    readonly recipients?: string[];
    /**
     * The name of the rule set
     */
    readonly ruleSetName: string;
    /**
     * A list of S3 Action blocks. Documented below.
     */
    readonly s3Actions?: { bucketName: string, kmsKeyArn?: string, objectKeyPrefix?: string, position: number, topicArn?: string }[];
    /**
     * If true, incoming emails will be scanned for spam and viruses
     */
    readonly scanEnabled: boolean;
    /**
     * A list of SNS Action blocks. Documented below.
     */
    readonly snsActions?: { position: number, topicArn: string }[];
    /**
     * A list of Stop Action blocks. Documented below.
     */
    readonly stopActions?: { position: number, scope: string, topicArn?: string }[];
    /**
     * Require or Optional
     */
    readonly tlsPolicy: string;
    /**
     * A list of WorkMail Action blocks. Documented below.
     */
    readonly workmailActions?: { organizationArn: string, position: number, topicArn?: string }[];
}
