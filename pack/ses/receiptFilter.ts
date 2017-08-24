// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class ReceiptFilter extends lumi.NamedResource implements ReceiptFilterArgs {
    public readonly cidr: string;
    public readonly name: string;
    public readonly policy: string;

    public static get(id: lumi.ID): ReceiptFilter {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): ReceiptFilter[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: ReceiptFilterArgs) {
        super(urnName);
        if (lumirt.defaultIfComputed(args.cidr, "") === undefined) {
            throw new Error("Property argument 'cidr' is required, but was missing");
        }
        this.cidr = <any>args.cidr;
        this.name = <any>args.name;
        if (lumirt.defaultIfComputed(args.policy, "") === undefined) {
            throw new Error("Property argument 'policy' is required, but was missing");
        }
        this.policy = <any>args.policy;
    }
}

export interface ReceiptFilterArgs {
    readonly cidr: string;
    readonly name?: string;
    readonly policy: string;
}
