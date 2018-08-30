// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

import {Tags} from "../index";

/**
 * Provides a resource to manage a Default VPC Routing Table.
 * 
 * Each VPC created in AWS comes with a Default Route Table that can be managed, but not
 * destroyed. **This is an advanced resource**, and has special caveats to be aware
 * of when using it. Please read this document in its entirety before using this
 * resource. It is recommended you **do not** use both `aws_default_route_table` to
 * manage the default route table **and** use the `aws_main_route_table_association`,
 * due to possible conflict in routes.
 * 
 * The `aws_default_route_table` behaves differently from normal resources, in that
 * Terraform does not _create_ this resource, but instead attempts to "adopt" it
 * into management. We can do this because each VPC created has a Default Route
 * Table that cannot be destroyed, and is created with a single route.
 * 
 * When Terraform first adopts the Default Route Table, it **immediately removes all
 * defined routes**. It then proceeds to create any routes specified in the
 * configuration. This step is required so that only the routes specified in the
 * configuration present in the Default Route Table.
 * 
 * For more information about Route Tables, see the AWS Documentation on
 * [Route Tables][aws-route-tables].
 * 
 * For more information about managing normal Route Tables in Terraform, see our
 * documentation on [aws_route_table][tf-route-tables].
 * 
 * ~> **NOTE on Route Tables and Routes:** Terraform currently
 * provides both a standalone Route resource and a Route Table resource with routes
 * defined in-line. At this time you cannot use a Route Table with in-line routes
 * in conjunction with any Route resources. Doing so will cause
 * a conflict of rule settings and will overwrite routes.
 * 
 */
export class DefaultRouteTable extends pulumi.CustomResource {
    /**
     * Get an existing DefaultRouteTable resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DefaultRouteTableState): DefaultRouteTable {
        return new DefaultRouteTable(name, <any>state, { id });
    }

    /**
     * The ID of the Default Routing Table.
     */
    public readonly defaultRouteTableId: pulumi.Output<string>;
    /**
     * A list of virtual gateways for propagation.
     */
    public readonly propagatingVgws: pulumi.Output<string[] | undefined>;
    /**
     * A list of route objects. Their keys are documented below.
     */
    public readonly routes: pulumi.Output<{ cidrBlock?: string, egressOnlyGatewayId?: string, gatewayId?: string, instanceId?: string, ipv6CidrBlock?: string, natGatewayId?: string, networkInterfaceId?: string, vpcPeeringConnectionId?: string }[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<Tags | undefined>;
    public /*out*/ readonly vpcId: pulumi.Output<string>;

    /**
     * Create a DefaultRouteTable resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DefaultRouteTableArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DefaultRouteTableArgs | DefaultRouteTableState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: DefaultRouteTableState = argsOrState as DefaultRouteTableState | undefined;
            inputs["defaultRouteTableId"] = state ? state.defaultRouteTableId : undefined;
            inputs["propagatingVgws"] = state ? state.propagatingVgws : undefined;
            inputs["routes"] = state ? state.routes : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as DefaultRouteTableArgs | undefined;
            if (!args || args.defaultRouteTableId === undefined) {
                throw new Error("Missing required property 'defaultRouteTableId'");
            }
            inputs["defaultRouteTableId"] = args ? args.defaultRouteTableId : undefined;
            inputs["propagatingVgws"] = args ? args.propagatingVgws : undefined;
            inputs["routes"] = args ? args.routes : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcId"] = undefined /*out*/;
        }
        super("aws:ec2/defaultRouteTable:DefaultRouteTable", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DefaultRouteTable resources.
 */
export interface DefaultRouteTableState {
    /**
     * The ID of the Default Routing Table.
     */
    readonly defaultRouteTableId?: pulumi.Input<string>;
    /**
     * A list of virtual gateways for propagation.
     */
    readonly propagatingVgws?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of route objects. Their keys are documented below.
     */
    readonly routes?: pulumi.Input<pulumi.Input<{ cidrBlock?: pulumi.Input<string>, egressOnlyGatewayId?: pulumi.Input<string>, gatewayId?: pulumi.Input<string>, instanceId?: pulumi.Input<string>, ipv6CidrBlock?: pulumi.Input<string>, natGatewayId?: pulumi.Input<string>, networkInterfaceId?: pulumi.Input<string>, vpcPeeringConnectionId?: pulumi.Input<string> }>[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<Tags>;
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DefaultRouteTable resource.
 */
export interface DefaultRouteTableArgs {
    /**
     * The ID of the Default Routing Table.
     */
    readonly defaultRouteTableId: pulumi.Input<string>;
    /**
     * A list of virtual gateways for propagation.
     */
    readonly propagatingVgws?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of route objects. Their keys are documented below.
     */
    readonly routes?: pulumi.Input<pulumi.Input<{ cidrBlock?: pulumi.Input<string>, egressOnlyGatewayId?: pulumi.Input<string>, gatewayId?: pulumi.Input<string>, instanceId?: pulumi.Input<string>, ipv6CidrBlock?: pulumi.Input<string>, natGatewayId?: pulumi.Input<string>, networkInterfaceId?: pulumi.Input<string>, vpcPeeringConnectionId?: pulumi.Input<string> }>[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<Tags>;
}
