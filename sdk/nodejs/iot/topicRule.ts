// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";
import * as rxjs from "rxjs";
import * as operators from "rxjs/operators";

/**
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const role = new aws.iam.Role("role", {
 *     assumeRolePolicy: `{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Effect": "Allow",
 *       "Principal": {
 *         "Service": "iot.amazonaws.com"
 *       },
 *       "Action": "sts:AssumeRole"
 *     }
 *   ]
 * }
 * `,
 *     name: "myrole",
 * });
 * const mytopic = new aws.sns.Topic("mytopic", {
 *     name: "mytopic",
 * });
 * const iamPolicyForLambda = new aws.iam.RolePolicy("iam_policy_for_lambda", {
 *     name: "mypolicy",
 *     policy: mytopic.arn.apply(arn => `{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *         "Effect": "Allow",
 *         "Action": [
 *             "sns:Publish"
 *         ],
 *         "Resource": "${arn}"
 *     }
 *   ]
 * }
 * `),
 *     role: role.id,
 * });
 * const rule = new aws.iot.TopicRule("rule", {
 *     description: "Example rule",
 *     enabled: true,
 *     name: "MyRule",
 *     sns: {
 *         messageFormat: "RAW",
 *         roleArn: role.arn,
 *         targetArn: mytopic.arn,
 *     },
 *     sql: "SELECT * FROM 'topic/test'",
 *     sqlVersion: "2015-10-08",
 * });
 * ```
 */
export class TopicRule extends pulumi.CustomResource {
    /**
     * Get an existing TopicRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TopicRuleState, opts?: pulumi.CustomResourceOptions): TopicRule {
        return new TopicRule(name, <any>state, { ...opts, id: id });
    }

    public static list(ctx: pulumi.query.ListContext, args?: pulumi.query.ListArgs): rxjs.Observable<TopicRuleResult> {
        return ctx.list({...args, type: 'aws:iot/topicRule:TopicRule'});
    }

    /**
     * The ARN of the topic rule
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    public readonly cloudwatchAlarm: pulumi.Output<{ alarmName: string, roleArn: string, stateReason: string, stateValue: string } | undefined>;
    public readonly cloudwatchMetric: pulumi.Output<{ metricName: string, metricNamespace: string, metricTimestamp?: string, metricUnit: string, metricValue: string, roleArn: string } | undefined>;
    /**
     * The description of the rule.
     */
    public readonly description: pulumi.Output<string | undefined>;
    public readonly dynamodb: pulumi.Output<{ hashKeyField: string, hashKeyType?: string, hashKeyValue: string, payloadField?: string, rangeKeyField: string, rangeKeyType?: string, rangeKeyValue: string, roleArn: string, tableName: string } | undefined>;
    public readonly elasticsearch: pulumi.Output<{ endpoint: string, id: string, index: string, roleArn: string, type: string } | undefined>;
    /**
     * Specifies whether the rule is enabled.
     */
    public readonly enabled: pulumi.Output<boolean>;
    public readonly firehose: pulumi.Output<{ deliveryStreamName: string, roleArn: string, separator?: string } | undefined>;
    public readonly kinesis: pulumi.Output<{ partitionKey?: string, roleArn: string, streamName: string } | undefined>;
    public readonly lambda: pulumi.Output<{ functionArn: string } | undefined>;
    /**
     * The name of the rule.
     */
    public readonly name: pulumi.Output<string>;
    public readonly republish: pulumi.Output<{ roleArn: string, topic: string } | undefined>;
    public readonly s3: pulumi.Output<{ bucketName: string, key: string, roleArn: string } | undefined>;
    public readonly sns: pulumi.Output<{ messageFormat?: string, roleArn: string, targetArn: string } | undefined>;
    /**
     * The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.
     */
    public readonly sql: pulumi.Output<string>;
    /**
     * The version of the SQL rules engine to use when evaluating the rule.
     */
    public readonly sqlVersion: pulumi.Output<string>;
    public readonly sqs: pulumi.Output<{ queueUrl: string, roleArn: string, useBase64: boolean } | undefined>;

