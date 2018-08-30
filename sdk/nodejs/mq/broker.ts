// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides an MQ Broker Resource. This resources also manages users for the broker.
 * 
 * For more information on Amazon MQ, see [Amazon MQ documentation](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/welcome.html).
 * 
 * Changes to an MQ Broker can occur when you change a
 * parameter, such as `configuration` or `user`, and are reflected in the next maintenance
 * window. Because of this, Terraform may report a difference in its planning
 * phase because a modification has not yet taken place. You can use the
 * `apply_immediately` flag to instruct the service to apply the change immediately
 * (see documentation below).
 * 
 * ~> **Note:** using `apply_immediately` can result in a
 * brief downtime as the broker reboots.
 * 
 * ~> **Note:** All arguments including the username and password will be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 */
export class Broker extends pulumi.CustomResource {
    /**
     * Get an existing Broker resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BrokerState): Broker {
        return new Broker(name, <any>state, { id });
    }

    /**
     * Specifies whether any broker modifications
     * are applied immediately, or during the next maintenance window. Default is `false`.
     */
    public readonly applyImmediately: pulumi.Output<boolean | undefined>;
    /**
     * The ARN of the broker.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * Enables automatic upgrades to new minor versions for brokers, as Apache releases the versions.
     */
    public readonly autoMinorVersionUpgrade: pulumi.Output<boolean | undefined>;
    /**
     * The name of the broker.
     */
    public readonly brokerName: pulumi.Output<string>;
    /**
     * Configuration of the broker. See below.
     */
    public readonly configuration: pulumi.Output<{ id: string, revision: number }>;
    /**
     * The deployment mode of the broker. Supported: `SINGLE_INSTANCE` and `ACTIVE_STANDBY_MULTI_AZ`. Defaults to `SINGLE_INSTANCE`.
     */
    public readonly deploymentMode: pulumi.Output<string | undefined>;
    /**
     * The type of broker engine. Currently, Amazon MQ supports only `ActiveMQ`.
     */
    public readonly engineType: pulumi.Output<string>;
    /**
     * The version of the broker engine. Currently, Amazon MQ supports only `5.15.0`.
     */
    public readonly engineVersion: pulumi.Output<string>;
    /**
     * The broker's instance type. e.g. `mq.t2.micro` or `mq.m4.large`
     */
    public readonly hostInstanceType: pulumi.Output<string>;
    /**
     * A list of information about allocated brokers (both active & standby).
     * * `instances.0.console_url` - The URL of the broker's [ActiveMQ Web Console](http://activemq.apache.org/web-console.html).
     * * `instances.0.endpoints` - The broker's wire-level protocol endpoints in the following order & format referenceable e.g. as `instances.0.endpoints.0` (SSL):
     * * `ssl://broker-id.mq.us-west-2.amazonaws.com:61617`
     * * `amqp+ssl://broker-id.mq.us-west-2.amazonaws.com:5671`
     * * `stomp+ssl://broker-id.mq.us-west-2.amazonaws.com:61614`
     * * `mqtt+ssl://broker-id.mq.us-west-2.amazonaws.com:8883`
     * * `wss://broker-id.mq.us-west-2.amazonaws.com:61619`
     */
    public /*out*/ readonly instances: pulumi.Output<{ consoleUrl: string, endpoints: string[] }[]>;
    /**
     * Maintenance window start time. See below.
     */
    public readonly maintenanceWindowStartTime: pulumi.Output<{ dayOfWeek: string, timeOfDay: string, timeZone: string }>;
    /**
     * Whether to enable connections from applications outside of the VPC that hosts the broker's subnets.
     */
    public readonly publiclyAccessible: pulumi.Output<boolean | undefined>;
    /**
     * The list of security group IDs assigned to the broker.
     */
    public readonly securityGroups: pulumi.Output<string[]>;
    /**
     * The list of subnet IDs in which to launch the broker. A `SINGLE_INSTANCE` deployment requires one subnet. An `ACTIVE_STANDBY_MULTI_AZ` deployment requires two subnets.
     */
    public readonly subnetIds: pulumi.Output<string[]>;
    /**
     * The list of all ActiveMQ usernames for the specified broker. See below.
     */
    public readonly users: pulumi.Output<{ consoleAccess?: boolean, groups?: string[], password: string, username: string }[]>;

