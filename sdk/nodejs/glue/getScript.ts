// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to generate a Glue script from a Directed Acyclic Graph (DAG).
 */
export function getScript(args: GetScriptArgs, opts?: pulumi.InvokeOptions): Promise<GetScriptResult> {
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
    readonly dagEdges: { source: string, target: string, targetParameter?: string }[];
    /**
     * A list of the nodes in the DAG. Defined below.
     */
    readonly dagNodes: { args: { name: string, param?: boolean, value: string }[], id: string, lineNumber?: number, nodeType: string }[];
    /**
     * The programming language of the resulting code from the DAG. Defaults to `PYTHON`. Valid values are `PYTHON` and `SCALA`.
     */
    readonly language?: string;
}

/**
 * A collection of values returned by getScript.
 */
export interface GetScriptResult {
    /**
     * The Python script generated from the DAG when the `language` argument is set to `PYTHON`.
     */
    readonly pythonScript: string;
    /**
     * The Scala code generated from the DAG when the `language` argument is set to `SCALA`.
     */
    readonly scalaCode: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
