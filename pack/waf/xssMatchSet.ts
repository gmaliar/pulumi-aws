// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class XssMatchSet extends lumi.NamedResource implements XssMatchSetArgs {
    public readonly name: string;
    public readonly xssMatchTuples?: { fieldToMatch: { data?: string, type: string }[], textTransformation: string }[];

    public static get(id: lumi.ID): XssMatchSet {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): XssMatchSet[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: XssMatchSetArgs) {
        super(urnName);
        this.name = <any>args.name;
        this.xssMatchTuples = <any>args.xssMatchTuples;
    }
}

export interface XssMatchSetArgs {
    readonly name?: string;
    readonly xssMatchTuples?: { fieldToMatch: { data?: string, type: string }[], textTransformation: string }[];
}
