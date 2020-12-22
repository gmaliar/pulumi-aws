// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Provides an AppSync Resolver.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const testGraphQLApi = new aws.appsync.GraphQLApi("testGraphQLApi", {
 *     authenticationType: "API_KEY",
 *     schema: `type Mutation {
 * 	putPost(id: ID!, title: String!): Post
 * }
 *
 * type Post {
 * 	id: ID!
 * 	title: String!
 * }
 *
 * type Query {
 * 	singlePost(id: ID!): Post
 * }
 *
 * schema {
 * 	query: Query
 * 	mutation: Mutation
 * }
 * `,
 * });
 * const testDataSource = new aws.appsync.DataSource("testDataSource", {
 *     apiId: testGraphQLApi.id,
 *     name: "tf_example",
 *     type: "HTTP",
 *     httpConfig: {
 *         endpoint: "http://example.com",
 *     },
 * });
 * // UNIT type resolver (default)
 * const testResolver = new aws.appsync.Resolver("testResolver", {
 *     apiId: testGraphQLApi.id,
 *     field: "singlePost",
 *     type: "Query",
 *     dataSource: testDataSource.name,
 *     requestTemplate: `{
 *     "version": "2018-05-29",
 *     "method": "GET",
 *     "resourcePath": "/",
 *     "params":{
 *         "headers": $utils.http.copyheaders($ctx.request.headers)
 *     }
 * }
 * `,
 *     responseTemplate: `#if($ctx.result.statusCode == 200)
 *     $ctx.result.body
 * #else
 *     $utils.appendError($ctx.result.body, $ctx.result.statusCode)
 * #end
 * `,
 *     cachingConfig: {
 *         cachingKeys: [
 *             `$context.identity.sub`,
 *             `$context.arguments.id`,
 *         ],
 *         ttl: 60,
 *     },
 * });
 * // PIPELINE type resolver
 * const mutationPipelineTest = new aws.appsync.Resolver("mutationPipelineTest", {
 *     type: "Mutation",
 *     apiId: testGraphQLApi.id,
 *     field: "pipelineTest",
 *     requestTemplate: "{}",
 *     responseTemplate: `$util.toJson($ctx.result)`,
 *     kind: "PIPELINE",
 *     pipelineConfig: {
 *         functions: [
 *             aws_appsync_function.test1.function_id,
 *             aws_appsync_function.test2.function_id,
 *             aws_appsync_function.test3.function_id,
 *         ],
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * `aws_appsync_resolver` can be imported with their `api_id`, a hyphen, `type`, a hypen and `field` e.g.
 *
 * ```sh
 *  $ pulumi import aws:appsync/resolver:Resolver example abcdef123456-exampleType-exampleField
 * ```
 */
export class Resolver extends pulumi.CustomResource {
    /**
     * Get an existing Resolver resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ResolverState, opts?: pulumi.CustomResourceOptions): Resolver {
        return new Resolver(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:appsync/resolver:Resolver';

    /**
     * Returns true if the given object is an instance of Resolver.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Resolver {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Resolver.__pulumiType;
    }

    /**
     * The API ID for the GraphQL API.
     */
    public readonly apiId!: pulumi.Output<string>;
    /**
     * The ARN
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The CachingConfig.
     */
    public readonly cachingConfig!: pulumi.Output<outputs.appsync.ResolverCachingConfig | undefined>;
    /**
     * The DataSource name.
     */
    public readonly dataSource!: pulumi.Output<string | undefined>;
    /**
     * The field name from the schema defined in the GraphQL API.
     */
    public readonly field!: pulumi.Output<string>;
    /**
     * The resolver type. Valid values are `UNIT` and `PIPELINE`.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * The PipelineConfig.
     */
    public readonly pipelineConfig!: pulumi.Output<outputs.appsync.ResolverPipelineConfig | undefined>;
    /**
     * The request mapping template for UNIT resolver or 'before mapping template' for PIPELINE resolver.
     */
    public readonly requestTemplate!: pulumi.Output<string>;
    /**
     * The response mapping template for UNIT resolver or 'after mapping template' for PIPELINE resolver.
     */
    public readonly responseTemplate!: pulumi.Output<string>;
    /**
     * The type name from the schema defined in the GraphQL API.
     */
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a Resolver resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResolverArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ResolverArgs | ResolverState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ResolverState | undefined;
            inputs["apiId"] = state ? state.apiId : undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["cachingConfig"] = state ? state.cachingConfig : undefined;
            inputs["dataSource"] = state ? state.dataSource : undefined;
            inputs["field"] = state ? state.field : undefined;
            inputs["kind"] = state ? state.kind : undefined;
            inputs["pipelineConfig"] = state ? state.pipelineConfig : undefined;
            inputs["requestTemplate"] = state ? state.requestTemplate : undefined;
            inputs["responseTemplate"] = state ? state.responseTemplate : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as ResolverArgs | undefined;
            if ((!args || args.apiId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.field === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'field'");
            }
            if ((!args || args.requestTemplate === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'requestTemplate'");
            }
            if ((!args || args.responseTemplate === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'responseTemplate'");
            }
            if ((!args || args.type === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'type'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["cachingConfig"] = args ? args.cachingConfig : undefined;
            inputs["dataSource"] = args ? args.dataSource : undefined;
            inputs["field"] = args ? args.field : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["pipelineConfig"] = args ? args.pipelineConfig : undefined;
            inputs["requestTemplate"] = args ? args.requestTemplate : undefined;
            inputs["responseTemplate"] = args ? args.responseTemplate : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Resolver.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Resolver resources.
 */
export interface ResolverState {
    /**
     * The API ID for the GraphQL API.
     */
    readonly apiId?: pulumi.Input<string>;
    /**
     * The ARN
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The CachingConfig.
     */
    readonly cachingConfig?: pulumi.Input<inputs.appsync.ResolverCachingConfig>;
    /**
     * The DataSource name.
     */
    readonly dataSource?: pulumi.Input<string>;
    /**
     * The field name from the schema defined in the GraphQL API.
     */
    readonly field?: pulumi.Input<string>;
    /**
     * The resolver type. Valid values are `UNIT` and `PIPELINE`.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * The PipelineConfig.
     */
    readonly pipelineConfig?: pulumi.Input<inputs.appsync.ResolverPipelineConfig>;
    /**
     * The request mapping template for UNIT resolver or 'before mapping template' for PIPELINE resolver.
     */
    readonly requestTemplate?: pulumi.Input<string>;
    /**
     * The response mapping template for UNIT resolver or 'after mapping template' for PIPELINE resolver.
     */
    readonly responseTemplate?: pulumi.Input<string>;
    /**
     * The type name from the schema defined in the GraphQL API.
     */
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Resolver resource.
 */
export interface ResolverArgs {
    /**
     * The API ID for the GraphQL API.
     */
    readonly apiId: pulumi.Input<string>;
    /**
     * The CachingConfig.
     */
    readonly cachingConfig?: pulumi.Input<inputs.appsync.ResolverCachingConfig>;
    /**
     * The DataSource name.
     */
    readonly dataSource?: pulumi.Input<string>;
    /**
     * The field name from the schema defined in the GraphQL API.
     */
    readonly field: pulumi.Input<string>;
    /**
     * The resolver type. Valid values are `UNIT` and `PIPELINE`.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * The PipelineConfig.
     */
    readonly pipelineConfig?: pulumi.Input<inputs.appsync.ResolverPipelineConfig>;
    /**
     * The request mapping template for UNIT resolver or 'before mapping template' for PIPELINE resolver.
     */
    readonly requestTemplate: pulumi.Input<string>;
    /**
     * The response mapping template for UNIT resolver or 'after mapping template' for PIPELINE resolver.
     */
    readonly responseTemplate: pulumi.Input<string>;
    /**
     * The type name from the schema defined in the GraphQL API.
     */
    readonly type: pulumi.Input<string>;
}