    /**
     * Create a Broker resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BrokerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BrokerArgs | BrokerState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: BrokerState = argsOrState as BrokerState | undefined;
            inputs["applyImmediately"] = state ? state.applyImmediately : undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["autoMinorVersionUpgrade"] = state ? state.autoMinorVersionUpgrade : undefined;
            inputs["brokerName"] = state ? state.brokerName : undefined;
            inputs["configuration"] = state ? state.configuration : undefined;
            inputs["deploymentMode"] = state ? state.deploymentMode : undefined;
            inputs["engineType"] = state ? state.engineType : undefined;
            inputs["engineVersion"] = state ? state.engineVersion : undefined;
            inputs["hostInstanceType"] = state ? state.hostInstanceType : undefined;
            inputs["instances"] = state ? state.instances : undefined;
            inputs["maintenanceWindowStartTime"] = state ? state.maintenanceWindowStartTime : undefined;
            inputs["publiclyAccessible"] = state ? state.publiclyAccessible : undefined;
            inputs["securityGroups"] = state ? state.securityGroups : undefined;
            inputs["subnetIds"] = state ? state.subnetIds : undefined;
            inputs["users"] = state ? state.users : undefined;
        } else {
            const args = argsOrState as BrokerArgs | undefined;
            if (!args || args.brokerName === undefined) {
                throw new Error("Missing required property 'brokerName'");
            }
            if (!args || args.engineType === undefined) {
                throw new Error("Missing required property 'engineType'");
            }
            if (!args || args.engineVersion === undefined) {
                throw new Error("Missing required property 'engineVersion'");
            }
            if (!args || args.hostInstanceType === undefined) {
                throw new Error("Missing required property 'hostInstanceType'");
            }
            if (!args || args.securityGroups === undefined) {
                throw new Error("Missing required property 'securityGroups'");
            }
            if (!args || args.users === undefined) {
                throw new Error("Missing required property 'users'");
            }
            inputs["applyImmediately"] = args ? args.applyImmediately : undefined;
            inputs["autoMinorVersionUpgrade"] = args ? args.autoMinorVersionUpgrade : undefined;
            inputs["brokerName"] = args ? args.brokerName : undefined;
            inputs["configuration"] = args ? args.configuration : undefined;
            inputs["deploymentMode"] = args ? args.deploymentMode : undefined;
            inputs["engineType"] = args ? args.engineType : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["hostInstanceType"] = args ? args.hostInstanceType : undefined;
            inputs["maintenanceWindowStartTime"] = args ? args.maintenanceWindowStartTime : undefined;
            inputs["publiclyAccessible"] = args ? args.publiclyAccessible : undefined;
            inputs["securityGroups"] = args ? args.securityGroups : undefined;
            inputs["subnetIds"] = args ? args.subnetIds : undefined;
            inputs["users"] = args ? args.users : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["instances"] = undefined /*out*/;
        }
        super("aws:mq/broker:Broker", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Broker resources.
 */
export interface BrokerState {
    /**
     * Specifies whether any broker modifications
     * are applied immediately, or during the next maintenance window. Default is `false`.
     */
    readonly applyImmediately?: pulumi.Input<boolean>;
    /**
     * The ARN of the broker.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * Enables automatic upgrades to new minor versions for brokers, as Apache releases the versions.
     */
    readonly autoMinorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * The name of the broker.
     */
    readonly brokerName?: pulumi.Input<string>;
    /**
     * Configuration of the broker. See below.
     */
    readonly configuration?: pulumi.Input<{ id?: pulumi.Input<string>, revision?: pulumi.Input<number> }>;
    /**
     * The deployment mode of the broker. Supported: `SINGLE_INSTANCE` and `ACTIVE_STANDBY_MULTI_AZ`. Defaults to `SINGLE_INSTANCE`.
     */
    readonly deploymentMode?: pulumi.Input<string>;
    /**
     * The type of broker engine. Currently, Amazon MQ supports only `ActiveMQ`.
     */
    readonly engineType?: pulumi.Input<string>;
    /**
     * The version of the broker engine. Currently, Amazon MQ supports only `5.15.0`.
     */
    readonly engineVersion?: pulumi.Input<string>;
    /**
     * The broker's instance type. e.g. `mq.t2.micro` or `mq.m4.large`
     */
    readonly hostInstanceType?: pulumi.Input<string>;
    /**
     * A list of information about allocated brokers (both active & standby).
     * * `instances.0.console_url` - The URL of the broker's [ActiveMQ Web Console](http://activemq.apache.org/web-console.html).
     * * `instances.0.endpoints` - The broker's wire-level protocol endpoints in the following order & format referenceable e.g. as `instances.0.endpoints.0` (SSL):
     * * `ssl://broker-id.mq.us-west-2.amazonaws.com:61617`
     * * `amqp+ssl://broker-id.mq.us-west-2.amazonaws.com:5671`
     * * `stomp+ssl://broker-id.mq.us-west-2.amazonaws.com:61614`
     * * `mqtt+ssl://broker-id.mq.us-west-2.amazonaws.com:8883`
     * * `wss://broker-id.mq.us-west-2.amazonaws.com:61619`
     */
    readonly instances?: pulumi.Input<pulumi.Input<{ consoleUrl?: pulumi.Input<string>, endpoints?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * Maintenance window start time. See below.
     */
    readonly maintenanceWindowStartTime?: pulumi.Input<{ dayOfWeek: pulumi.Input<string>, timeOfDay: pulumi.Input<string>, timeZone: pulumi.Input<string> }>;
    /**
     * Whether to enable connections from applications outside of the VPC that hosts the broker's subnets.
     */
    readonly publiclyAccessible?: pulumi.Input<boolean>;
    /**
     * The list of security group IDs assigned to the broker.
     */
    readonly securityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of subnet IDs in which to launch the broker. A `SINGLE_INSTANCE` deployment requires one subnet. An `ACTIVE_STANDBY_MULTI_AZ` deployment requires two subnets.
     */
    readonly subnetIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of all ActiveMQ usernames for the specified broker. See below.
     */
    readonly users?: pulumi.Input<pulumi.Input<{ consoleAccess?: pulumi.Input<boolean>, groups?: pulumi.Input<pulumi.Input<string>[]>, password: pulumi.Input<string>, username: pulumi.Input<string> }>[]>;
}

/**
 * The set of arguments for constructing a Broker resource.
 */
export interface BrokerArgs {
    /**
     * Specifies whether any broker modifications
     * are applied immediately, or during the next maintenance window. Default is `false`.
     */
    readonly applyImmediately?: pulumi.Input<boolean>;
    /**
     * Enables automatic upgrades to new minor versions for brokers, as Apache releases the versions.
     */
    readonly autoMinorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * The name of the broker.
     */
    readonly brokerName: pulumi.Input<string>;
    /**
     * Configuration of the broker. See below.
     */
    readonly configuration?: pulumi.Input<{ id?: pulumi.Input<string>, revision?: pulumi.Input<number> }>;
    /**
     * The deployment mode of the broker. Supported: `SINGLE_INSTANCE` and `ACTIVE_STANDBY_MULTI_AZ`. Defaults to `SINGLE_INSTANCE`.
     */
    readonly deploymentMode?: pulumi.Input<string>;
    /**
     * The type of broker engine. Currently, Amazon MQ supports only `ActiveMQ`.
     */
    readonly engineType: pulumi.Input<string>;
    /**
     * The version of the broker engine. Currently, Amazon MQ supports only `5.15.0`.
     */
    readonly engineVersion: pulumi.Input<string>;
    /**
     * The broker's instance type. e.g. `mq.t2.micro` or `mq.m4.large`
     */
    readonly hostInstanceType: pulumi.Input<string>;
    /**
     * Maintenance window start time. See below.
     */
    readonly maintenanceWindowStartTime?: pulumi.Input<{ dayOfWeek: pulumi.Input<string>, timeOfDay: pulumi.Input<string>, timeZone: pulumi.Input<string> }>;
    /**
     * Whether to enable connections from applications outside of the VPC that hosts the broker's subnets.
     */
    readonly publiclyAccessible?: pulumi.Input<boolean>;
    /**
     * The list of security group IDs assigned to the broker.
     */
    readonly securityGroups: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of subnet IDs in which to launch the broker. A `SINGLE_INSTANCE` deployment requires one subnet. An `ACTIVE_STANDBY_MULTI_AZ` deployment requires two subnets.
     */
    readonly subnetIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of all ActiveMQ usernames for the specified broker. See below.
     */
    readonly users: pulumi.Input<pulumi.Input<{ consoleAccess?: pulumi.Input<boolean>, groups?: pulumi.Input<pulumi.Input<string>[]>, password: pulumi.Input<string>, username: pulumi.Input<string> }>[]>;
}
