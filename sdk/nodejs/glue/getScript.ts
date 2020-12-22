// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to generate a Glue script from a Directed Acyclic Graph (DAG).
 *
 * ## Example Usage
 * ### Generate Python Script
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = aws.glue.getScript({
 *     language: "PYTHON",
 *     dagEdges: [
 *         {
 *             source: "datasource0",
 *             target: "applymapping1",
 *         },
 *         {
 *             source: "applymapping1",
 *             target: "selectfields2",
 *         },
 *         {
 *             source: "selectfields2",
 *             target: "resolvechoice3",
 *         },
 *         {
 *             source: "resolvechoice3",
 *             target: "datasink4",
 *         },
 *     ],
 *     dagNodes: [
 *         {
 *             id: "datasource0",
 *             nodeType: "DataSource",
 *             args: [
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.source.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.source.name}"`,
 *                 },
 *             ],
 *         },
 *         {
 *             id: "applymapping1",
 *             nodeType: "ApplyMapping",
 *             args: [{
 *                 name: "mapping",
 *                 value: "[(\"column1\", \"string\", \"column1\", \"string\")]",
 *             }],
 *         },
 *         {
 *             id: "selectfields2",
 *             nodeType: "SelectFields",
 *             args: [{
 *                 name: "paths",
 *                 value: "[\"column1\"]",
 *             }],
 *         },
 *         {
 *             id: "resolvechoice3",
 *             nodeType: "ResolveChoice",
 *             args: [
 *                 {
 *                     name: "choice",
 *                     value: "\"MATCH_CATALOG\"",
 *                 },
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.destination.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.destination.name}"`,
 *                 },
 *             ],
 *         },
 *         {
 *             id: "datasink4",
 *             nodeType: "DataSink",
 *             args: [
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.destination.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.destination.name}"`,
 *                 },
 *             ],
 *         },
 *     ],
 * });
 * export const pythonScript = example.then(example => example.pythonScript);
 * ```
 * ### Generate Scala Code
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = aws.glue.getScript({
 *     language: "SCALA",
 *     dagEdges: [
 *         {
 *             source: "datasource0",
 *             target: "applymapping1",
 *         },
 *         {
 *             source: "applymapping1",
 *             target: "selectfields2",
 *         },
 *         {
 *             source: "selectfields2",
 *             target: "resolvechoice3",
 *         },
 *         {
 *             source: "resolvechoice3",
 *             target: "datasink4",
 *         },
 *     ],
 *     dagNodes: [
 *         {
 *             id: "datasource0",
 *             nodeType: "DataSource",
 *             args: [
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.source.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.source.name}"`,
 *                 },
 *             ],
 *         },
 *         {
 *             id: "applymapping1",
 *             nodeType: "ApplyMapping",
 *             args: [{
 *                 name: "mappings",
 *                 value: "[(\"column1\", \"string\", \"column1\", \"string\")]",
 *             }],
 *         },
 *         {
 *             id: "selectfields2",
 *             nodeType: "SelectFields",
 *             args: [{
 *                 name: "paths",
 *                 value: "[\"column1\"]",
 *             }],
 *         },
 *         {
 *             id: "resolvechoice3",
 *             nodeType: "ResolveChoice",
 *             args: [
 *                 {
 *                     name: "choice",
 *                     value: "\"MATCH_CATALOG\"",
 *                 },
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.destination.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.destination.name}"`,
 *                 },
 *             ],
 *         },
 *         {
 *             id: "datasink4",
 *             nodeType: "DataSink",
 *             args: [
 *                 {
 *                     name: "database",
 *                     value: `"${aws_glue_catalog_database.destination.name}"`,
 *                 },
 *                 {
 *                     name: "table_name",
 *                     value: `"${aws_glue_catalog_table.destination.name}"`,
 *                 },
 *             ],
 *         },
 *     ],
 * });
 * export const scalaCode = example.then(example => example.scalaCode);
 * ```
 */
export function getScript(args: GetScriptArgs, opts?: pulumi.InvokeOptions): Promise<GetScriptResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:glue/getScript:getScript", {
        "dagEdges": args.dagEdges,
        "dagNodes": args.dagNodes,
        "language": args.language,
    }, opts);
}

/**
 * A collection of arguments for invoking getScript.
 */
export interface GetScriptArgs {
    /**
     * A list of the edges in the DAG. Defined below.
     */
    readonly dagEdges: inputs.glue.GetScriptDagEdge[];
    /**
     * A list of the nodes in the DAG. Defined below.
     */
    readonly dagNodes: inputs.glue.GetScriptDagNode[];
    /**
     * The programming language of the resulting code from the DAG. Defaults to `PYTHON`. Valid values are `PYTHON` and `SCALA`.
     */
    readonly language?: string;
}

/**
 * A collection of values returned by getScript.
 */
export interface GetScriptResult {
    readonly dagEdges: outputs.glue.GetScriptDagEdge[];
    readonly dagNodes: outputs.glue.GetScriptDagNode[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly language?: string;
    /**
     * The Python script generated from the DAG when the `language` argument is set to `PYTHON`.
     */
    readonly pythonScript: string;
    /**
     * The Scala code generated from the DAG when the `language` argument is set to `SCALA`.
     */
    readonly scalaCode: string;
}
