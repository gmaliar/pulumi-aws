// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class ByteMatchSet extends lumi.NamedResource implements ByteMatchSetArgs {
    public readonly byteMatchTuple?: { fieldToMatch: { data?: string, type: string }[], positionalConstraint: string, targetString?: string, textTransformation: string }[];
    public readonly name: string;

    public static get(id: lumi.ID): ByteMatchSet {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): ByteMatchSet[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: ByteMatchSetArgs) {
        super(urnName);
        this.byteMatchTuple = <any>args.byteMatchTuple;
        this.name = <any>args.name;
    }
}

export interface ByteMatchSetArgs {
    readonly byteMatchTuple?: { fieldToMatch: { data?: string, type: string }[], positionalConstraint: string, targetString?: string, textTransformation: string }[];
    readonly name?: string;
}