    /**
     * Create a TopicRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TopicRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TopicRuleArgs | TopicRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: TopicRuleState = argsOrState as TopicRuleState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["cloudwatchAlarm"] = state ? state.cloudwatchAlarm : undefined;
            inputs["cloudwatchMetric"] = state ? state.cloudwatchMetric : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["dynamodb"] = state ? state.dynamodb : undefined;
            inputs["elasticsearch"] = state ? state.elasticsearch : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["firehose"] = state ? state.firehose : undefined;
            inputs["kinesis"] = state ? state.kinesis : undefined;
            inputs["lambda"] = state ? state.lambda : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["republish"] = state ? state.republish : undefined;
            inputs["s3"] = state ? state.s3 : undefined;
            inputs["sns"] = state ? state.sns : undefined;
            inputs["sql"] = state ? state.sql : undefined;
            inputs["sqlVersion"] = state ? state.sqlVersion : undefined;
            inputs["sqs"] = state ? state.sqs : undefined;
        } else {
            const args = argsOrState as TopicRuleArgs | undefined;
            if (!args || args.enabled === undefined) {
                throw new Error("Missing required property 'enabled'");
            }
            if (!args || args.sql === undefined) {
                throw new Error("Missing required property 'sql'");
            }
            if (!args || args.sqlVersion === undefined) {
                throw new Error("Missing required property 'sqlVersion'");
            }
            inputs["cloudwatchAlarm"] = args ? args.cloudwatchAlarm : undefined;
            inputs["cloudwatchMetric"] = args ? args.cloudwatchMetric : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["dynamodb"] = args ? args.dynamodb : undefined;
            inputs["elasticsearch"] = args ? args.elasticsearch : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["firehose"] = args ? args.firehose : undefined;
            inputs["kinesis"] = args ? args.kinesis : undefined;
            inputs["lambda"] = args ? args.lambda : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["republish"] = args ? args.republish : undefined;
            inputs["s3"] = args ? args.s3 : undefined;
            inputs["sns"] = args ? args.sns : undefined;
            inputs["sql"] = args ? args.sql : undefined;
            inputs["sqlVersion"] = args ? args.sqlVersion : undefined;
            inputs["sqs"] = args ? args.sqs : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        super("aws:iot/topicRule:TopicRule", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TopicRule resources.
 */
export interface TopicRuleState {
    /**
     * The ARN of the topic rule
     */
    readonly arn?: pulumi.Input<string>;
    readonly cloudwatchAlarm?: pulumi.Input<{ alarmName: pulumi.Input<string>, roleArn: pulumi.Input<string>, stateReason: pulumi.Input<string>, stateValue: pulumi.Input<string> }>;
    readonly cloudwatchMetric?: pulumi.Input<{ metricName: pulumi.Input<string>, metricNamespace: pulumi.Input<string>, metricTimestamp?: pulumi.Input<string>, metricUnit: pulumi.Input<string>, metricValue: pulumi.Input<string>, roleArn: pulumi.Input<string> }>;
    /**
     * The description of the rule.
     */
    readonly description?: pulumi.Input<string>;
    readonly dynamodb?: pulumi.Input<{ hashKeyField: pulumi.Input<string>, hashKeyType?: pulumi.Input<string>, hashKeyValue: pulumi.Input<string>, payloadField?: pulumi.Input<string>, rangeKeyField: pulumi.Input<string>, rangeKeyType?: pulumi.Input<string>, rangeKeyValue: pulumi.Input<string>, roleArn: pulumi.Input<string>, tableName: pulumi.Input<string> }>;
    readonly elasticsearch?: pulumi.Input<{ endpoint: pulumi.Input<string>, id: pulumi.Input<string>, index: pulumi.Input<string>, roleArn: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * Specifies whether the rule is enabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
    readonly firehose?: pulumi.Input<{ deliveryStreamName: pulumi.Input<string>, roleArn: pulumi.Input<string>, separator?: pulumi.Input<string> }>;
    readonly kinesis?: pulumi.Input<{ partitionKey?: pulumi.Input<string>, roleArn: pulumi.Input<string>, streamName: pulumi.Input<string> }>;
    readonly lambda?: pulumi.Input<{ functionArn: pulumi.Input<string> }>;
    /**
     * The name of the rule.
     */
    readonly name?: pulumi.Input<string>;
    readonly republish?: pulumi.Input<{ roleArn: pulumi.Input<string>, topic: pulumi.Input<string> }>;
    readonly s3?: pulumi.Input<{ bucketName: pulumi.Input<string>, key: pulumi.Input<string>, roleArn: pulumi.Input<string> }>;
    readonly sns?: pulumi.Input<{ messageFormat?: pulumi.Input<string>, roleArn: pulumi.Input<string>, targetArn: pulumi.Input<string> }>;
    /**
     * The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.
     */
    readonly sql?: pulumi.Input<string>;
    /**
     * The version of the SQL rules engine to use when evaluating the rule.
     */
    readonly sqlVersion?: pulumi.Input<string>;
    readonly sqs?: pulumi.Input<{ queueUrl: pulumi.Input<string>, roleArn: pulumi.Input<string>, useBase64: pulumi.Input<boolean> }>;
}

/**
 * The set of arguments for constructing a TopicRule resource.
 */
export interface TopicRuleArgs {
    readonly cloudwatchAlarm?: pulumi.Input<{ alarmName: pulumi.Input<string>, roleArn: pulumi.Input<string>, stateReason: pulumi.Input<string>, stateValue: pulumi.Input<string> }>;
    readonly cloudwatchMetric?: pulumi.Input<{ metricName: pulumi.Input<string>, metricNamespace: pulumi.Input<string>, metricTimestamp?: pulumi.Input<string>, metricUnit: pulumi.Input<string>, metricValue: pulumi.Input<string>, roleArn: pulumi.Input<string> }>;
    /**
     * The description of the rule.
     */
    readonly description?: pulumi.Input<string>;
    readonly dynamodb?: pulumi.Input<{ hashKeyField: pulumi.Input<string>, hashKeyType?: pulumi.Input<string>, hashKeyValue: pulumi.Input<string>, payloadField?: pulumi.Input<string>, rangeKeyField: pulumi.Input<string>, rangeKeyType?: pulumi.Input<string>, rangeKeyValue: pulumi.Input<string>, roleArn: pulumi.Input<string>, tableName: pulumi.Input<string> }>;
    readonly elasticsearch?: pulumi.Input<{ endpoint: pulumi.Input<string>, id: pulumi.Input<string>, index: pulumi.Input<string>, roleArn: pulumi.Input<string>, type: pulumi.Input<string> }>;
    /**
     * Specifies whether the rule is enabled.
     */
    readonly enabled: pulumi.Input<boolean>;
    readonly firehose?: pulumi.Input<{ deliveryStreamName: pulumi.Input<string>, roleArn: pulumi.Input<string>, separator?: pulumi.Input<string> }>;
    readonly kinesis?: pulumi.Input<{ partitionKey?: pulumi.Input<string>, roleArn: pulumi.Input<string>, streamName: pulumi.Input<string> }>;
    readonly lambda?: pulumi.Input<{ functionArn: pulumi.Input<string> }>;
    /**
     * The name of the rule.
     */
    readonly name?: pulumi.Input<string>;
    readonly republish?: pulumi.Input<{ roleArn: pulumi.Input<string>, topic: pulumi.Input<string> }>;
    readonly s3?: pulumi.Input<{ bucketName: pulumi.Input<string>, key: pulumi.Input<string>, roleArn: pulumi.Input<string> }>;
    readonly sns?: pulumi.Input<{ messageFormat?: pulumi.Input<string>, roleArn: pulumi.Input<string>, targetArn: pulumi.Input<string> }>;
    /**
     * The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.
     */
    readonly sql: pulumi.Input<string>;
    /**
     * The version of the SQL rules engine to use when evaluating the rule.
     */
    readonly sqlVersion: pulumi.Input<string>;
    readonly sqs?: pulumi.Input<{ queueUrl: pulumi.Input<string>, roleArn: pulumi.Input<string>, useBase64: pulumi.Input<boolean> }>;
}

/**
 * The live TopicRule resource.
 */
export interface TopicRuleResult {
    /**
     * The ARN of the topic rule
     */
    readonly arn: string;
    readonly cloudwatchAlarm?: { alarmName: string, roleArn: string, stateReason: string, stateValue: string };
    readonly cloudwatchMetric?: { metricName: string, metricNamespace: string, metricTimestamp?: string, metricUnit: string, metricValue: string, roleArn: string };
    /**
     * The description of the rule.
     */
    readonly description?: string;
    readonly dynamodb?: { hashKeyField: string, hashKeyType?: string, hashKeyValue: string, payloadField?: string, rangeKeyField: string, rangeKeyType?: string, rangeKeyValue: string, roleArn: string, tableName: string };
    readonly elasticsearch?: { endpoint: string, id: string, index: string, roleArn: string, type: string };
    /**
     * Specifies whether the rule is enabled.
     */
    readonly enabled: boolean;
    readonly firehose?: { deliveryStreamName: string, roleArn: string, separator?: string };
    readonly kinesis?: { partitionKey?: string, roleArn: string, streamName: string };
    readonly lambda?: { functionArn: string };
    /**
     * The name of the rule.
     */
    readonly name: string;
    readonly republish?: { roleArn: string, topic: string };
    readonly s3?: { bucketName: string, key: string, roleArn: string };
    readonly sns?: { messageFormat?: string, roleArn: string, targetArn: string };
    /**
     * The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.
     */
    readonly sql: string;
    /**
     * The version of the SQL rules engine to use when evaluating the rule.
     */
    readonly sqlVersion: string;
    readonly sqs?: { queueUrl: string, roleArn: string, useBase64: boolean };
}
